﻿namespace BankCsharp.Forms
{
    partial class CheckAccountFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckAccountFm));
            this.label1 = new System.Windows.Forms.Label();
            this.UserMoneyLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(341, 168);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "$ Dollor";
            // 
            // UserMoneyLabel
            // 
            this.UserMoneyLabel.AutoSize = true;
            this.UserMoneyLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserMoneyLabel.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserMoneyLabel.Location = new System.Drawing.Point(288, 121);
            this.UserMoneyLabel.Name = "UserMoneyLabel";
            this.UserMoneyLabel.Padding = new System.Windows.Forms.Padding(5);
            this.UserMoneyLabel.Size = new System.Drawing.Size(181, 47);
            this.UserMoneyLabel.TabIndex = 1;
            this.UserMoneyLabel.Text = "Money User";
            this.UserMoneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(103, 413);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(69, 26);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainPageBtn
            // 
            this.MainPageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageBtn.Location = new System.Drawing.Point(30, 413);
            this.MainPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MainPageBtn.Name = "MainPageBtn";
            this.MainPageBtn.Size = new System.Drawing.Size(69, 26);
            this.MainPageBtn.TabIndex = 6;
            this.MainPageBtn.Text = "Back";
            this.MainPageBtn.UseVisualStyleBackColor = false;
            this.MainPageBtn.Click += new System.EventHandler(this.MainPageBtn_Click);
            // 
            // CheckAccountFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MainPageBtn);
            this.Controls.Add(this.UserMoneyLabel);
            this.Controls.Add(this.label1);
            this.Name = "CheckAccountFm";
            this.Text = "CheckAccountFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UserMoneyLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MainPageBtn;
    }
}