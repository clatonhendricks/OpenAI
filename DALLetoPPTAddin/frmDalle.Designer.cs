namespace DallePPT
{
    partial class frmDalle
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
            this.picDallepic0 = new System.Windows.Forms.PictureBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnOpenAISubmit = new System.Windows.Forms.Button();
            this.txtAPI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboNumImg = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picDallepic1 = new System.Windows.Forms.PictureBox();
            this.picDallepic2 = new System.Windows.Forms.PictureBox();
            this.picDallepic3 = new System.Windows.Forms.PictureBox();
            this.lblInserttext = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic3)).BeginInit();
            this.SuspendLayout();
            // 
            // picDallepic0
            // 
            this.picDallepic0.BackColor = System.Drawing.SystemColors.Control;
            this.picDallepic0.Location = new System.Drawing.Point(28, 183);
            this.picDallepic0.Name = "picDallepic0";
            this.picDallepic0.Size = new System.Drawing.Size(181, 153);
            this.picDallepic0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDallepic0.TabIndex = 0;
            this.picDallepic0.TabStop = false;
            this.picDallepic0.Click += new System.EventHandler(this.picDallepic1_Click);
            // 
            // txtPrompt
            // 
            this.txtPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrompt.Location = new System.Drawing.Point(67, 87);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(662, 52);
            this.txtPrompt.TabIndex = 1;
            this.txtPrompt.Text = "A mountain landscape with northern lights in the sky and few birds flying";
            this.txtPrompt.DoubleClick += new System.EventHandler(this.txtPrompt_DoubleClick);
            // 
            // btnOpenAISubmit
            // 
            this.btnOpenAISubmit.Location = new System.Drawing.Point(738, 99);
            this.btnOpenAISubmit.Name = "btnOpenAISubmit";
            this.btnOpenAISubmit.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAISubmit.TabIndex = 2;
            this.btnOpenAISubmit.Text = "Submit";
            this.btnOpenAISubmit.UseVisualStyleBackColor = true;
            this.btnOpenAISubmit.Click += new System.EventHandler(this.btnOpenAISubmit_Click);
            // 
            // txtAPI
            // 
            this.txtAPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPI.Location = new System.Drawing.Point(67, 48);
            this.txtAPI.Name = "txtAPI";
            this.txtAPI.PasswordChar = '*';
            this.txtAPI.Size = new System.Drawing.Size(466, 21);
            this.txtAPI.TabIndex = 3;
            this.txtAPI.TextChanged += new System.EventHandler(this.txtAPI_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "API Key:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prompt:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(228, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(414, 16);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Please wait, DALL.E is drawing your prompt to the canvas...";
            this.lblStatus.Visible = false;
            // 
            // cboNumImg
            // 
            this.cboNumImg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNumImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNumImg.FormattingEnabled = true;
            this.cboNumImg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboNumImg.Location = new System.Drawing.Point(639, 49);
            this.cboNumImg.Name = "cboNumImg";
            this.cboNumImg.Size = new System.Drawing.Size(38, 23);
            this.cboNumImg.TabIndex = 8;
            this.cboNumImg.SelectedValueChanged += new System.EventHandler(this.cboNumImg_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(536, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Num of Images:";
            // 
            // picDallepic1
            // 
            this.picDallepic1.Location = new System.Drawing.Point(231, 183);
            this.picDallepic1.Name = "picDallepic1";
            this.picDallepic1.Size = new System.Drawing.Size(181, 153);
            this.picDallepic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDallepic1.TabIndex = 10;
            this.picDallepic1.TabStop = false;
            this.picDallepic1.Click += new System.EventHandler(this.picDallepic1_Click_1);
            // 
            // picDallepic2
            // 
            this.picDallepic2.Location = new System.Drawing.Point(434, 183);
            this.picDallepic2.Name = "picDallepic2";
            this.picDallepic2.Size = new System.Drawing.Size(181, 153);
            this.picDallepic2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDallepic2.TabIndex = 11;
            this.picDallepic2.TabStop = false;
            this.picDallepic2.Click += new System.EventHandler(this.picDallepic2_Click);
            // 
            // picDallepic3
            // 
            this.picDallepic3.Location = new System.Drawing.Point(641, 183);
            this.picDallepic3.Name = "picDallepic3";
            this.picDallepic3.Size = new System.Drawing.Size(181, 153);
            this.picDallepic3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDallepic3.TabIndex = 12;
            this.picDallepic3.TabStop = false;
            this.picDallepic3.Click += new System.EventHandler(this.picDallepic3_Click);
            // 
            // lblInserttext
            // 
            this.lblInserttext.AutoSize = true;
            this.lblInserttext.BackColor = System.Drawing.SystemColors.Control;
            this.lblInserttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInserttext.Location = new System.Drawing.Point(260, 359);
            this.lblInserttext.Name = "lblInserttext";
            this.lblInserttext.Size = new System.Drawing.Size(287, 16);
            this.lblInserttext.TabIndex = 13;
            this.lblInserttext.Text = "Double click on the image to insert into the slide";
            this.lblInserttext.Visible = false;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCost.Location = new System.Drawing.Point(682, 51);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(140, 15);
            this.lblCost.TabIndex = 14;
            this.lblCost.Text = "Cost per img: $0.016";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLink.Location = new System.Drawing.Point(122, 2);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(570, 30);
            this.lblLink.TabIndex = 15;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "\r\nYou need to provide a API license key. Click here to create free OpenAI account" +
    " to generate a license key";
            this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
            // 
            // frmDalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(849, 388);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblInserttext);
            this.Controls.Add(this.picDallepic3);
            this.Controls.Add(this.picDallepic2);
            this.Controls.Add(this.picDallepic1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNumImg);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAPI);
            this.Controls.Add(this.btnOpenAISubmit);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.picDallepic0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDalle";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DALL.E to Powerpoint";
            this.Load += new System.EventHandler(this.frmDalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDallepic3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDallepic0;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnOpenAISubmit;
        private System.Windows.Forms.TextBox txtAPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboNumImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picDallepic1;
        private System.Windows.Forms.PictureBox picDallepic2;
        private System.Windows.Forms.PictureBox picDallepic3;
        private System.Windows.Forms.Label lblInserttext;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.ToolTip toolTip;
    }
}