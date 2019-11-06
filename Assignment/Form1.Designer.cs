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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxBalance = new System.Windows.Forms.ListBox();
            this.lboxNames = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.tboxMember = new System.Windows.Forms.TextBox();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRoundNames = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuyRound = new System.Windows.Forms.Button();
            this.txtRndPrice = new System.Windows.Forms.TextBox();
            this.btnRemoveName = new System.Windows.Forms.Button();
            this.btnAddName = new System.Windows.Forms.Button();
            this.gameStart = new System.Windows.Forms.Timer(this.components);
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
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Controls.Add(this.tboxMember);
            this.groupBox1.Controls.Add(this.btnAddMember);
            this.groupBox1.Controls.Add(this.btnRemoveMember);
            this.groupBox1.Controls.Add(this.btnRemoveSelected);
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
            this.lboxBalance.Location = new System.Drawing.Point(247, 105);
            this.lboxBalance.Name = "lboxBalance";
            this.lboxBalance.Size = new System.Drawing.Size(47, 180);
            this.lboxBalance.TabIndex = 16;
            // 
            // lboxNames
            // 
            this.lboxNames.FormattingEnabled = true;
            this.lboxNames.ItemHeight = 16;
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
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(6, 43);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(121, 48);
            this.btnAddTeam.TabIndex = 3;
            this.btnAddTeam.Text = "Add Default Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // tboxMember
            // 
            this.tboxMember.Location = new System.Drawing.Point(133, 358);
            this.tboxMember.Name = "tboxMember";
            this.tboxMember.Size = new System.Drawing.Size(161, 22);
            this.tboxMember.TabIndex = 12;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(124, 291);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(76, 61);
            this.btnAddMember.TabIndex = 4;
            this.btnAddMember.Text = "Add Team Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Location = new System.Drawing.Point(206, 291);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(88, 61);
            this.btnRemoveMember.TabIndex = 5;
            this.btnRemoveMember.Text = "Remove Team Member";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveName_Click);
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(6, 291);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(112, 61);
            this.btnRemoveSelected.TabIndex = 6;
            this.btnRemoveSelected.Text = "Remove Selected Team Member";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRoundNames);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnBuyRound);
            this.groupBox2.Controls.Add(this.txtRndPrice);
            this.groupBox2.Controls.Add(this.btnRemoveName);
            this.groupBox2.Controls.Add(this.btnAddName);
            this.groupBox2.Location = new System.Drawing.Point(335, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 412);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Round Information";
            // 
            // lbRoundNames
            // 
            this.lbRoundNames.FormattingEnabled = true;
            this.lbRoundNames.ItemHeight = 16;
            this.lbRoundNames.Location = new System.Drawing.Point(127, 33);
            this.lbRoundNames.Name = "lbRoundNames";
            this.lbRoundNames.Size = new System.Drawing.Size(167, 212);
            this.lbRoundNames.TabIndex = 19;
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
            this.btnBuyRound.Click += new System.EventHandler(this.btnBuyRound_Click);
            // 
            // txtRndPrice
            // 
            this.txtRndPrice.Location = new System.Drawing.Point(127, 254);
            this.txtRndPrice.Name = "txtRndPrice";
            this.txtRndPrice.Size = new System.Drawing.Size(167, 22);
            this.txtRndPrice.TabIndex = 13;
            // 
            // btnRemoveName
            // 
            this.btnRemoveName.Location = new System.Drawing.Point(16, 129);
            this.btnRemoveName.Name = "btnRemoveName";
            this.btnRemoveName.Size = new System.Drawing.Size(105, 70);
            this.btnRemoveName.TabIndex = 2;
            this.btnRemoveName.Text = "<<";
            this.btnRemoveName.UseVisualStyleBackColor = true;
            this.btnRemoveName.Click += new System.EventHandler(this.btnRemoveName_Click_1);
            // 
            // btnAddName
            // 
            this.btnAddName.Location = new System.Drawing.Point(16, 32);
            this.btnAddName.Name = "btnAddName";
            this.btnAddName.Size = new System.Drawing.Size(105, 70);
            this.btnAddName.TabIndex = 7;
            this.btnAddName.Text = ">>";
            this.btnAddName.UseVisualStyleBackColor = true;
            this.btnAddName.Click += new System.EventHandler(this.btnAddName_Click);
            // 
            // gameStart
            // 
            this.gameStart.Enabled = true;
            this.gameStart.Tick += new System.EventHandler(this.GameStart_Tick);
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
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button btnRemoveName;
        private System.Windows.Forms.Button btnAddName;
        private System.Windows.Forms.Button btnBuyRound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxMember;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRndPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lboxBalance;
        private System.Windows.Forms.ListBox lbRoundNames;
        private System.Windows.Forms.Timer gameStart;
    }
}

