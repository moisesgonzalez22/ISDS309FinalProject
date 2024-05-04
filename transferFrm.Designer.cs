namespace ISDS309FinalProject
{
    partial class transferFrm
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
            pictureBox1 = new PictureBox();
            OKBtn = new Button();
            cancelBtn = new Button();
            fromLbl = new Label();
            accountBox = new ComboBox();
            accountBox2 = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AmountTxt
            // 
            AmountTxt.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            AmountTxt.Location = new Point(93, 62);
            AmountTxt.Margin = new Padding(3, 2, 3, 2);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(191, 23);
            AmountTxt.TabIndex = 1;
            AmountTxt.Text = "Enter $ Amount";
            AmountTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.project_logo;
            pictureBox1.Location = new Point(397, 62);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // OKBtn
            // 
            OKBtn.BackColor = SystemColors.ActiveCaption;
            OKBtn.Location = new Point(93, 243);
            OKBtn.Margin = new Padding(3, 2, 3, 2);
            OKBtn.Name = "OKBtn";
            OKBtn.Size = new Size(125, 34);
            OKBtn.TabIndex = 10;
            OKBtn.Text = "OK";
            OKBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Red;
            cancelBtn.Location = new Point(239, 245);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(125, 32);
            cancelBtn.TabIndex = 11;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            // 
            // fromLbl
            // 
            fromLbl.AutoSize = true;
            fromLbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromLbl.Location = new Point(93, 117);
            fromLbl.Name = "fromLbl";
            fromLbl.Size = new Size(40, 17);
            fromLbl.TabIndex = 12;
            fromLbl.Text = "From";
            // 
            // accountBox
            // 
            accountBox.DropDownStyle = ComboBoxStyle.DropDownList;
            accountBox.FormattingEnabled = true;
            accountBox.Items.AddRange(new object[] { "Checkings", "Savings" });
            accountBox.Location = new Point(165, 109);
            accountBox.Margin = new Padding(3, 2, 3, 2);
            accountBox.MaxDropDownItems = 2;
            accountBox.Name = "accountBox";
            accountBox.Size = new Size(133, 23);
            accountBox.TabIndex = 15;
            accountBox.SelectedIndexChanged += accountBox_SelectedIndexChanged;
            // 
            // accountBox2
            // 
            accountBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            accountBox2.FormattingEnabled = true;
            accountBox2.Items.AddRange(new object[] { "Checkings", "Savings" });
            accountBox2.Location = new Point(165, 147);
            accountBox2.Margin = new Padding(3, 2, 3, 2);
            accountBox2.MaxDropDownItems = 2;
            accountBox2.Name = "accountBox2";
            accountBox2.Size = new Size(133, 23);
            accountBox2.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(93, 153);
            label2.Name = "label2";
            label2.Size = new Size(23, 17);
            label2.TabIndex = 20;
            label2.Text = "To";
            // 
            // transferFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(accountBox2);
            Controls.Add(OKBtn);
            Controls.Add(accountBox);
            Controls.Add(fromLbl);
            Controls.Add(cancelBtn);
            Controls.Add(pictureBox1);
            Controls.Add(AmountTxt);
            Margin = new Padding(3, 2, 3, 2);
            Name = "transferFrm";
            Text = "Transfer";
            Load += transferFrm_Load;
            DataContextChanged += accountBox_SelectedIndexChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AmountTxt;
        private PictureBox pictureBox1;
        private Button OKBtn;
        private Button cancelBtn;
        private Label fromLbl;
        private ComboBox accountBox;
        private ComboBox accountBox2;
        private Label label2;
    }
}