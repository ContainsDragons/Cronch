namespace Cronch
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.paddingValue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.addImages = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HeightValue = new System.Windows.Forms.NumericUpDown();
            this.widthValue = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.openImages = new System.Windows.Forms.OpenFileDialog();
            this.finalDimentions = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Button();
            this.SpriteSheetDisplay = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openAnimation = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paddingValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteSheetDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(401, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(74, 101);
            this.title.TabIndex = 0;
            this.title.Text = "C";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.paddingValue);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.addImages);
            this.groupBox1.Controls.Add(this.imageList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HeightValue);
            this.groupBox1.Controls.Add(this.widthValue);
            this.groupBox1.Font = new System.Drawing.Font("Sniglet", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(740, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 381);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Sniglet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 43);
            this.label8.TabIndex = 9;
            this.label8.Text = "Padding";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // paddingValue
            // 
            this.paddingValue.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paddingValue.Location = new System.Drawing.Point(188, 79);
            this.paddingValue.Name = "paddingValue";
            this.paddingValue.Size = new System.Drawing.Size(80, 34);
            this.paddingValue.TabIndex = 8;
            this.paddingValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.paddingValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(16, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove Image";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addImages
            // 
            this.addImages.BackColor = System.Drawing.Color.LightGreen;
            this.addImages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addImages.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addImages.Location = new System.Drawing.Point(188, 308);
            this.addImages.Name = "addImages";
            this.addImages.Size = new System.Drawing.Size(166, 57);
            this.addImages.TabIndex = 6;
            this.addImages.Text = "Add Images";
            this.addImages.UseVisualStyleBackColor = false;
            this.addImages.Click += new System.EventHandler(this.addImages_Click);
            // 
            // imageList
            // 
            this.imageList.Font = new System.Drawing.Font("Sniglet", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageList.FormattingEnabled = true;
            this.imageList.ItemHeight = 18;
            this.imageList.Location = new System.Drawing.Point(20, 132);
            this.imageList.Name = "imageList";
            this.imageList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.imageList.Size = new System.Drawing.Size(335, 166);
            this.imageList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Sniglet", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rows";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sniglet", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columns";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeightValue
            // 
            this.HeightValue.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightValue.Location = new System.Drawing.Point(275, 38);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(80, 34);
            this.HeightValue.TabIndex = 2;
            this.HeightValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // widthValue
            // 
            this.widthValue.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthValue.Location = new System.Drawing.Point(92, 38);
            this.widthValue.Name = "widthValue";
            this.widthValue.Size = new System.Drawing.Size(80, 34);
            this.widthValue.TabIndex = 1;
            this.widthValue.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sniglet", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(742, 566);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(373, 105);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cronch";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.PaleGreen;
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Sniglet", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(792, 699);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(264, 68);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 101);
            this.label1.TabIndex = 5;
            this.label1.Text = "r";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(519, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 101);
            this.label4.TabIndex = 6;
            this.label4.Text = "o";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 101);
            this.label5.TabIndex = 7;
            this.label5.Text = "n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(650, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 101);
            this.label6.TabIndex = 8;
            this.label6.Text = "c";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Sniglet", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(716, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 101);
            this.label7.TabIndex = 9;
            this.label7.Text = "h";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // finalDimentions
            // 
            this.finalDimentions.Font = new System.Drawing.Font("Sniglet", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalDimentions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.finalDimentions.Location = new System.Drawing.Point(769, 770);
            this.finalDimentions.Name = "finalDimentions";
            this.finalDimentions.Size = new System.Drawing.Size(312, 67);
            this.finalDimentions.TabIndex = 10;
            this.finalDimentions.Text = "Image Dimentions:\r\nWidth: 0px Height: 0px";
            this.finalDimentions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info.Font = new System.Drawing.Font("Sniglet", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info.ForeColor = System.Drawing.SystemColors.Window;
            this.info.Location = new System.Drawing.Point(1069, 9);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(46, 46);
            this.info.TabIndex = 11;
            this.info.Text = "i";
            this.info.UseVisualStyleBackColor = false;
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // SpriteSheetDisplay
            // 
            this.SpriteSheetDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SpriteSheetDisplay.BackgroundImage")));
            this.SpriteSheetDisplay.Location = new System.Drawing.Point(24, 162);
            this.SpriteSheetDisplay.Name = "SpriteSheetDisplay";
            this.SpriteSheetDisplay.Size = new System.Drawing.Size(700, 700);
            this.SpriteSheetDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SpriteSheetDisplay.TabIndex = 1;
            this.SpriteSheetDisplay.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(266, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Chartreuse;
            this.progressBar1.Location = new System.Drawing.Point(25, 882);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1089, 37);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 13;
            this.progressBar1.UseWaitCursor = true;
            // 
            // openAnimation
            // 
            this.openAnimation.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.openAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAnimation.Font = new System.Drawing.Font("Sniglet", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAnimation.Location = new System.Drawing.Point(980, 61);
            this.openAnimation.Name = "openAnimation";
            this.openAnimation.Size = new System.Drawing.Size(135, 73);
            this.openAnimation.TabIndex = 14;
            this.openAnimation.Text = "Animation Viewer";
            this.openAnimation.UseVisualStyleBackColor = false;
            this.openAnimation.Click += new System.EventHandler(this.openAnimation_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1127, 931);
            this.Controls.Add(this.openAnimation);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.finalDimentions);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SpriteSheetDisplay);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cronch";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paddingValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteSheetDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown widthValue;
        private System.Windows.Forms.PictureBox SpriteSheetDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown HeightValue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addImages;
        private System.Windows.Forms.ListBox imageList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog openImages;
        private System.Windows.Forms.Label finalDimentions;
        private System.Windows.Forms.Button info;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button openAnimation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown paddingValue;
    }
}

