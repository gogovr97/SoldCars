
namespace SoldCars
{
    partial class Login
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
            this.RegisterTextButton = new System.Windows.Forms.LinkLabel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegisterTextButton
            // 
            this.RegisterTextButton.AutoSize = true;
            this.RegisterTextButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterTextButton.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.RegisterTextButton.Location = new System.Drawing.Point(39, 392);
            this.RegisterTextButton.Name = "RegisterTextButton";
            this.RegisterTextButton.Size = new System.Drawing.Size(394, 28);
            this.RegisterTextButton.TabIndex = 17;
            this.RegisterTextButton.TabStop = true;
            this.RegisterTextButton.Text = "If you dont have registraction, register there";
            this.RegisterTextButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterTextButton_LinkClicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(140, 308);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(180, 48);
            this.LoginButton.TabIndex = 16;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordInput.Location = new System.Drawing.Point(187, 227);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(246, 34);
            this.PasswordInput.TabIndex = 14;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameInput.Location = new System.Drawing.Point(187, 155);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(246, 34);
            this.UsernameInput.TabIndex = 13;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(25, 223);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(134, 37);
            this.PasswordLabel.TabIndex = 11;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLabel.Location = new System.Drawing.Point(20, 152);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(149, 37);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "Username: ";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextLabel.Location = new System.Drawing.Point(164, 50);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(122, 54);
            this.TextLabel.TabIndex = 9;
            this.TextLabel.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.RegisterTextButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.TextLabel);
            this.Name = "Login";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel RegisterTextButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label TextLabel;
    }
}