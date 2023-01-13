using System;

namespace UnexpectedProjection
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlackOut = new System.Windows.Forms.Button();
            this.gbMargins = new System.Windows.Forms.GroupBox();
            this.upFadeOutSecs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFadeTime = new System.Windows.Forms.Label();
            this.udFadeTime = new System.Windows.Forms.NumericUpDown();
            this.udBottom = new System.Windows.Forms.NumericUpDown();
            this.udRight = new System.Windows.Forms.NumericUpDown();
            this.udTop = new System.Windows.Forms.NumericUpDown();
            this.udLeft = new System.Windows.Forms.NumericUpDown();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnTestImage = new System.Windows.Forms.Button();
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.btnProject = new System.Windows.Forms.Button();
            this.lbScreens = new System.Windows.Forms.ListBox();
            this.btnRefreshScreens = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbMargins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upFadeOutSecs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFadeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBlackOut);
            this.panel1.Controls.Add(this.gbMargins);
            this.panel1.Controls.Add(this.btnPaste);
            this.panel1.Controls.Add(this.btnTestImage);
            this.panel1.Controls.Add(this.btnChooseFolder);
            this.panel1.Controls.Add(this.tbPath);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnListen);
            this.panel1.Controls.Add(this.btnProject);
            this.panel1.Controls.Add(this.lbScreens);
            this.panel1.Controls.Add(this.btnRefreshScreens);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 314);
            this.panel1.TabIndex = 0;
            // 
            // btnBlackOut
            // 
            this.btnBlackOut.Location = new System.Drawing.Point(115, 116);
            this.btnBlackOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnBlackOut.Name = "btnBlackOut";
            this.btnBlackOut.Size = new System.Drawing.Size(99, 34);
            this.btnBlackOut.TabIndex = 10;
            this.btnBlackOut.Text = "&Black Out";
            this.btnBlackOut.UseVisualStyleBackColor = true;
            this.btnBlackOut.Click += new System.EventHandler(this.BtnBlackOut_Click);
            // 
            // gbMargins
            // 
            this.gbMargins.Controls.Add(this.upFadeOutSecs);
            this.gbMargins.Controls.Add(this.label2);
            this.gbMargins.Controls.Add(this.lblFadeTime);
            this.gbMargins.Controls.Add(this.udFadeTime);
            this.gbMargins.Controls.Add(this.udBottom);
            this.gbMargins.Controls.Add(this.udRight);
            this.gbMargins.Controls.Add(this.udTop);
            this.gbMargins.Controls.Add(this.udLeft);
            this.gbMargins.Location = new System.Drawing.Point(9, 191);
            this.gbMargins.Margin = new System.Windows.Forms.Padding(2);
            this.gbMargins.Name = "gbMargins";
            this.gbMargins.Padding = new System.Windows.Forms.Padding(2);
            this.gbMargins.Size = new System.Drawing.Size(772, 107);
            this.gbMargins.TabIndex = 9;
            this.gbMargins.TabStop = false;
            this.gbMargins.Text = "Margins";
            // 
            // upFadeOutSecs
            // 
            this.upFadeOutSecs.Location = new System.Drawing.Point(422, 56);
            this.upFadeOutSecs.Name = "upFadeOutSecs";
            this.upFadeOutSecs.Size = new System.Drawing.Size(47, 20);
            this.upFadeOutSecs.TabIndex = 8;
            this.upFadeOutSecs.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.upFadeOutSecs.ValueChanged += new System.EventHandler(this.upFadeOutSecs_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fade Out After...";
            // 
            // lblFadeTime
            // 
            this.lblFadeTime.AutoSize = true;
            this.lblFadeTime.Location = new System.Drawing.Point(331, 27);
            this.lblFadeTime.Name = "lblFadeTime";
            this.lblFadeTime.Size = new System.Drawing.Size(76, 13);
            this.lblFadeTime.TabIndex = 6;
            this.lblFadeTime.Text = "Fade Seconds";
            // 
            // udFadeTime
            // 
            this.udFadeTime.Location = new System.Drawing.Point(422, 25);
            this.udFadeTime.Name = "udFadeTime";
            this.udFadeTime.Size = new System.Drawing.Size(47, 20);
            this.udFadeTime.TabIndex = 5;
            this.udFadeTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udFadeTime.ValueChanged += new System.EventHandler(this.udFadeTime_ValueChanged);
            // 
            // udBottom
            // 
            this.udBottom.Location = new System.Drawing.Point(111, 63);
            this.udBottom.Margin = new System.Windows.Forms.Padding(2);
            this.udBottom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udBottom.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udBottom.Name = "udBottom";
            this.udBottom.Size = new System.Drawing.Size(80, 20);
            this.udBottom.TabIndex = 3;
            this.udBottom.ValueChanged += new System.EventHandler(this.UdBottom_ValueChanged);
            // 
            // udRight
            // 
            this.udRight.Location = new System.Drawing.Point(202, 45);
            this.udRight.Margin = new System.Windows.Forms.Padding(2);
            this.udRight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udRight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udRight.Name = "udRight";
            this.udRight.Size = new System.Drawing.Size(80, 20);
            this.udRight.TabIndex = 2;
            this.udRight.ValueChanged += new System.EventHandler(this.UdRight_ValueChanged);
            // 
            // udTop
            // 
            this.udTop.Location = new System.Drawing.Point(111, 30);
            this.udTop.Margin = new System.Windows.Forms.Padding(2);
            this.udTop.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udTop.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udTop.Name = "udTop";
            this.udTop.Size = new System.Drawing.Size(80, 20);
            this.udTop.TabIndex = 1;
            this.udTop.ValueChanged += new System.EventHandler(this.UdTop_ValueChanged);
            // 
            // udLeft
            // 
            this.udLeft.Location = new System.Drawing.Point(16, 45);
            this.udLeft.Margin = new System.Windows.Forms.Padding(2);
            this.udLeft.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.udLeft.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.udLeft.Name = "udLeft";
            this.udLeft.Size = new System.Drawing.Size(80, 20);
            this.udLeft.TabIndex = 0;
            this.udLeft.ValueChanged += new System.EventHandler(this.UdLeft_ValueChanged);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(9, 116);
            this.btnPaste.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(99, 34);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "&Paste From Clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // btnTestImage
            // 
            this.btnTestImage.Location = new System.Drawing.Point(525, 133);
            this.btnTestImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnTestImage.Name = "btnTestImage";
            this.btnTestImage.Size = new System.Drawing.Size(72, 34);
            this.btnTestImage.TabIndex = 7;
            this.btnTestImage.Text = "Test Image";
            this.btnTestImage.UseVisualStyleBackColor = true;
            this.btnTestImage.Click += new System.EventHandler(this.BtnTestImage_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(9, 56);
            this.btnChooseFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(72, 34);
            this.btnChooseFolder.TabIndex = 6;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(85, 56);
            this.tbPath.Margin = new System.Windows.Forms.Padding(2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(513, 20);
            this.tbPath.TabIndex = 5;
            this.tbPath.Text = "c:\\temp\\projection\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Monitors";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(211, 18);
            this.btnListen.Margin = new System.Windows.Forms.Padding(2);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(99, 34);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Stop Listening";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(9, 18);
            this.btnProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(198, 34);
            this.btnProject.TabIndex = 2;
            this.btnProject.Text = "Start Projecting";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.BtnProject_Click);
            // 
            // lbScreens
            // 
            this.lbScreens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbScreens.FormattingEnabled = true;
            this.lbScreens.Location = new System.Drawing.Point(601, 34);
            this.lbScreens.Margin = new System.Windows.Forms.Padding(2);
            this.lbScreens.Name = "lbScreens";
            this.lbScreens.Size = new System.Drawing.Size(180, 134);
            this.lbScreens.TabIndex = 1;
            this.lbScreens.SelectedIndexChanged += new System.EventHandler(this.LbScreens_SelectedIndexChanged);
            // 
            // btnRefreshScreens
            // 
            this.btnRefreshScreens.Location = new System.Drawing.Point(525, 95);
            this.btnRefreshScreens.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefreshScreens.Name = "btnRefreshScreens";
            this.btnRefreshScreens.Size = new System.Drawing.Size(72, 34);
            this.btnRefreshScreens.TabIndex = 0;
            this.btnRefreshScreens.Text = "Refresh Screens";
            this.btnRefreshScreens.UseVisualStyleBackColor = true;
            this.btnRefreshScreens.Click += new System.EventHandler(this.BtnRefreshScreens_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 314);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Unexpected Projection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMargins.ResumeLayout(false);
            this.gbMargins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upFadeOutSecs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udFadeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udLeft)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbScreens;
        private System.Windows.Forms.Button btnRefreshScreens;
        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnTestImage;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.GroupBox gbMargins;
        private System.Windows.Forms.NumericUpDown udBottom;
        private System.Windows.Forms.NumericUpDown udRight;
        private System.Windows.Forms.NumericUpDown udTop;
        private System.Windows.Forms.NumericUpDown udLeft;
        private System.Windows.Forms.Button btnBlackOut;
        private System.Windows.Forms.NumericUpDown udFadeTime;
        private System.Windows.Forms.Label lblFadeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown upFadeOutSecs;
    }
}

