namespace Lab4
{
	partial class ArticleForm
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
			this.ArticleNameText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PagesNumText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.FeeText = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.NewButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.ListOfAuthors = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Article Name";
			// 
			// ArticleNameText
			// 
			this.ArticleNameText.Location = new System.Drawing.Point(204, 19);
			this.ArticleNameText.Name = "ArticleNameText";
			this.ArticleNameText.Size = new System.Drawing.Size(339, 22);
			this.ArticleNameText.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 32);
			this.label2.TabIndex = 6;
			this.label2.Text = "Pages Num";
			// 
			// PagesNumText
			// 
			this.PagesNumText.Location = new System.Drawing.Point(204, 70);
			this.PagesNumText.Name = "PagesNumText";
			this.PagesNumText.Size = new System.Drawing.Size(118, 22);
			this.PagesNumText.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(346, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 32);
			this.label3.TabIndex = 9;
			this.label3.Text = "Fee";
			// 
			// FeeText
			// 
			this.FeeText.Location = new System.Drawing.Point(428, 70);
			this.FeeText.Name = "FeeText";
			this.FeeText.Size = new System.Drawing.Size(115, 22);
			this.FeeText.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(13, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Authors";
			// 
			// NewButton
			// 
			this.NewButton.Location = new System.Drawing.Point(434, 174);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(109, 46);
			this.NewButton.TabIndex = 13;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(434, 226);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(109, 46);
			this.EditButton.TabIndex = 14;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(18, 345);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(109, 46);
			this.SaveButton.TabIndex = 16;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ListOfAuthors
			// 
			this.ListOfAuthors.FormattingEnabled = true;
			this.ListOfAuthors.Location = new System.Drawing.Point(18, 186);
			this.ListOfAuthors.Name = "ListOfAuthors";
			this.ListOfAuthors.Size = new System.Drawing.Size(392, 24);
			this.ListOfAuthors.TabIndex = 17;
			this.ListOfAuthors.SelectedIndexChanged += new System.EventHandler(this.ListOfJournals_SelectedIndexChanged);
			// 
			// ArticleForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 403);
			this.Controls.Add(this.ListOfAuthors);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.FeeText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PagesNumText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ArticleNameText);
			this.Controls.Add(this.label1);
			this.Name = "ArticleForm";
			this.Text = "Article";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ArticleInfo_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox ArticleNameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PagesNumText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FeeText;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox ListOfAuthors;
	}
}