namespace ISDS309FinalProject
{
    partial class depositFrm
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
            AmountTxt = new TextBox();
            checkingsBtn = new RadioButton();
            savingsBtn = new RadioButton();
            cancelBtn = new Button();
            pictureBox1 = new PictureBox();
            OKBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AmountTxt
            // 
            AmountTxt.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AmountTxt.Location = new Point(87, 94);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(218, 27);
            AmountTxt.TabIndex = 0;
            AmountTxt.Text = "Enter $ Amount";
            AmountTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // checkingsBtn
            // 
            checkingsBtn.AutoSize = true;
            checkingsBtn.BackColor = SystemColors.ControlLightLight;
            checkingsBtn.Location = new Point(87, 184);
            checkingsBtn.Name = "checkingsBtn";
            checkingsBtn.Size = new Size(96, 24);
            checkingsBtn.TabIndex = 1;
            checkingsBtn.TabStop = true;
            checkingsBtn.Text = "Checkings";
            checkingsBtn.UseVisualStyleBackColor = false;
            // 
            // savingsBtn
            // 
            savingsBtn.AutoSize = true;
            savingsBtn.BackColor = SystemColors.ControlLightLight;
            savingsBtn.Location = new Point(87, 255);
            savingsBtn.Name = "savingsBtn";
            savingsBtn.Size = new Size(80, 24);
            savingsBtn.TabIndex = 2;
            savingsBtn.TabStop = true;
            savingsBtn.Text = "Savings";
            savingsBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Location = new Point(261, 345);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(143, 42);
            cancelBtn.TabIndex = 5;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(424, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = SystemColors.ActiveCaption;
            OKBtn.Location = new Point(87, 341);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(143, 46);
            OKBtn.TabIndex = 7;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            // 
            // depositFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(OKBtn);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Controls.Add(savingsBtn);
            Controls.Add(checkingsBtn);
            Controls.Add(AmountTxt);
            Name = "depositFrm";
            Text = "Deposit";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AmountTxt;
        private RadioButton checkingsBtn;
        private RadioButton savingsBtn;
        private Button cancelBtn;
        private PictureBox pictureBox1;
        private Button OKBtn;
    }
}