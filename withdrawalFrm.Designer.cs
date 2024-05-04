namespace ISDS309FinalProject
{
    partial class withdrawalFrm
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
            OKBtn = new Button();
            cancelBtn = new Button();
            pictureBox1 = new PictureBox();
            fortyBtn = new Button();
            eightyBtn = new Button();
            hundredBtn = new Button();
            twohundredBtn = new Button();
            otherBtn = new Button();
            amountLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // OKBtn
            // 
            OKBtn.BackColor = Color.DarkGreen;
            OKBtn.Location = new Point(56, 278);
            OKBtn.Margin = new Padding(3, 2, 3, 2);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(125, 34);
            OKBtn.TabIndex = 9;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            OKBtn.UseWaitCursor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.ForeColor = Color.Black;
            cancelBtn.Location = new Point(218, 278);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(126, 34);
            cancelBtn.TabIndex = 10;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(374, 70);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // fortyBtn
            // 
            fortyBtn.BackColor = Color.DarkGreen;
            fortyBtn.ForeColor = Color.White;
            fortyBtn.Location = new Point(56, 70);
            fortyBtn.Margin = new Padding(3, 2, 3, 2);
            fortyBtn.Name = "fortyBtn";
            fortyBtn.Size = new Size(131, 45);
            fortyBtn.TabIndex = 12;
            fortyBtn.Text = "$40";
            fortyBtn.UseVisualStyleBackColor = false;
            fortyBtn.UseWaitCursor = true;
            // 
            // eightyBtn
            // 
            eightyBtn.BackColor = Color.DarkGreen;
            eightyBtn.ForeColor = Color.White;
            eightyBtn.Location = new Point(218, 70);
            eightyBtn.Margin = new Padding(3, 2, 3, 2);
            eightyBtn.Name = "eightyBtn";
            eightyBtn.Size = new Size(131, 45);
            eightyBtn.TabIndex = 13;
            eightyBtn.Text = "$80";
            eightyBtn.UseVisualStyleBackColor = false;
            eightyBtn.UseWaitCursor = true;
            // 
            // hundredBtn
            // 
            hundredBtn.BackColor = Color.DarkGreen;
            hundredBtn.ForeColor = Color.White;
            hundredBtn.Location = new Point(56, 126);
            hundredBtn.Margin = new Padding(3, 2, 3, 2);
            hundredBtn.Name = "hundredBtn";
            hundredBtn.Size = new Size(131, 45);
            hundredBtn.TabIndex = 14;
            hundredBtn.Text = "$100";
            hundredBtn.UseVisualStyleBackColor = false;
            hundredBtn.UseWaitCursor = true;
            // 
            // twohundredBtn
            // 
            twohundredBtn.BackColor = Color.DarkGreen;
            twohundredBtn.ForeColor = Color.White;
            twohundredBtn.Location = new Point(218, 126);
            twohundredBtn.Margin = new Padding(3, 2, 3, 2);
            twohundredBtn.Name = "twohundredBtn";
            twohundredBtn.Size = new Size(131, 45);
            twohundredBtn.TabIndex = 15;
            twohundredBtn.Text = "$200";
            twohundredBtn.UseVisualStyleBackColor = false;
            twohundredBtn.UseWaitCursor = true;
            // 
            // otherBtn
            // 
            otherBtn.BackColor = Color.DarkGreen;
            otherBtn.ForeColor = Color.White;
            otherBtn.Location = new Point(56, 197);
            otherBtn.Margin = new Padding(3, 2, 3, 2);
            otherBtn.Name = "otherBtn";
            otherBtn.Size = new Size(131, 45);
            otherBtn.TabIndex = 16;
            otherBtn.Text = "Other";
            otherBtn.UseVisualStyleBackColor = false;
            otherBtn.UseWaitCursor = true;
            // 
            // amountLbl
            // 
            amountLbl.AutoSize = true;
            amountLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLbl.Location = new Point(56, 31);
            amountLbl.Name = "amountLbl";
            amountLbl.Size = new Size(141, 21);
            amountLbl.TabIndex = 17;
            amountLbl.Text = "Choose an amount";
            amountLbl.UseWaitCursor = true;
            amountLbl.Click += label1_Click;
            // 
            // withdrawalFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(amountLbl);
            Controls.Add(otherBtn);
            Controls.Add(twohundredBtn);
            Controls.Add(hundredBtn);
            Controls.Add(eightyBtn);
            Controls.Add(fortyBtn);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Controls.Add(OKBtn);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "withdrawalFrm";
            Text = "Withdrawal";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OKBtn;
        private Button cancelBtn;
        private PictureBox pictureBox1;
        private Button fortyBtn;
        private Button eightyBtn;
        private Button hundredBtn;
        private Button twohundredBtn;
        private Button otherBtn;
        private Label amountLbl;
    }
}