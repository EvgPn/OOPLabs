namespace Lab4
{
	partial class AuthorForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.AuthorNameText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.AuthorSurnameText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.BirthdayText = new System.Windows.Forms.DateTimePicker();
			this.SaveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 32);
			this.label1.TabIndex = 2;
			this.label1.Text = "Author Name";
			// 
			// AuthorNameText
			// 
			this.AuthorNameText.Location = new System.Drawing.Point(18, 44);
			this.AuthorNameText.Name = "AuthorNameText";
			this.AuthorNameText.Size = new System.Drawing.Size(536, 22);
			this.AuthorNameText.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 32);
			this.label2.TabIndex = 7;
			this.label2.Text = "Author Surname";
			// 
			// AuthorSurnameText
			// 
			this.AuthorSurnameText.Location = new System.Drawing.Point(18, 115);
			this.AuthorSurnameText.Name = "AuthorSurnameText";
			this.AuthorSurnameText.Size = new System.Drawing.Size(536, 22);
			this.AuthorSurnameText.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "Birthday";
			// 
			// BirthdayText
			// 
			this.BirthdayText.Location = new System.Drawing.Point(18, 208);
			this.BirthdayText.Name = "BirthdayText";
			this.BirthdayText.Size = new System.Drawing.Size(267, 22);
			this.BirthdayText.TabIndex = 10;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(18, 345);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(109, 46);
			this.SaveButton.TabIndex = 11;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// AuthorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 403);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.BirthdayText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AuthorSurnameText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.AuthorNameText);
			this.Controls.Add(this.label1);
			this.Name = "AuthorForm";
			this.Text = "Author";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox AuthorNameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox AuthorSurnameText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker BirthdayText;
		private System.Windows.Forms.Button SaveButton;
	}
}