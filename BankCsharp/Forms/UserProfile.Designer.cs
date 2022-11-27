namespace BankCsharp.Forms
{
    partial class UserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.SendMoneyBtn = new System.Windows.Forms.Button();
            this.CheckAccountBtn = new System.Windows.Forms.Button();
            this.AccountInfoBtn = new System.Windows.Forms.Button();
            this.User_Name_label = new System.Windows.Forms.Label();
            this.MainPageBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendMoneyBtn
            // 
            this.SendMoneyBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SendMoneyBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendMoneyBtn.Location = new System.Drawing.Point(137, 87);
            this.SendMoneyBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SendMoneyBtn.Name = "SendMoneyBtn";
            this.SendMoneyBtn.Size = new System.Drawing.Size(76, 66);
            this.SendMoneyBtn.TabIndex = 0;
            this.SendMoneyBtn.Text = "Send Money";
            this.SendMoneyBtn.UseVisualStyleBackColor = false;
            this.SendMoneyBtn.Click += new System.EventHandler(this.SendMoneyBtn_Click);
            // 
            // CheckAccountBtn
            // 
            this.CheckAccountBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CheckAccountBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckAccountBtn.Location = new System.Drawing.Point(217, 87);
            this.CheckAccountBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CheckAccountBtn.Name = "CheckAccountBtn";
            this.CheckAccountBtn.Size = new System.Drawing.Size(88, 66);
            this.CheckAccountBtn.TabIndex = 1;
            this.CheckAccountBtn.Text = "Check Account";
            this.CheckAccountBtn.UseVisualStyleBackColor = false;
            this.CheckAccountBtn.Click += new System.EventHandler(this.CheckAccountBtn_Click);
            // 
            // AccountInfoBtn
            // 
            this.AccountInfoBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AccountInfoBtn.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountInfoBtn.Location = new System.Drawing.Point(309, 87);
            this.AccountInfoBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AccountInfoBtn.Name = "AccountInfoBtn";
            this.AccountInfoBtn.Size = new System.Drawing.Size(81, 66);
            this.AccountInfoBtn.TabIndex = 2;
            this.AccountInfoBtn.Text = "Account Info";
            this.AccountInfoBtn.UseVisualStyleBackColor = false;
            this.AccountInfoBtn.Click += new System.EventHandler(this.AccountInfoBtn_Click);
            // 
            // User_Name_label
            // 
            this.User_Name_label.AutoSize = true;
            this.User_Name_label.BackColor = System.Drawing.Color.IndianRed;
            this.User_Name_label.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Name_label.Location = new System.Drawing.Point(12, 9);
            this.User_Name_label.Name = "User_Name_label";
            this.User_Name_label.Size = new System.Drawing.Size(105, 23);
            this.User_Name_label.TabIndex = 3;
            this.User_Name_label.Text = "Your Name";
            // 
            // MainPageBtn
            // 
            this.MainPageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageBtn.Location = new System.Drawing.Point(17, 250);
            this.MainPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MainPageBtn.Name = "MainPageBtn";
            this.MainPageBtn.Size = new System.Drawing.Size(69, 26);
            this.MainPageBtn.TabIndex = 4;
            this.MainPageBtn.Text = "Back";
            this.MainPageBtn.UseVisualStyleBackColor = false;
            this.MainPageBtn.Click += new System.EventHandler(this.MainPageBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(90, 250);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(69, 26);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MainPageBtn);
            this.Controls.Add(this.User_Name_label);
            this.Controls.Add(this.AccountInfoBtn);
            this.Controls.Add(this.CheckAccountBtn);
            this.Controls.Add(this.SendMoneyBtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserProfile";
            this.Text = "UserProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMoneyBtn;
        private System.Windows.Forms.Button CheckAccountBtn;
        private System.Windows.Forms.Button AccountInfoBtn;
        private System.Windows.Forms.Label User_Name_label;
        private System.Windows.Forms.Button MainPageBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}