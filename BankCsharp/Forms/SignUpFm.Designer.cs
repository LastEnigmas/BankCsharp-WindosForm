namespace BankCsharp.Forms
{
    partial class SignUpFm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpFm));
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.RePasswordinput = new System.Windows.Forms.TextBox();
            this.NationalCodeInput = new System.Windows.Forms.TextBox();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ShoOrHide = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(311, 79);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(277, 35);
            this.UsernameInput.TabIndex = 3;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(311, 130);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(277, 35);
            this.PasswordInput.TabIndex = 4;
            // 
            // RePasswordinput
            // 
            this.RePasswordinput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RePasswordinput.Location = new System.Drawing.Point(311, 180);
            this.RePasswordinput.Name = "RePasswordinput";
            this.RePasswordinput.Size = new System.Drawing.Size(277, 35);
            this.RePasswordinput.TabIndex = 5;
            // 
            // NationalCodeInput
            // 
            this.NationalCodeInput.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCodeInput.Location = new System.Drawing.Point(311, 232);
            this.NationalCodeInput.Name = "NationalCodeInput";
            this.NationalCodeInput.Size = new System.Drawing.Size(277, 35);
            this.NationalCodeInput.TabIndex = 6;
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUpBtn.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpBtn.Location = new System.Drawing.Point(424, 289);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(164, 48);
            this.SignUpBtn.TabIndex = 8;
            this.SignUpBtn.Text = "SignUp";
            this.SignUpBtn.UseVisualStyleBackColor = false;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(311, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(191, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(197, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(171, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "Repassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(148, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "National Code";
            // 
            // ShoOrHide
            // 
            this.ShoOrHide.AutoSize = true;
            this.ShoOrHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShoOrHide.BackgroundImage")));
            this.ShoOrHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShoOrHide.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShoOrHide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShoOrHide.Location = new System.Drawing.Point(594, 138);
            this.ShoOrHide.Name = "ShoOrHide";
            this.ShoOrHide.Size = new System.Drawing.Size(68, 24);
            this.ShoOrHide.TabIndex = 13;
            this.ShoOrHide.Text = "Show";
            this.ShoOrHide.UseVisualStyleBackColor = true;
            this.ShoOrHide.CheckedChanged += new System.EventHandler(this.ShoOrHide_CheckedChanged);
            // 
            // SignUpFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShoOrHide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NationalCodeInput);
            this.Controls.Add(this.RePasswordinput);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Name = "SignUpFm";
            this.Text = "SignUpFm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox RePasswordinput;
        private System.Windows.Forms.TextBox NationalCodeInput;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ShoOrHide;
    }
}