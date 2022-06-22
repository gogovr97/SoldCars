
namespace SoldCars
{
    partial class Home
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
            this.DailyTaskLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.IsDoneLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TrueCheckBox = new System.Windows.Forms.CheckBox();
            this.FalseCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.TaskGridView = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PriseTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DailyTaskLabel
            // 
            this.DailyTaskLabel.AutoSize = true;
            this.DailyTaskLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DailyTaskLabel.Location = new System.Drawing.Point(932, 13);
            this.DailyTaskLabel.Name = "DailyTaskLabel";
            this.DailyTaskLabel.Size = new System.Drawing.Size(195, 46);
            this.DailyTaskLabel.TabIndex = 0;
            this.DailyTaskLabel.Text = "Car Storage";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(12, 13);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(97, 28);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Car Brand";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 81);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(121, 28);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description: ";
            // 
            // IsDoneLabel
            // 
            this.IsDoneLabel.AutoSize = true;
            this.IsDoneLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsDoneLabel.Location = new System.Drawing.Point(259, 70);
            this.IsDoneLabel.Name = "IsDoneLabel";
            this.IsDoneLabel.Size = new System.Drawing.Size(124, 28);
            this.IsDoneLabel.TabIndex = 3;
            this.IsDoneLabel.Text = "is it available";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.TitleTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleTextBox.Location = new System.Drawing.Point(12, 44);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(209, 34);
            this.TitleTextBox.TabIndex = 4;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 110);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(339, 73);
            this.DescriptionTextBox.TabIndex = 5;
            // 
            // TrueCheckBox
            // 
            this.TrueCheckBox.AutoSize = true;
            this.TrueCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrueCheckBox.Location = new System.Drawing.Point(389, 70);
            this.TrueCheckBox.Name = "TrueCheckBox";
            this.TrueCheckBox.Size = new System.Drawing.Size(58, 32);
            this.TrueCheckBox.TabIndex = 8;
            this.TrueCheckBox.Text = "Yes";
            this.TrueCheckBox.UseVisualStyleBackColor = true;
            this.TrueCheckBox.CheckedChanged += new System.EventHandler(this.TrueCheckBox_CheckedChanged);
            // 
            // FalseCheckBox
            // 
            this.FalseCheckBox.AutoSize = true;
            this.FalseCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FalseCheckBox.Location = new System.Drawing.Point(453, 70);
            this.FalseCheckBox.Name = "FalseCheckBox";
            this.FalseCheckBox.Size = new System.Drawing.Size(58, 32);
            this.FalseCheckBox.TabIndex = 9;
            this.FalseCheckBox.Text = "No";
            this.FalseCheckBox.UseVisualStyleBackColor = true;
            this.FalseCheckBox.CheckedChanged += new System.EventHandler(this.FalseCheckBox_CheckedChanged);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.Silver;
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(12, 190);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(115, 48);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // TaskGridView
            // 
            this.TaskGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskGridView.Location = new System.Drawing.Point(167, 190);
            this.TaskGridView.Name = "TaskGridView";
            this.TaskGridView.RowTemplate.Height = 25;
            this.TaskGridView.Size = new System.Drawing.Size(707, 248);
            this.TaskGridView.TabIndex = 11;
            this.TaskGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TaskGridView_RowHeaderMouseClick);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Silver;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.Location = new System.Drawing.Point(12, 259);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(115, 48);
            this.UpdateButton.TabIndex = 12;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Silver;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(12, 327);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(115, 48);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Silver;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClearButton.Location = new System.Drawing.Point(12, 393);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 48);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(1037, 390);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(115, 48);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PriseTextBox
            // 
            this.PriseTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PriseTextBox.Location = new System.Drawing.Point(335, 34);
            this.PriseTextBox.Name = "PriseTextBox";
            this.PriseTextBox.Size = new System.Drawing.Size(100, 23);
            this.PriseTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(259, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Prise:";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PriseTextBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TaskGridView);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FalseCheckBox);
            this.Controls.Add(this.TrueCheckBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.IsDoneLabel);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DailyTaskLabel);
            this.Name = "Home";
            this.Text = "Home Form";
            ((System.ComponentModel.ISupportInitialize)(this.TaskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DailyTaskLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label IsDoneLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.CheckBox TrueCheckBox;
        private System.Windows.Forms.CheckBox FalseCheckBox;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.DataGridView TaskGridView;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox PriseTextBox;
        private System.Windows.Forms.Label label1;
    }
}