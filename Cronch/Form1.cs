using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Drawing2D;

namespace Cronch
{
    public partial class Form : System.Windows.Forms.Form
    {
        #region Vars
        //These are for the wavy letters
        private int[] offset = { 3, 3, 4, 4, 5, 5 };
        private bool[] isMovingDown = { false, false, false, false, false, false };
        private Label[] letters = { };
        private int i = 0;

        //These are lists of file paths and names for all the images added
        private List<string> filePaths = new List<string>();
        private List<string> fileNames = new List<string>();

        //The temp folder directory
        private string tempDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\CronchTemp";

        //The final image stats
        private int columns;
        private int rows;
        private int imageWidth;
        private int imageHeight;

        //All the images passed in from fileNames
        private List<Image> listOfImages = new List<Image>();

        //All the images width and height
        private List<int> allImageWidths = new List<int>();
        private List<int> allImageHeights = new List<int>();

        private List<Image> newCroppedImages = new List<Image>();

        private int imagePadding;

        #endregion

        #region Constructor
        public Form()
        {
            InitializeComponent();
            letters = new Label[] { title, label1, label4, label5, label6, label7 }; //wavy text
            timer1.Start(); //wavy text
            progressBar1.Visible = false; //makes the bar not visible
        }
        #endregion

        #region Wavy Letters
        /// <summary>
        /// This is for the wavy text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i == letters.Length) //checks if letters have gone through cycle
            {
                i = 0;
            }
            if (letters[i].Location.Y > 30) //checks if it is at the top
            {
                isMovingDown[i] = true;
            }
            else if (letters[i].Location.Y < 0) //checks if at the bottem
            {
                isMovingDown[i] = false;
            }
            if (isMovingDown[i])
            {
                letters[i].Location = new Point(letters[i].Location.X, letters[i].Location.Y + 1 - offset[i]); //move based on offset
            }
            else
            {
                letters[i].Location = new Point(letters[i].Location.X, letters[i].Location.Y - 1 + offset[i]);//move based on offset
            }
            i++; //add index by one

        }

        #endregion

        #region Get And Remove Images
        //opens file dialogue
        private void addImages_Click(object sender, EventArgs e)
        {
            GetImagesFromFileDialogue();
        }

        /// <summary>
        /// This opens the OpenFileDialogue
        /// </summary>
        private void GetImagesFromFileDialogue()
        {
            openImages.Multiselect = true;
            openImages.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG"; //Only PNGs and JPGs

            if (openImages.ShowDialog() == DialogResult.OK) //if "ok"
            {
                foreach (var file in openImages.FileNames) //file is one file path, FileNames is all selected
                {
                    filePaths.Add(file); //add to filePaths
                    fileNames.Add(file.Split('\\').Last()); //this splits the path by the \ and gets the last part (filename.extention)
                    imageList.Items.Add(file.Split('\\').Last()); //this adds it to the image list
                }
            }


        }

        /// <summary>
        /// Button1 is the remove button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList.SelectedItems == null)
            {
                return;
            }
            foreach (var item in imageList.SelectedItems)//gets selected items
            {
                filePaths.RemoveAt(fileNames.IndexOf((string)item)); //takes away the string based on the index
                fileNames.Remove((string)item);
            }

