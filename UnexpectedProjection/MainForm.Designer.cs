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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 483);
            this.panel1.TabIndex = 0;
            // 
            // btnBlackOut
            // 
            this.btnBlackOut.Location = new System.Drawing.Point(173, 178);
            this.btnBlackOut.Name = "btnBlackOut";
            this.btnBlackOut.Size = new System.Drawing.Size(149, 53);
            this.btnBlackOut.TabIndex = 10;
            this.btnBlackOut.Text = "&Black Out";
            this.btnBlackOut.UseVisualStyleBackColor = true;
            this.btnBlackOut.Click += new System.EventHandler(this.BtnBlackOut_Click);
            // 
            // gbMargins
            // 
            this.gbMargins.Controls.Add(this.udBottom);
            this.gbMargins.Controls.Add(this.udRight);
            this.gbMargins.Controls.Add(this.udTop);
            this.gbMargins.Controls.Add(this.udLeft);
            this.gbMargins.Location = new System.Drawing.Point(13, 294);
            this.gbMargins.Name = "gbMargins";
            this.gbMargins.Size = new System.Drawing.Size(1155, 165);
            this.gbMargins.TabIndex = 9;
            this.gbMargins.TabStop = false;
            this.gbMargins.Text = "Margins";
            // 
            // udBottom
            // 
            this.udBottom.Location = new System.Drawing.Point(303, 76);
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
            this.udBottom.Size = new System.Drawing.Size(120, 26);
            this.udBottom.TabIndex = 3;
            this.udBottom.ValueChanged += new System.EventHandler(this.UdBottom_ValueChanged);
            // 
            // udRight
            // 
            this.udRight.Location = new System.Drawing.Point(439, 48);
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
            this.udRight.Size = new System.Drawing.Size(120, 26);
            this.udRight.TabIndex = 2;
            this.udRight.ValueChanged += new System.EventHandler(this.UdRight_ValueChanged);
            // 
            // udTop
            // 
            this.udTop.Location = new System.Drawing.Point(303, 25);
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
            this.udTop.Size = new System.Drawing.Size(120, 26);
            this.udTop.TabIndex = 1;
            this.udTop.ValueChanged += new System.EventHandler(this.UdTop_ValueChanged);
            // 
            // udLeft
            // 
            this.udLeft.Location = new System.Drawing.Point(160, 48);
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
            this.udLeft.Size = new System.Drawing.Size(120, 26);
            this.udLeft.TabIndex = 0;
            this.udLeft.ValueChanged += new System.EventHandler(this.UdLeft_ValueChanged);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(13, 178);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(149, 53);
            this.btnPaste.TabIndex = 8;
            this.btnPaste.Text = "&Paste From Clipboard";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // btnTestImage
            // 
            this.btnTestImage.Location = new System.Drawing.Point(787, 204);
            this.btnTestImage.Name = "btnTestImage";
            this.btnTestImage.Size = new System.Drawing.Size(108, 53);
            this.btnTestImage.TabIndex = 7;
            this.btnTestImage.Text = "Test Image";
            this.btnTestImage.UseVisualStyleBackColor = true;
            this.btnTestImage.Click += new System.EventHandler(this.BtnTestImage_Click);
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Location = new System.Drawing.Point(13, 86);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(108, 53);
            this.btnChooseFolder.TabIndex = 6;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.BtnChooseFolder_Click);
            // 
            // tbPath
            // 
            this.tbPath.Enabled = false;
            this.tbPath.Location = new System.Drawing.Point(127, 86);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(768, 26);
            this.tbPath.TabIndex = 5;
            this.tbPath.Text = "c:\\temp\\projection\\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "&Monitors";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(316, 27);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(149, 53);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Stop Listening";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(13, 27);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(297, 53);
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
            this.lbScreens.ItemHeight = 20;
            this.lbScreens.Location = new System.Drawing.Point(901, 53);
            this.lbScreens.Name = "lbScreens";
            this.lbScreens.Size = new System.Drawing.Size(268, 204);
            this.lbScreens.TabIndex = 1;
            this.lbScreens.SelectedIndexChanged += new System.EventHandler(this.LbScreens_SelectedIndexChanged);
            // 
            // btnRefreshScreens
            // 
            this.btnRefreshScreens.Location = new System.Drawing.Point(787, 146);
            this.btnRefreshScreens.Name = "btnRefreshScreens";
            this.btnRefreshScreens.Size = new System.Drawing.Size(108, 52);
            this.btnRefreshScreens.TabIndex = 0;
            this.btnRefreshScreens.Text = "Refresh Screens";
            this.btnRefreshScreens.UseVisualStyleBackColor = true;
            this.btnRefreshScreens.Click += new System.EventHandler(this.BtnRefreshScreens_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 483);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Unexpected Projection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Close);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbMargins.ResumeLayout(false);
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
    }
}

