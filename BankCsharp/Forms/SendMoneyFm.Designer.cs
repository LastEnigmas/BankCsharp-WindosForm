namespace BankCsharp.Forms
{
    partial class SendMoneyFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendMoneyFm));
            this.label1 = new System.Windows.Forms.Label();
            this.SecendCardNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MoneyInput = new System.Windows.Forms.TextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.MainPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(194, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Card-Number";
            // 
            // SecendCardNumber
            // 
            this.SecendCardNumber.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecendCardNumber.Location = new System.Drawing.Point(351, 116);
            this.SecendCardNumber.Name = "SecendCardNumber";
            this.SecendCardNumber.Size = new System.Drawing.Size(260, 35);
            this.SecendCardNumber.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(263, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Money";
            // 
            // MoneyInput
            // 
            this.MoneyInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneyInput.Location = new System.Drawing.Point(351, 172);
            this.MoneyInput.Name = "MoneyInput";
            this.MoneyInput.Size = new System.Drawing.Size(159, 35);
            this.MoneyInput.TabIndex = 17;
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(441, 284);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(69, 26);
            this.NextBtn.TabIndex = 20;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // MainPageBtn
            // 
            this.MainPageBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainPageBtn.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPageBtn.Location = new System.Drawing.Point(324, 284);
            this.MainPageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.MainPageBtn.Name = "MainPageBtn";
            this.MainPageBtn.Size = new System.Drawing.Size(69, 26);
            this.MainPageBtn.TabIndex = 19;
            this.MainPageBtn.Text = "Back";
            this.MainPageBtn.UseVisualStyleBackColor = false;
            this.MainPageBtn.Click += new System.EventHandler(this.MainPageBtn_Click);
            // 
            // SendMoneyFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.MainPageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoneyInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecendCardNumber);
            this.Name = "SendMoneyFm";
            this.Text = "SendMoneyFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecendCardNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MoneyInput;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button MainPageBtn;
    }
}