namespace Lab4
{
	partial class JournalForm
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
			this.label2 = new System.Windows.Forms.Label();
			this.JournalNameText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.ListOfArticles = new System.Windows.Forms.ListBox();
			this.NewButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.PeriodicitiesText = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Journal Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "Periodicity";
			// 
			// JournalNameText
			// 
			this.JournalNameText.Location = new System.Drawing.Point(209, 19);
			this.JournalNameText.Name = "JournalNameText";
			this.JournalNameText.Size = new System.Drawing.Size(339, 22);
			this.JournalNameText.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(13, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Articles";
			// 
			// ListOfArticles
			// 
			this.ListOfArticles.FormattingEnabled = true;
			this.ListOfArticles.ItemHeight = 16;
			this.ListOfArticles.Location = new System.Drawing.Point(18, 175);
			this.ListOfArticles.Name = "ListOfArticles";
			this.ListOfArticles.Size = new System.Drawing.Size(395, 148);
			this.ListOfArticles.TabIndex = 6;
			this.ListOfArticles.SelectedIndexChanged += new System.EventHandler(this.ListOfJournals_SelectedIndexChanged);
			// 
			// NewButton
			// 
			this.NewButton.Location = new System.Drawing.Point(439, 175);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(109, 46);
			this.NewButton.TabIndex = 7;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(439, 227);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(109, 46);
			this.EditButton.TabIndex = 8;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(439, 279);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(109, 46);
			this.DeleteButton.TabIndex = 9;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(18, 345);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(109, 46);
			this.SaveButton.TabIndex = 10;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// PeriodicitiesText
			// 
			this.PeriodicitiesText.FormattingEnabled = true;
			this.PeriodicitiesText.Location = new System.Drawing.Point(209, 75);
			this.PeriodicitiesText.Name = "PeriodicitiesText";
			this.PeriodicitiesText.Size = new System.Drawing.Size(339, 24);
			this.PeriodicitiesText.TabIndex = 11;
			// 
			// JournalForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 403);
			this.Controls.Add(this.PeriodicitiesText);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.ListOfArticles);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.JournalNameText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "JournalForm";
			this.Text = "Journal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JournalForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox JournalNameText;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox ListOfArticles;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.ComboBox PeriodicitiesText;
	}
}