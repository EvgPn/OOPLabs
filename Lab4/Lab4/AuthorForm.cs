using System;
using System.Windows.Forms;

namespace Lab4
{
	public partial class AuthorForm : Form
	{
		private Author _author;

		public AuthorForm(Author author)
		{
			InitializeComponent();

			_author = author;

			if (author != null && author.Name != null && author.Surname != null && author.Birthday != null)
			{
				AuthorNameText.Text = author.Name;
				AuthorSurnameText.Text = author.Surname;
				BirthdayText.Value = author.Birthday;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(AuthorNameText.Text) || string.IsNullOrEmpty(AuthorSurnameText.Text))
			{
				MessageBox.Show("Fill empty fields");
				return;
			}
			else
			{
				_author.Name = AuthorNameText.Text;
				_author.Surname = AuthorSurnameText.Text;
				_author.Birthday = BirthdayText.Value;
				DialogResult = DialogResult.OK;
			}
		}

		private void AuthorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_author.Name = AuthorNameText.Text;
					_author.Surname = AuthorSurnameText.Text;
					_author.Birthday = BirthdayText.Value;
					DialogResult = DialogResult.OK;
				}
				else
				{
					DialogResult = DialogResult.Cancel;
				}
			}
		}
	}
}