            imageList.Items.Clear(); //clears the list
            foreach (var file in fileNames)
            {
                imageList.Items.Add(file); //adds the list again
            }
        }

        #endregion

        #region Compile Images
        /// <summary>
        /// button2 is the "Cronch" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (filePaths != null)
            {
                if (filePaths.Count < 2) 
                {
                    MessageBox.Show($"You have to have more than one image!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (var file in filePaths)
                {
                    if (!File.Exists(file))
                    {
                        MessageBox.Show($"Cant find {file.Split('\\').Last()} at {file}!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                GetImageWidthAndHeight();

            }
        }

        /// <summary>
        /// Gets the images width and heights and calculates the final image size
        /// </summary>
        private void GetImageWidthAndHeight()
        {
            rows = (int)widthValue.Value;
            columns = (int)HeightValue.Value;

            if (rows <= 0 || columns <= 0)
            {
                MessageBox.Show($"The rows and colums cannot have a value less than or equal to 0", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Directory.Exists(tempDirectory))
            {
                Directory.CreateDirectory(tempDirectory);
            }

            foreach (var file in filePaths)
            {
                Image image = Image.FromFile(file);
                listOfImages.Add(image); //makes an image from the file paths and adds it to listOfImages
            }

            foreach (var image in listOfImages)
            {
                allImageWidths.Add(image.Width);
                allImageHeights.Add(image.Height); //gets widths and heights
            }

            imageWidth = allImageWidths.Max() * rows; //gets the max height (does not matter they should be the same) and multiplies it by the rows
            imageHeight = allImageHeights.Max() * columns; //gets the max height (does not matter they should be the same) and multiplies it by the columns

            //Debug.WriteLine(imageHeight);
            //Debug.WriteLine(imageWidth); 

            MergeImages();

        }

        /// <summary>
        /// THIS CODE BELOW WAS WRITTEN BY https://stackoverflow.com/a/3271475 on stack overflow
        /// </summary>
        /// <param name="original"></param>
        /// <returns>A cropped image</returns>
        private Bitmap CropImage(Bitmap original)
        {

            Point min = new Point(int.MaxValue, int.MaxValue);
            Point max = new Point(int.MinValue, int.MinValue);

            for (int x = 0; x < original.Width; ++x)
            {
                for (int y = 0; y < original.Height; ++y)
                {
                    Color pixelColor = original.GetPixel(x, y);
                    if (pixelColor.A != 0)
                    {
                        if (x < min.X) min.X = x;
                        if (y < min.Y) min.Y = y;

                        if (x > max.X) max.X = x;
                        if (y > max.Y) max.Y = y;
                    }
                }
            }

            // Create a new bitmap from the crop rectangle
            Rectangle cropRectangle = new Rectangle(min.X, min.Y, (max.X - min.X), (max.Y - min.Y));
            Bitmap newBitmap = new Bitmap(cropRectangle.Width, cropRectangle.Height);
            using (Graphics g = Graphics.FromImage(newBitmap))
            {
                g.DrawImage(original, 0, 0, cropRectangle, GraphicsUnit.Pixel);
            }

            newBitmap = AddPadding(newBitmap); //this was written by me

            return newBitmap;
        }

        /// <summary>
        /// Surrounds the image in transparency
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        private Bitmap AddPadding(Bitmap image)
        {
            Bitmap biggerBitmap = new Bitmap(image.Width + imagePadding, image.Height + imagePadding); //makes image bigger
            using (Graphics g = Graphics.FromImage(biggerBitmap))
            {
                //makes image in the center
                g.TranslateTransform(biggerBitmap.Width / 2, biggerBitmap.Height / 2);
                g.DrawImage(image, -(image.Width / 2), -(image.Height / 2), image.Width, image.Height);
            }
            return biggerBitmap;
        }

        /// <summary>
        /// Merge all images together
        /// </summary>
        private void MergeImages()
        {
            //crops the images
            foreach (var image in listOfImages)
            {
                newCroppedImages.Add(CropImage((Bitmap)image));
            }

            //loaderbar
            progressBar1.Maximum = listOfImages.Count() + 1;
            progressBar1.Minimum = 0;
            progressBar1.Visible = true;

            //where to draw image
            int currentX = 0;
            int currentY = 0;

            //largest width and height
            int largestWidth = 0;
            int largestHeight = 0;

            //padding
            imagePadding = (int)paddingValue.Value;

            //this cycles through each image and if the image dimentions is bigger than the one in the variable, set it.
            foreach (var item in newCroppedImages)
            {
                if (largestHeight == 0)
                {
                    largestHeight = item.Height;
                }
                else if (largestHeight < item.Height)
                {
                    largestHeight = item.Height;
                }
                if (largestWidth == 0)
                {
                    largestWidth = item.Width;
                }
                else if (largestWidth < item.Width)
                {
                    largestWidth = item.Width;
                }
            }

            //gets final width and height
            int finalWitdth = largestWidth * columns;
            int finalHeight = largestHeight * rows;

            //final image
            Bitmap finalImage = new Bitmap(finalWitdth, finalHeight);

            //go through each image
            for (int i = 0; i < newCroppedImages.Count; i++)
            {
                //Safty check (so it doesent get cut off)
                currentX += newCroppedImages[i].Width;
                if (currentX >= finalImage.Width)
                {
                    currentX = 0;
                    currentY += largestHeight;
                }
                else
                {
                    currentX -= newCroppedImages[i].Width;
                }

                //draw the image
                using (Graphics g = Graphics.FromImage(finalImage))
                {
                    g.CompositingMode = CompositingMode.SourceCopy;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.SmoothingMode = SmoothingMode.HighQuality;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        g.DrawImage(newCroppedImages[i], currentX, currentY, newCroppedImages[i].Width, newCroppedImages[i].Height);
                    }
                    //shift next image
                    currentX += newCroppedImages[i].Width;
                    progressBar1.Value++;
                }

            }

            //save to temp
            finalImage.Save($"{tempDirectory}\\tempSheet.png", ImageFormat.Png);
            //display
            SpriteSheetDisplay.Image = finalImage;

            //clear
            newCroppedImages.Clear();
            listOfImages.Clear();
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            //display dimentions
            finalDimentions.Text =
                "Image Dimentions:" +
                $"\nWidth: {finalWitdth}px Height: {finalHeight}px";

        }

        #endregion

        #region Save
        /// <summary>
        /// saves the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Click(object sender, EventArgs e)
        {
            if (File.Exists($"{tempDirectory}\\tempSheet.png"))
            {
                saveFileDialog1.Filter = "Images (*.JPG;*.PNG)|*.JPG;*.PNG";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    Image image = Image.FromFile($"{tempDirectory}\\tempSheet.png");
                    image.Save($"{saveFileDialog1.FileName}", ImageFormat.Png); //save it
                }
            }
            else
            {
                return;
            }
        }

        #endregion

        #region Animation Viewer
        private void openAnimation_Click(object sender, EventArgs e)
        {
            if (filePaths.Count < 2)
            {
                MessageBox.Show($"There must be more than two images!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AnimationViewer anim = new AnimationViewer();
            anim.Show();
            anim.GetImages(fileNames, filePaths);
        }
        #endregion

        #region Misc
        //open info
        private void info_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
