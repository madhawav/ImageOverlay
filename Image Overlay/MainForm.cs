using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Image_Overlay
{
    public partial class MainForm : Form
    {
        bool stopProcessing = false; //break the process?
        List<ListViewItem> toGenerateThumbnail = new List<ListViewItem>(); //list of items to load the thumbnails

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (ofdImage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //loop through the selections
                for(int x=0;x<ofdImage.FileNames.Length;x++)
                {
                    //create listview items
                    ListViewItem li = new ListViewItem(System.IO.Path.GetFileName(ofdImage.FileNames[x]));
                    li.Tag = ofdImage.FileNames[x]; //tag referes to original image file
                
                    li.SubItems.Add(ofdImage.FileNames[x]);
                    lstPreviewList.Items.Add(li);
                    //Queue thumbnail generation
                    toGenerateThumbnail.Add(li);
                    
                }
                
            }
        }

        private void btnLBrowse_Click(object sender, EventArgs e)
        {
            //change landscape mask
            if (ofdMask.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLMask.Text = ofdMask.FileName;
            }
        }

        private void btnPBrowse_Click(object sender, EventArgs e)
        {
            //change potraight mask
            if (ofdMask.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtPMask.Text = ofdMask.FileName;
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            //load the masks
            Image landscapeMask = null;
            Image potraighMask = null;
            Image panMask = null;

            if (System.IO.File.Exists(txtLMask.Text))
            {
                landscapeMask = Image.FromFile(txtLMask.Text);
            }
           
            if (System.IO.File.Exists(txtPMask.Text)) {
                potraighMask = Image.FromFile(txtPMask.Text);
            
            }


            if (System.IO.File.Exists(txtPanMask.Text))
            {
                panMask = Image.FromFile(txtPanMask.Text);

            }

            //disable thumbnail generation
            timThumbnailLoader.Enabled = false;
            //reset state variable
            stopProcessing = false;
            //reset progressbar and update ui
            prgConversionProgress.Value = 0;
            pnlHUD.Enabled = false;
            btnProcess.Enabled = false;
            btnBreak.Enabled = true;
                  
            
            //loop through images
            for (int x = 0; x < lstPreviewList.Items.Count; x++)
            {
                if (stopProcessing) break;
                //retrieve image file path
                ListViewItem li = lstPreviewList.Items[x];
                string path = (string)li.Tag;
                
                //create output folder
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path) + @"\Overlay Output");
                
                //load the image
                System.Drawing.Image im = Image.FromFile(path);
                //setup graphics to do overlay
                Graphics obj = Graphics.FromImage(im);
                obj.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                obj.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                obj.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                
                if (Math.Abs( (float)im.Width/(float)im.Height-4.0f/3.0f) < 0.05f)
                {
                    //landscape
                    if (landscapeMask != null)
                        obj.DrawImage(landscapeMask, 0, 0, im.Width, im.Height);
                }
                else if (Math.Abs((float)im.Height / (float)im.Width - 4.0f / 3.0f) < 0.05f)
                {
                    //potraight
                    if (potraighMask != null)
                        obj.DrawImage(potraighMask, 0, 0, im.Width, im.Height);
                }
                else if (im.Width > im.Height)
                {
                    //chose panaroma if its neither potraight, nor landscape
                    if (panMask != null)
                        obj.DrawImage(panMask, 0, 0, im.Width, im.Height);
                }

                //clean up
                obj.Dispose();

                //save output file
                im.Save(System.IO.Path.GetDirectoryName(path) + @"\Overlay Output\" + System.IO.Path.GetFileName(path), System.Drawing.Imaging.ImageFormat.Jpeg);

                //more cleanup
                im.Dispose();
                //update ui
                prgConversionProgress.Value =(int)((float) (x+1) /(float) lstPreviewList.Items.Count * 100.0f);
                Application.DoEvents();
            }
            //conversion completed
            //reset ui
            pnlHUD.Enabled = true;
            btnProcess.Enabled = true;
            //if breaked, keep the loaded images
            
            if (!stopProcessing)
            {
                //else    
                lstPreviewList.Items.Clear();
                toGenerateThumbnail.Clear();
                imgThumbnails.Images.Clear();
            }

            //re-start thumbnail generator
            timThumbnailLoader.Enabled = true;
            btnBreak.Enabled = false;
        }

        
        private void thumbnailGenerator_Tick(object sender, EventArgs e)
        {
            if (toGenerateThumbnail.Count == 0) return;
            //one image per tick
            ListViewItem li = toGenerateThumbnail[0];
            toGenerateThumbnail.RemoveAt(0);

            //pop the next image to load thumbnail
            string path = (string)li.Tag;
            Image im = Image.FromFile(path);
            //retrieve its tumbnail
            Image thumb = im.GetThumbnailImage(120, 120, null, System.IntPtr.Zero);
            im.Dispose();
            //setup the thumbnail in imagelist
            imgThumbnails.Images.Add(thumb);
            li.ImageIndex = imgThumbnails.Images.Count - 1;
          
        }
        

        private void btnBreaK_Click(object sender, EventArgs e)
        {
            stopProcessing = true;
        }

        private void btnPanBrowse_Click(object sender, EventArgs e)
        {
            //Browese panaroma mask
            if (ofdMask.ShowDialog() == System.Windows.Forms.DialogResult.OK) txtPanMask.Text = ofdMask.FileName;
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }

}
