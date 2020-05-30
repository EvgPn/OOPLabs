namespace GUI_1_Exercise4
{
	partial class ChildForm
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
			this.ChildTextBox = new System.Windows.Forms.RichTextBox();
			this.ChildWindowForm = new System.Windows.Forms.MenuStrip();
			this.FormatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToggleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ChildWindowForm.SuspendLayout();
			this.SuspendLayout();
			// 
			// ChildTextBox
			// 
			this.ChildTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChildTextBox.Location = new System.Drawing.Point(0, 56);
			this.ChildTextBox.Name = "ChildTextBox";
			this.ChildTextBox.Size = new System.Drawing.Size(800, 394);
			this.ChildTextBox.TabIndex = 3;
			this.ChildTextBox.Text = "";
			// 
			// ChildWindowForm
			// 
			this.ChildWindowForm.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ChildWindowForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FormatMenuItem});
			this.ChildWindowForm.Location = new System.Drawing.Point(0, 0);
			this.ChildWindowForm.Name = "ChildWindowForm";
			this.ChildWindowForm.Size = new System.Drawing.Size(800, 28);
			this.ChildWindowForm.TabIndex = 4;
			this.ChildWindowForm.Text = "menuStrip2";
			// 
			// FormatMenuItem
			// 
			this.FormatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToggleMenuItem});
			this.FormatMenuItem.MergeAction = System.Windows.Forms.MergeAction.Insert;
			this.FormatMenuItem.MergeIndex = 1;
			this.FormatMenuItem.Name = "FormatMenuItem";
			this.FormatMenuItem.Size = new System.Drawing.Size(70, 24);
			this.FormatMenuItem.Text = "&Format";
			// 
			// ToggleMenuItem
			// 
			this.ToggleMenuItem.Name = "ToggleMenuItem";
			this.ToggleMenuItem.Size = new System.Drawing.Size(224, 26);
			this.ToggleMenuItem.Text = "&ToggleForeground";
			this.ToggleMenuItem.Click += new System.EventHandler(this.ToggleMenuItem_Click);
			// 
			// ChildForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ChildTextBox);
			this.Controls.Add(this.ChildWindowForm);
			this.Name = "ChildForm";
			this.Text = "Child Form";
			this.Controls.SetChildIndex(this.ChildWindowForm, 0);
			this.Controls.SetChildIndex(this.ChildTextBox, 0);
			this.ChildWindowForm.ResumeLayout(false);
			this.ChildWindowForm.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox ChildTextBox;
		private System.Windows.Forms.MenuStrip ChildWindowForm;
		private System.Windows.Forms.ToolStripMenuItem FormatMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ToggleMenuItem;
	}
}
