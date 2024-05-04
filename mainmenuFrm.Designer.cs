namespace ISDS309FinalProject
{
    partial class mainmenuFrm
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
            depositBtn = new Button();
            transferBtn = new Button();
            balanceBtn = new Button();
            withdrawalBtn = new Button();
            cancelBtn = new Button();
            pictureBox1 = new PictureBox();
            welcomeLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // depositBtn
            // 
            depositBtn.BackColor = SystemColors.ActiveCaption;
            depositBtn.Location = new Point(96, 229);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(157, 58);
            depositBtn.TabIndex = 0;
            depositBtn.Text = "Deposit";
            depositBtn.UseVisualStyleBackColor = false;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = SystemColors.ActiveCaption;
            transferBtn.Location = new Point(96, 293);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(157, 57);
            transferBtn.TabIndex = 1;
            transferBtn.Text = "Transfer";
            transferBtn.UseVisualStyleBackColor = false;
            // 
            // balanceBtn
            // 
            balanceBtn.BackColor = SystemColors.ActiveCaption;
            balanceBtn.Location = new Point(96, 167);
            balanceBtn.Name = "balanceBtn";
            balanceBtn.Size = new Size(157, 56);
            balanceBtn.TabIndex = 2;
            balanceBtn.Text = "Balance Inquiry";
            balanceBtn.UseVisualStyleBackColor = false;
            // 
            // withdrawalBtn
            // 
            withdrawalBtn.BackColor = SystemColors.ActiveCaption;
            withdrawalBtn.Location = new Point(96, 102);
            withdrawalBtn.Name = "withdrawalBtn";
            withdrawalBtn.Size = new Size(157, 59);
            withdrawalBtn.TabIndex = 3;
            withdrawalBtn.Text = "Withdraw";
            withdrawalBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Location = new Point(96, 356);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(157, 59);
            cancelBtn.TabIndex = 4;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(401, 102);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(309, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // welcomeLbl
            // 
            welcomeLbl.AutoSize = true;
            welcomeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLbl.Location = new Point(96, 32);
            welcomeLbl.Name = "welcomeLbl";
            welcomeLbl.Size = new Size(258, 28);
            welcomeLbl.TabIndex = 6;
            welcomeLbl.Text = "Welcome, (insert name here)";
            // 
            // mainmenuFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(welcomeLbl);
            Controls.Add(pictureBox1);
            Controls.Add(cancelBtn);
            Controls.Add(withdrawalBtn);
            Controls.Add(balanceBtn);
            Controls.Add(transferBtn);
            Controls.Add(depositBtn);
            ForeColor = Color.Black;
            Name = "mainmenuFrm";
            Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button depositBtn;
        private Button transferBtn;
        private Button balanceBtn;
        private Button withdrawalBtn;
        private Button cancelBtn;
        private PictureBox pictureBox1;
        private Label welcomeLbl;
    }
}