namespace Assign_Week_9
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxBalance = new System.Windows.Forms.ListBox();
            this.lboxNames = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuyRound = new System.Windows.Forms.Button();
            this.txtRndPrice = new System.Windows.Forms.TextBox();
            this.lbRoundNames = new System.Windows.Forms.ListBox();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lboxBalance);
            this.groupBox1.Controls.Add(this.lboxNames);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 412);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team Members";
            // 
            // lboxBalance
            // 
            this.lboxBalance.FormattingEnabled = true;
            this.lboxBalance.ItemHeight = 16;
            this.lboxBalance.Items.AddRange(new object[] {
            "0",
            "0",
            "0",
            "0",
            "0"});
            this.lboxBalance.Location = new System.Drawing.Point(247, 105);
            this.lboxBalance.Name = "lboxBalance";
            this.lboxBalance.Size = new System.Drawing.Size(47, 180);
            this.lboxBalance.TabIndex = 16;
            // 
            // lboxNames
            // 
            this.lboxNames.FormattingEnabled = true;
            this.lboxNames.ItemHeight = 16;
            this.lboxNames.Items.AddRange(new object[] {
            "Gay",
            "George",
            "Daniel",
            "Vladimir",
            "Jed"});
            this.lboxNames.Location = new System.Drawing.Point(124, 105);
            this.lboxNames.Name = "lboxNames";
            this.lboxNames.Size = new System.Drawing.Size(123, 180);
            this.lboxNames.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Assign_Week_9.Properties.Resources.Logo_Romania_FRF3;
            this.pictureBox2.InitialImage = global::Assign_Week_9.Properties.Resources.Logo_Romania_FRF3;
            this.pictureBox2.Location = new System.Drawing.Point(6, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Team Member";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Default Team";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 358);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 22);
            this.textBox1.TabIndex = 12;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(133, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 61);
            this.button4.TabIndex = 4;
            this.button4.Text = "Add Team Member";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 61);
            this.button5.TabIndex = 5;
            this.button5.Text = "Remove Team Member";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 291);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(121, 61);
            this.button6.TabIndex = 6;
            this.button6.Text = "Remove Selected Team Member";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBuyRound);
            this.groupBox2.Controls.Add(this.txtRndPrice);
            this.groupBox2.Controls.Add(this.lbRoundNames);
            this.groupBox2.Controls.Add(this.btnRemoveName);
            this.groupBox2.Controls.Add(this.btnAddName);
            this.groupBox2.Location = new System.Drawing.Point(335, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 412);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Assign_Week_9.Properties.Resources.alcohol;
            this.pictureBox1.InitialImage = global::Assign_Week_9.Properties.Resources.alcohol;
            this.pictureBox1.Location = new System.Drawing.Point(127, 319);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Round Price";
            // 
            // btnBuyRound
            // 
            this.btnBuyRound.Location = new System.Drawing.Point(16, 319);
            this.btnBuyRound.Name = "btnBuyRound";
            this.btnBuyRound.Size = new System.Drawing.Size(105, 79);
            this.btnBuyRound.TabIndex = 1;
            this.btnBuyRound.Text = "Buy a Round";
            this.btnBuyRound.UseVisualStyleBackColor = true;
            this.btnBuyRound.Click += new System.EventHandler(this.BtnBuyRound_Click);
            // 
            // txtRndPrice
            // 
            this.txtRndPrice.Location = new System.Drawing.Point(127, 254);
            this.txtRndPrice.Name = "txtRndPrice";
            this.txtRndPrice.Size = new System.Drawing.Size(167, 22);
            this.txtRndPrice.TabIndex = 13;
            // 
            // lbRoundNames
            // 
            this.lbRoundNames.FormattingEnabled = true;
            this.lbRoundNames.ItemHeight = 16;
            this.lbRoundNames.Location = new System.Drawing.Point(127, 32);
            this.lbRoundNames.Name = "lbRoundNames";
            this.lbRoundNames.Size = new System.Drawing.Size(167, 212);
            this.lbRoundNames.TabIndex = 11;
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(16, 129);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(105, 70);
            this.btnRemoveName.TabIndex = 2;
            this.btnRemoveName.Text = "<<";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.BtnRemoveName_Click);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(16, 32);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(105, 70);
            this.btnAddName.TabIndex = 7;
            this.btnAddName.Text = ">>";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.BtnAddName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxNames;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbRoundNames;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnBuyRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRndPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lboxBalance;
    }
}

