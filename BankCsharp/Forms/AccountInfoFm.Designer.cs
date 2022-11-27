namespace BankCsharp.Forms
{
    partial class AccountInfoFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountInfoFm));
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NationalNumberInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CardNumebrInput = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.MainPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(215, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(336, 83);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.ReadOnly = true;
            this.UsernameInput.Size = new System.Drawing.Size(277, 35);
            this.UsernameInput.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(139, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "National-Number";
            // 
            // NationalNumberInput
            // 
            this.NationalNumberInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalNumberInput.Location = new System.Drawing.Point(336, 165);
            this.NationalNumberInput.Name = "NationalNumberInput";
            this.NationalNumberInput.ReadOnly = true;
            this.NationalNumberInput.Size = new System.Drawing.Size(237, 35);
            this.NationalNumberInput.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(179, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Card-Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardNumebrInput
            // 
            this.CardNumebrInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumebrInput.Location = new System.Drawing.Point(336, 124);
            this.CardNumebrInput.Name = "CardNumebrInput";
            this.CardNumebrInput.ReadOnly = true;
            this.CardNumebrInput.Size = new System.Drawing.Size(260, 35);
            this.CardNumebrInput.TabIndex = 11;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(89, 413);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(69, 26);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MainPageBtn
            // 
            this.MainPageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageBtn.Location = new System.Drawing.Point(16, 413);
            this.MainPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MainPageBtn.Name = "MainPageBtn";
            this.MainPageBtn.Size = new System.Drawing.Size(69, 26);
            this.MainPageBtn.TabIndex = 13;
            this.MainPageBtn.Text = "Back";
            this.MainPageBtn.UseVisualStyleBackColor = false;
            this.MainPageBtn.Click += new System.EventHandler(this.MainPageBtn_Click);
            // 
            // AccountInfoFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.MainPageBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CardNumebrInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NationalNumberInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsernameInput);
            this.Name = "AccountInfoFm";
            this.Text = "AccountInfoFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NationalNumberInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CardNumebrInput;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button MainPageBtn;
    }
}