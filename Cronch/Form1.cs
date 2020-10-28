using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cronch
{
    public partial class Form : System.Windows.Forms.Form
    {
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

        public Form()
        {
            InitializeComponent();
            letters = new Label[] { title, label1, label4, label5, label6, label7 }; //wavy text
            timer1.Start(); //wavy text
            progressBar1.Visible = false; //makes the bar not visible
        }
        /*
        private void Form_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (!hasSaved)
            {
                if (MessageBox.Show("You have unsaved changes! Are you sure you want to exit?", "Wait!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }
            if (File.Exists($"{tempDirectory}\\tempSheet.png"))
            {
                File.Delete($"{tempDirectory}\\tempSheet.png");
            }
            Directory.Delete(tempDirectory);
        }
        */

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

            finalDimentions.Text =
                "Image Dimentions:" +
                $"\nWidth: {imageWidth}px Height: {imageHeight}px";

        }

        /// <summary>
        /// Merge all images together
        /// </summary>
        private void MergeImages()
        {
            //loaderbar
            progressBar1.Maximum = listOfImages.Count() + 1;
            progressBar1.Minimum = 0;
            progressBar1.Visible = true;
            //get the first image to check for all sizes
            int firstImageWidth, firstImageHeight;
            firstImageWidth = listOfImages[0].Width;
            firstImageHeight = listOfImages[0].Height;
            foreach (var image in listOfImages)
            {
                if (image == listOfImages[0])
                {
                    continue;
                }
                if (image.Width != firstImageWidth || image.Height != firstImageHeight)
                {
                    MessageBox.Show($"All Images Must Be The Same Width And Height (Currently)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            int currentX = 0; //current X pixel
            int currentY = 0; //current Y pixel
            Bitmap finalImage = new Bitmap(imageWidth, imageHeight); //makes the final image
            using (Graphics g = Graphics.FromImage(finalImage))
            {
                for (int i = 0; i < listOfImages.Count; i++)
                {
                    //if the X is off the image put it back and go down
                    if (currentX >= finalImage.Width)
                    {
                        currentX = 0;
                        currentY += allImageHeights.Max();
                    }
                    g.DrawImage(listOfImages[i], currentX, currentY); //draws the image to the final image
                    currentX += listOfImages[i].Width; //move it to the side
                    progressBar1.Value++; //progress bar
                    //Debug.WriteLine($"\nCurrent Image {i} Current x: {currentX} Current y: {currentY}\n");
                }
            }

            //save file to temp
            finalImage.Save($"{tempDirectory}\\tempSheet.png", ImageFormat.Png);
            SpriteSheetDisplay.Image = finalImage; //set the display image
            //clear all the lists
            listOfImages.Clear();
            allImageHeights.Clear();
            allImageWidths.Clear();
            progressBar1.Value = 0;
            progressBar1.Visible = false;
        }

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

        //open info
        private void info_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
