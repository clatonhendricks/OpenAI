using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Net.Http;
using DallePPT.Models;
using System.Net;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using System.IO;
using Microsoft.Office.Core;
using Newtonsoft.Json.Linq;
using System.Runtime.Remoting.Messaging;

namespace DallePPT
{
    public partial class frmDalle : Form
    {
        //public string ImageLocation { get; private set; }
        public List<string> dalleUrl = new List<string>(4);

        public frmDalle()
        {
            InitializeComponent();
        }

        
        private static async Task<DalleModel> SubmitOpenAIRequest(input inputData, string APIKEY)
        {
            var resp = new DalleModel();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Authorization =
                     new AuthenticationHeaderValue("Bearer", APIKEY);
                ServicePointManager.SecurityProtocol= SecurityProtocolType.Tls12;
                var Message = await client.
                      PostAsync("https://api.openai.com/v1/images/generations",
                      new StringContent(JsonConvert.SerializeObject(inputData),
                      Encoding.UTF8, "application/json")); 
                if (Message.IsSuccessStatusCode)
                {
                    var content = await Message.Content.ReadAsStringAsync();
                    resp = JsonConvert.DeserializeObject<DalleModel>(content);
                } else { resp.StatusCode = Message.StatusCode.ToString(); }
            }
            
            return resp;
        }

        private async void btnOpenAISubmit_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtAPI.Text) || string.IsNullOrEmpty(txtPrompt.Text))
            {
                MessageBox.Show("API Key & Prompt is missing for DALL.E to create your imagination.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                lblStatus.Visible = true;
                lblInserttext.Visible = false;
                // hide all the picturebox 
                picDallepic0.Visible = false;
                picDallepic1.Visible = false;
                picDallepic2.Visible = false;
                picDallepic3.Visible = false;
                var input = new input
                {
                    prompt = txtPrompt.Text.ToString(),
                    n = Convert.ToInt16(cboNumImg.Text),
                    size = "256x256",

                };

                try
                {
                    DalleModel response = await SubmitOpenAIRequest(input, txtAPI.Text.ToString());
                    if (response.StatusCode != null)
                    {
                        //MessageBox.Show(response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        throw new InvalidOperationException(response.StatusCode.ToString());
                    }
                    lblStatus.Visible = false;
                    lblInserttext.Visible = true;
                    picDallepic0.Visible = true;
                    picDallepic1.Visible = true;
                    picDallepic2.Visible = true;
                    picDallepic3.Visible = true;
                    UpdatePicbox(response);
                }
                catch (InvalidOperationException ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void UpdatePicbox(DalleModel resp)
        {
            dalleUrl.Clear();
            try
            {
                for (int index = 0; index < resp.data.Count; index++)
                {
                    string ctrlName = "picDallepic" + index;
                    PictureBox obj = (PictureBox)this.Controls.Find(ctrlName, true).FirstOrDefault();
                    obj.ImageLocation = resp.data[index].url;
                    dalleUrl.Add(resp.data[index].url);

                }
            }
            catch (Exception)
            {
                MessageBox.Show(resp.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                throw;
            }

        }

        private void picDallepic1_Click(object sender, EventArgs e)
        {
            InsertImage(0);

        }

        private void InsertImage(int n)
        {
            var imgPath = downloadImg(dalleUrl[n]);
            try
            {
                int SlideIndex = Globals.ThisAddIn.Application.ActiveWindow.View.Slide.SlideIndex;
                PowerPoint.Presentation pp = Globals.ThisAddIn.Application.ActivePresentation;
                PowerPoint.Slide s = pp.Slides[SlideIndex];

                s.Shapes.AddPicture(imgPath, Microsoft.Office.Core.MsoTriState.msoFalse,
                    Microsoft.Office.Core.MsoTriState.msoTrue,
                100, 100, 256, 256);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private string downloadImg(string filename)
        {
            var imgPath = System.IO.Path.GetTempPath() + "Dalle.png";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(filename, imgPath);
            }

            return imgPath;
        }

        private void picDallepic1_Click_1(object sender, EventArgs e)
        {
            InsertImage(1);
        }

        private void picDallepic2_Click(object sender, EventArgs e)
        {
            InsertImage(2);
        }

        private void picDallepic3_Click(object sender, EventArgs e)
        {
            InsertImage(3);
        }

        private void cboNumImg_SelectedValueChanged(object sender, EventArgs e)
        {
            const double per256x256 = 0.016;
            double perImgCost = 0.0;
            perImgCost = Convert.ToDouble(cboNumImg.Text) * per256x256;
            lblCost.Text = "Cost per img: $" + perImgCost.ToString();


        }

        private void txtAPI_TextChanged(object sender, EventArgs e)
        {
            DalleSettings.Default.APIKey = txtAPI.Text;
            DalleSettings.Default.Save(); 
            

        }

        private void frmDalle_Load(object sender, EventArgs e)
        {
            txtAPI.Text = DalleSettings.Default.APIKey;
            cboNumImg.SelectedIndex = 0;

            toolTip.SetToolTip(this.txtPrompt, "Double click to clear text");
            toolTip.SetToolTip(this.lblLink, "Click to get API Key");
            toolTip.SetToolTip(this.lblCost, "Cost per image");
            toolTip.SetToolTip(this.txtAPI, "Enter your API key from OpenAI");
                        
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            lblLink.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://openai.com/api/login");
        }


        private void txtPrompt_DoubleClick(object sender, EventArgs e)
        {
            txtPrompt.Text = "";
        }
    }
}
