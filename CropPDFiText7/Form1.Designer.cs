namespace CropPDFiText7
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            btnLoad = new Button();
            txtBoxLoad = new TextBox();
            btnStart = new Button();
            lblDone = new Label();
            lblAlert = new Label();
            lblFileCount = new Label();
            GitLink = new LinkLabel();
            txtBoxX = new TextBox();
            txtBoxY = new TextBox();
            txtBoxWidth = new TextBox();
            txtBoxHeight = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            IMGDone = new PictureBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)IMGDone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Location = new Point(594, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(102, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Load ...";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtBoxLoad
            // 
            txtBoxLoad.Enabled = false;
            txtBoxLoad.ForeColor = Color.Gray;
            txtBoxLoad.Location = new Point(30, 14);
            txtBoxLoad.Name = "txtBoxLoad";
            txtBoxLoad.Size = new Size(546, 27);
            txtBoxLoad.TabIndex = 1;
            txtBoxLoad.Text = "Select your folder ...";
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Location = new Point(298, 306);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.ForeColor = Color.Green;
            lblDone.Location = new Point(572, 315);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(0, 20);
            lblDone.TabIndex = 3;
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.ForeColor = Color.Red;
            lblAlert.Location = new Point(30, 82);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(0, 20);
            lblAlert.TabIndex = 4;
            // 
            // lblFileCount
            // 
            lblFileCount.AutoSize = true;
            lblFileCount.ForeColor = Color.Green;
            lblFileCount.Location = new Point(30, 53);
            lblFileCount.Name = "lblFileCount";
            lblFileCount.Size = new Size(0, 20);
            lblFileCount.TabIndex = 5;
            // 
            // GitLink
            // 
            GitLink.AutoSize = true;
            GitLink.Cursor = Cursors.Hand;
            GitLink.Location = new Point(311, 338);
            GitLink.Name = "GitLink";
            GitLink.Size = new Size(56, 20);
            GitLink.TabIndex = 6;
            GitLink.TabStop = true;
            GitLink.Text = "GitHub";
            GitLink.LinkClicked += GitLink_LinkClicked;
            // 
            // txtBoxX
            // 
            txtBoxX.Location = new Point(86, 119);
            txtBoxX.Name = "txtBoxX";
            txtBoxX.Size = new Size(125, 27);
            txtBoxX.TabIndex = 7;
            txtBoxX.Text = "580";
            // 
            // txtBoxY
            // 
            txtBoxY.Location = new Point(86, 152);
            txtBoxY.Name = "txtBoxY";
            txtBoxY.Size = new Size(125, 27);
            txtBoxY.TabIndex = 8;
            txtBoxY.Text = "0";
            // 
            // txtBoxWidth
            // 
            txtBoxWidth.Location = new Point(571, 119);
            txtBoxWidth.Name = "txtBoxWidth";
            txtBoxWidth.Size = new Size(125, 27);
            txtBoxWidth.TabIndex = 9;
            txtBoxWidth.Text = "793";
            // 
            // txtBoxHeight
            // 
            txtBoxHeight.Location = new Point(571, 152);
            txtBoxHeight.Name = "txtBoxHeight";
            txtBoxHeight.Size = new Size(125, 27);
            txtBoxHeight.TabIndex = 10;
            txtBoxHeight.Text = "1122";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 122);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 11;
            label1.Text = "X :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 159);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 12;
            label2.Text = "Y :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(488, 122);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 13;
            label3.Text = "Width :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(488, 155);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 14;
            label4.Text = "Height :";
            // 
            // IMGDone
            // 
            IMGDone.Image = Properties.Resources.Done;
            IMGDone.Location = new Point(623, 311);
            IMGDone.Name = "IMGDone";
            IMGDone.Size = new Size(25, 29);
            IMGDone.SizeMode = PictureBoxSizeMode.StretchImage;
            IMGDone.TabIndex = 15;
            IMGDone.TabStop = false;
            IMGDone.Visible = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.ForeColor = Color.Red;
            checkBox1.Location = new Point(30, 219);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(282, 24);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Crop Yellow and green paper PDF file.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Cursor = Cursors.Hand;
            checkBox2.ForeColor = Color.Red;
            checkBox2.Location = new Point(30, 249);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(139, 24);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Crop Bordereau.";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.CropPDF;
            pictureBox1.Location = new Point(287, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 148);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 367);
            Controls.Add(pictureBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(IMGDone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBoxHeight);
            Controls.Add(txtBoxWidth);
            Controls.Add(txtBoxY);
            Controls.Add(txtBoxX);
            Controls.Add(GitLink);
            Controls.Add(lblFileCount);
            Controls.Add(lblAlert);
            Controls.Add(lblDone);
            Controls.Add(btnStart);
            Controls.Add(txtBoxLoad);
            Controls.Add(btnLoad);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crop PDF using iText7";
            DragDrop += frmMain_DragDrop;
            DragEnter += frmMain_DragEnter;
            ((System.ComponentModel.ISupportInitialize)IMGDone).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private TextBox txtBoxLoad;
        private Button btnStart;
        private Label lblDone;
        private Label lblAlert;
        private Label lblFileCount;
        private LinkLabel GitLink;
        private TextBox txtBoxX;
        private TextBox txtBoxY;
        private TextBox txtBoxWidth;
        private TextBox txtBoxHeight;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox IMGDone;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
    }
}
