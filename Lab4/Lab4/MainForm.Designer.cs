namespace Lab4
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.ListOfJournals = new System.Windows.Forms.ListBox();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.EditButton = new System.Windows.Forms.Button();
			this.InfoButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ListOfJournals
			// 
			this.ListOfJournals.FormattingEnabled = true;
			this.ListOfJournals.ItemHeight = 16;
			this.ListOfJournals.Location = new System.Drawing.Point(12, 64);
			this.ListOfJournals.Name = "ListOfJournals";
			this.ListOfJournals.Size = new System.Drawing.Size(377, 244);
			this.ListOfJournals.TabIndex = 0;
			this.ListOfJournals.SelectedIndexChanged += new System.EventHandler(this.ListOfJournals_SelectedIndexChanged);
			// 
			// NewButton
			// 
			this.NewButton.Location = new System.Drawing.Point(12, 336);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(109, 46);
			this.NewButton.TabIndex = 1;
			this.NewButton.Text = "New";
			this.NewButton.UseVisualStyleBackColor = true;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(145, 336);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(109, 46);
			this.DeleteButton.TabIndex = 2;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(427, 64);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(109, 46);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// EditButton
			// 
			this.EditButton.Location = new System.Drawing.Point(427, 133);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(109, 46);
			this.EditButton.TabIndex = 4;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// InfoButton
			// 
			this.InfoButton.Location = new System.Drawing.Point(280, 336);
			this.InfoButton.Name = "InfoButton";
			this.InfoButton.Size = new System.Drawing.Size(109, 46);
			this.InfoButton.TabIndex = 5;
			this.InfoButton.Text = "Info";
			this.InfoButton.UseVisualStyleBackColor = true;
			this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(212, 32);
			this.label1.TabIndex = 6;
			this.label1.Text = "List Of Journals";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 403);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.InfoButton);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.ListOfJournals);
			this.Name = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox ListOfJournals;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button InfoButton;
		private System.Windows.Forms.Label label1;
	}
}

