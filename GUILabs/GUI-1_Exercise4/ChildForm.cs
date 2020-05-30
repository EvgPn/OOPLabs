using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_1_Exercise4
{
	public partial class ChildForm : GUI_1_Exercise4.ParentForm
	{
		public ChildForm()
		{
			InitializeComponent();
		}

		private void ToggleMenuItem_Click(object sender, EventArgs e)
		{
			if (ToggleMenuItem.Checked)
			{
				ToggleMenuItem.Checked = false;
				ChildTextBox.ForeColor = System.Drawing.Color.Black;
			}
			else
			{
				ToggleMenuItem.Checked = true;
				ChildTextBox.ForeColor = System.Drawing.Color.Blue;
			}
		}
	}
}
