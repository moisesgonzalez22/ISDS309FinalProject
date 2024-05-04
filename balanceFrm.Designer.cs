namespace ISDS309FinalProject
{
    partial class balanceFrm
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
            checkingsBtn = new RadioButton();
            savingsBtn = new RadioButton();
            OKBtn = new Button();
            cancelBtn = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkingsBtn
            // 
            checkingsBtn.AutoSize = true;
            checkingsBtn.BackColor = SystemColors.ControlLightLight;
            checkingsBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkingsBtn.Location = new Point(78, 130);
            checkingsBtn.Name = "checkingsBtn";
            checkingsBtn.Size = new Size(108, 27);
            checkingsBtn.TabIndex = 2;
            checkingsBtn.TabStop = true;
            checkingsBtn.Text = "Checkings";
            checkingsBtn.UseVisualStyleBackColor = false;
            // 
            // savingsBtn
            // 
            savingsBtn.AutoSize = true;
            savingsBtn.BackColor = SystemColors.ControlLightLight;
            savingsBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            savingsBtn.Location = new Point(78, 215);
            savingsBtn.Name = "savingsBtn";
            savingsBtn.Size = new Size(88, 27);
            savingsBtn.TabIndex = 3;
            savingsBtn.TabStop = true;
            savingsBtn.Text = "Savings";
            savingsBtn.UseVisualStyleBackColor = false;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = SystemColors.ActiveCaption;
            OKBtn.Location = new Point(78, 316);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(143, 46);
            OKBtn.TabIndex = 8;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Location = new Point(262, 320);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(143, 42);
            cancelBtn.TabIndex = 9;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(479, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 58);
            label1.Name = "label1";
            label1.Size = new Size(207, 31);
            label1.TabIndex = 11;
            label1.Text = "Choose an account";
            // 
            // balanceFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Controls.Add(OKBtn);
            Controls.Add(savingsBtn);
            Controls.Add(checkingsBtn);
            Name = "balanceFrm";
            Text = "Balance";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton checkingsBtn;
        private RadioButton savingsBtn;
        private Button OKBtn;
        private Button cancelBtn;
        private PictureBox pictureBox1;
        private Label label1;
    }
}