namespace Cronch
{
    partial class AnimationViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationViewer));
            this.frameDisplay = new System.Windows.Forms.PictureBox();
            this.resetAnimation = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.addImages = new System.Windows.Forms.Button();
            this.frameOrder = new System.Windows.Forms.Label();
            this.frameList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speedbox = new System.Windows.Forms.NumericUpDown();
            this.play = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.frameDisplay)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedbox)).BeginInit();
            this.SuspendLayout();
            // 
            // frameDisplay
            // 
            this.frameDisplay.BackgroundImage = global::Cronch.Properties.Resources.checkergrid;
            this.frameDisplay.Location = new System.Drawing.Point(23, 26);
            this.frameDisplay.Name = "frameDisplay";
            this.frameDisplay.Size = new System.Drawing.Size(700, 700);
            this.frameDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.frameDisplay.TabIndex = 2;
            this.frameDisplay.TabStop = false;
            // 
            // resetAnimation
            // 
            this.resetAnimation.BackColor = System.Drawing.Color.Aquamarine;
            this.resetAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetAnimation.Font = new System.Drawing.Font("Sniglet", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAnimation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetAnimation.Location = new System.Drawing.Point(359, 740);
            this.resetAnimation.Name = "resetAnimation";
            this.resetAnimation.Size = new System.Drawing.Size(222, 55);
            this.resetAnimation.TabIndex = 3;
            this.resetAnimation.Text = "Reset";
            this.resetAnimation.UseVisualStyleBackColor = false;
            this.resetAnimation.Click += new System.EventHandler(this.resetAnimation_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.addImages);
            this.groupBox1.Controls.Add(this.frameOrder);
            this.groupBox1.Controls.Add(this.frameList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.speedbox);
            this.groupBox1.Font = new System.Drawing.Font("Sniglet", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(739, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 684);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animation Options";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Cornsilk;
            this.button3.Location = new System.Drawing.Point(20, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Remove Frames";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // addImages
            // 
            this.addImages.BackColor = System.Drawing.Color.LightGreen;
            this.addImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImages.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImages.Location = new System.Drawing.Point(14, 285);
            this.addImages.Name = "addImages";
            this.addImages.Size = new System.Drawing.Size(191, 57);
            this.addImages.TabIndex = 8;
            this.addImages.Text = "Add Frames";
            this.addImages.UseVisualStyleBackColor = false;
            this.addImages.Click += new System.EventHandler(this.addImages_Click);
            // 
            // frameOrder
            // 
            this.frameOrder.AutoEllipsis = true;
            this.frameOrder.Font = new System.Drawing.Font("Sniglet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameOrder.Location = new System.Drawing.Point(16, 395);
            this.frameOrder.Name = "frameOrder";
            this.frameOrder.Size = new System.Drawing.Size(189, 286);
            this.frameOrder.TabIndex = 3;
            this.frameOrder.Text = "No Frames Added Yet";
            // 
            // frameList
            // 
            this.frameList.Font = new System.Drawing.Font("Sniglet", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frameList.FormattingEnabled = true;
            this.frameList.ItemHeight = 16;
            this.frameList.Location = new System.Drawing.Point(14, 83);
            this.frameList.Name = "frameList";
            this.frameList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.frameList.Size = new System.Drawing.Size(192, 196);
            this.frameList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Speed";
            // 
            // speedbox
            // 
            this.speedbox.Location = new System.Drawing.Point(78, 40);
            this.speedbox.Name = "speedbox";
            this.speedbox.Size = new System.Drawing.Size(129, 31);
            this.speedbox.TabIndex = 0;
            this.speedbox.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Khaki;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Sniglet", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.Location = new System.Drawing.Point(23, 740);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(140, 55);
            this.play.TabIndex = 5;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Pink;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Font = new System.Drawing.Font("Sniglet", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.Black;
            this.pause.Location = new System.Drawing.Point(192, 740);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(140, 55);
            this.pause.TabIndex = 6;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.MediumVioletRed;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Sniglet", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(858, 737);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(102, 61);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // AnimationViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(972, 816);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.play);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resetAnimation);
            this.Controls.Add(this.frameDisplay);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimationViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation Viewer";
            this.Load += new System.EventHandler(this.AnimationViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frameDisplay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.speedbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox frameDisplay;
        private System.Windows.Forms.Button resetAnimation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown speedbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button addImages;
        private System.Windows.Forms.Label frameOrder;
        private System.Windows.Forms.ListBox frameList;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button clear;
    }
}