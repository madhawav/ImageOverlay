namespace Image_Overlay
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
            this.components = new System.ComponentModel.Container();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdMask = new System.Windows.Forms.OpenFileDialog();
            this.btnProcess = new System.Windows.Forms.Button();
            this.prgConversionProgress = new System.Windows.Forms.ProgressBar();
            this.pnlHUD = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPanBrowse = new System.Windows.Forms.Button();
            this.txtPanMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPBrowse = new System.Windows.Forms.Button();
            this.txtPMask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLBrowse = new System.Windows.Forms.Button();
            this.txtLMask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddImages = new System.Windows.Forms.Button();
            this.lstPreviewList = new System.Windows.Forms.ListView();
            this.imgThumbnails = new System.Windows.Forms.ImageList(this.components);
            this.timThumbnailLoader = new System.Windows.Forms.Timer(this.components);
            this.btnBreak = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHUD.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "JPEG Image|*.jpg|All Files|*.*";
            this.ofdImage.Multiselect = true;
            this.ofdImage.Title = "Select Images";
            // 
            // ofdMask
            // 
            this.ofdMask.Filter = "PNG Image|*.png|All Files|*.*";
            this.ofdMask.Title = "Select Mask";
            // 
            // btnProcess
            // 
            this.btnProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProcess.Location = new System.Drawing.Point(16, 424);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 8;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // prgConversionProgress
            // 
            this.prgConversionProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgConversionProgress.Location = new System.Drawing.Point(108, 424);
            this.prgConversionProgress.Name = "prgConversionProgress";
            this.prgConversionProgress.Size = new System.Drawing.Size(427, 23);
            this.prgConversionProgress.TabIndex = 9;
            // 
            // pnlHUD
            // 
            this.pnlHUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHUD.Controls.Add(this.label4);
            this.pnlHUD.Controls.Add(this.btnPanBrowse);
            this.pnlHUD.Controls.Add(this.txtPanMask);
            this.pnlHUD.Controls.Add(this.label3);
            this.pnlHUD.Controls.Add(this.btnPBrowse);
            this.pnlHUD.Controls.Add(this.txtPMask);
            this.pnlHUD.Controls.Add(this.label2);
            this.pnlHUD.Controls.Add(this.btnLBrowse);
            this.pnlHUD.Controls.Add(this.txtLMask);
            this.pnlHUD.Controls.Add(this.label1);
            this.pnlHUD.Controls.Add(this.btnAddImages);
            this.pnlHUD.Controls.Add(this.lstPreviewList);
            this.pnlHUD.Location = new System.Drawing.Point(0, -1);
            this.pnlHUD.Name = "pnlHUD";
            this.pnlHUD.Size = new System.Drawing.Size(637, 418);
            this.pnlHUD.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 19;
            // 
            // btnPanBrowse
            // 
            this.btnPanBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanBrowse.Location = new System.Drawing.Point(541, 353);
            this.btnPanBrowse.Name = "btnPanBrowse";
            this.btnPanBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPanBrowse.TabIndex = 18;
            this.btnPanBrowse.Text = "Browse";
            this.btnPanBrowse.UseVisualStyleBackColor = true;
            this.btnPanBrowse.Click += new System.EventHandler(this.btnPanBrowse_Click);
            // 
            // txtPanMask
            // 
            this.txtPanMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPanMask.Location = new System.Drawing.Point(108, 355);
            this.txtPanMask.Name = "txtPanMask";
            this.txtPanMask.Size = new System.Drawing.Size(427, 20);
            this.txtPanMask.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Panaromic Mask";
            // 
            // btnPBrowse
            // 
            this.btnPBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPBrowse.Location = new System.Drawing.Point(541, 328);
            this.btnPBrowse.Name = "btnPBrowse";
            this.btnPBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnPBrowse.TabIndex = 15;
            this.btnPBrowse.Text = "Browse";
            this.btnPBrowse.UseVisualStyleBackColor = true;
            this.btnPBrowse.Click += new System.EventHandler(this.btnPBrowse_Click);
            // 
            // txtPMask
            // 
            this.txtPMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPMask.Location = new System.Drawing.Point(108, 330);
            this.txtPMask.Name = "txtPMask";
            this.txtPMask.Size = new System.Drawing.Size(427, 20);
            this.txtPMask.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Potrait Mask";
            // 
            // btnLBrowse
            // 
            this.btnLBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLBrowse.Location = new System.Drawing.Point(541, 304);
            this.btnLBrowse.Name = "btnLBrowse";
            this.btnLBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnLBrowse.TabIndex = 12;
            this.btnLBrowse.Text = "Browse";
            this.btnLBrowse.UseVisualStyleBackColor = true;
            this.btnLBrowse.Click += new System.EventHandler(this.btnLBrowse_Click);
            // 
            // txtLMask
            // 
            this.txtLMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLMask.Location = new System.Drawing.Point(108, 304);
            this.txtLMask.Name = "txtLMask";
            this.txtLMask.Size = new System.Drawing.Size(427, 20);
            this.txtLMask.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Landscape Mask";
            // 
            // btnAddImages
            // 
            this.btnAddImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddImages.Location = new System.Drawing.Point(12, 275);
            this.btnAddImages.Name = "btnAddImages";
            this.btnAddImages.Size = new System.Drawing.Size(114, 23);
            this.btnAddImages.TabIndex = 9;
            this.btnAddImages.Text = "Add Images";
            this.btnAddImages.UseVisualStyleBackColor = true;
            this.btnAddImages.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // lstPreviewList
            // 
            this.lstPreviewList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPreviewList.LargeImageList = this.imgThumbnails;
            this.lstPreviewList.Location = new System.Drawing.Point(12, 10);
            this.lstPreviewList.Name = "lstPreviewList";
            this.lstPreviewList.Size = new System.Drawing.Size(604, 259);
            this.lstPreviewList.TabIndex = 8;
            this.lstPreviewList.UseCompatibleStateImageBehavior = false;
            // 
            // imgThumbnails
            // 
            this.imgThumbnails.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imgThumbnails.ImageSize = new System.Drawing.Size(160, 160);
            this.imgThumbnails.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timThumbnailLoader
            // 
            this.timThumbnailLoader.Enabled = true;
            this.timThumbnailLoader.Interval = 50;
            this.timThumbnailLoader.Tick += new System.EventHandler(this.thumbnailGenerator_Tick);
            // 
            // btnBreak
            // 
            this.btnBreak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBreak.Enabled = false;
            this.btnBreak.Location = new System.Drawing.Point(541, 424);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(75, 23);
            this.btnBreak.TabIndex = 16;
            this.btnBreak.Text = "Break";
            this.btnBreak.UseVisualStyleBackColor = true;
            this.btnBreak.Click += new System.EventHandler(this.btnBreaK_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 458);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(628, 22);
            this.statusStrip.TabIndex = 21;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(225, 17);
            this.toolStripStatusLabel1.Text = "CordPRO - OpenSource (Apache License)";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 480);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnBreak);
            this.Controls.Add(this.pnlHUD);
            this.Controls.Add(this.prgConversionProgress);
            this.Controls.Add(this.btnProcess);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Image Overlay - Alpha 1.0";
            this.pnlHUD.ResumeLayout(false);
            this.pnlHUD.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.OpenFileDialog ofdMask;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ProgressBar prgConversionProgress;
        private System.Windows.Forms.Panel pnlHUD;
        private System.Windows.Forms.Button btnPBrowse;
        private System.Windows.Forms.TextBox txtPMask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLBrowse;
        private System.Windows.Forms.TextBox txtLMask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddImages;
        private System.Windows.Forms.ListView lstPreviewList;
        private System.Windows.Forms.Timer timThumbnailLoader;
        private System.Windows.Forms.ImageList imgThumbnails;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnPanBrowse;
        private System.Windows.Forms.TextBox txtPanMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

