using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronch
{
    public partial class AnimationViewer : System.Windows.Forms.Form
    {

        private List<string> fileNames = new List<string>(); //file names
        private List<string> filePaths = new List<string>(); //file paths

        private List<Image> addedFrames = new List<Image>(); //frames in animation
        private List<string> addedFrameNames = new List<string>();

        private int speed; //playback speed

        private bool isPaused = true; //if anim is paused

        private int currentFrame = 0; //current frame to render

        public AnimationViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is called when the <see cref="Form.openAnimation"/> button is clicked.
        /// </summary>
        /// <param name="_files">The file names</param>
        /// <param name="_paths">The file paths</param>
        public void GetImages(List<string> _files, List<string> _paths)
        {
            fileNames = _files;
            filePaths = _paths;
            foreach (var item in _files)
            {
                frameList.Items.Add(item); //adds them to the list display
            }
        }

        private void AnimationViewer_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Adds selected images to the frames in anim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addImages_Click(object sender, EventArgs e)
        {
            if (frameOrder.Text == "No Frames Added Yet")
            {
                frameOrder.Text = "";
            }
            foreach (var item in frameList.SelectedItems)
            {
                Image image = Image.FromFile(filePaths[fileNames.IndexOf((string)item)]); //gets the file path of the name selected
                addedFrames.Add(image);
                //Debug.WriteLine($"added {filePaths[fileNames.IndexOf((string)item)]}");
                frameOrder.Text += $"{item}\n"; //adds name to frame order
                addedFrameNames.Add((string)item);
            }
        }

        /// <summary>
        /// Plays the animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play_Click(object sender, EventArgs e)
        {
            if (addedFrames.Count == 0 || addedFrames == null)
            {
                return;
            }
            speed = (int)speedbox.Value; //speed
            timer1.Interval = 1000 / speed; //FPS (kind of)
            isPaused = false;
            timer1.Start(); //start the timer
        }

        /// <summary>
        /// checks the current frame is at the end of the sequence and returns the frame
        /// </summary>
        /// <returns>Image to be rendered</returns>
        private Image CurrentFrame()
        {
            if (currentFrame == addedFrames.Count)
            {
                currentFrame = 0;
            }
            return addedFrames[currentFrame];
        }

        /// <summary>
        /// This is the timer, every time it ticks it sets the frame
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!isPaused)
            {
                frameDisplay.Image = CurrentFrame();
                currentFrame++;
            }
        }

        /// <summary>
        /// Pauses the animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            timer1.Stop();
        }

        /// <summary>
        /// Resets all the values without having to pause and play
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetAnimation_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            currentFrame = 0;
            speed = (int)speedbox.Value;
            timer1.Interval = 1000 / speed;
            isPaused = true;
            timer1.Start();
            isPaused = false;
        }

        /// <summary>
        /// Remove from list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (addedFrames == null || addedFrames.Count == 0)
            {
                return;
            }
            if (frameList.SelectedItems == null) 
            {
                return;
            }
            foreach (var frame in frameList.SelectedItems)
            {
                //removes frames from animation
                addedFrameNames.Remove((string)frame);
                frameOrder.Text = "";
            }

            foreach (var item in addedFrameNames)
            {
                frameOrder.Text = frameOrder.Text + $"{item}\n"; //adds name to frame order
            }

            //resets the animation
            timer1.Stop();
            currentFrame = 0;
            speed = (int)speedbox.Value;
            timer1.Interval = 1000 / speed;
            timer1.Start();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            frameDisplay.Image = null;
            timer1.Stop();
            currentFrame = 0;
            addedFrames = null;
            frameOrder.Text = "No Frames Added Yet";
        }
    }
}
