using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
	public partial class ArticleForm : Form
	{
		Article _article;
		List<Author> _authors;

		public ArticleForm(Article article)
		{
			InitializeComponent();
			_article = article;
			EditButton.Enabled = false;

			_authors = Author.ReadAuthorsList("authors");
			_authors.ForEach(author =>
			{
				ListOfAuthors.Items.Add(author.ToString());
			});

			if (_article != null && _article.ArticleName != null && _article.AuthorOfArticle != null)
			{
				ListOfAuthors.SelectedIndex = ListOfAuthors.Items.IndexOf(article.AuthorOfArticle.ToString());
				ArticleNameText.Text = article.ArticleName;
				PagesNumText.Text = article.PagesNum.ToString();
				FeeText.Text = article.Fee.ToString();
			}

		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Author newAuthor = new Author();
			AuthorForm authorForm = new AuthorForm(newAuthor);
			if (authorForm.ShowDialog() == DialogResult.OK)
			{
				ListOfAuthors.Items.Add(newAuthor.ToString());
				_authors.Add(newAuthor);
				Author.WriteAuthorsToFile("authors", _authors);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfAuthors.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _authors.Count)
			{
				MessageBox.Show("Choose author");
				return;
			}
			AuthorForm authorModal = new AuthorForm(_authors[selectedIndex]);
			if (authorModal.ShowDialog() == DialogResult.OK)
			{
				ListOfAuthors.Items[selectedIndex] = _authors[selectedIndex].ToString();
				Author.WriteAuthorsToFile("authors", _authors);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfAuthors.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _authors.Count)
			{
				MessageBox.Show("Choose author");
				return;
			}
			if (ArticleNameText.Text == "" || PagesNumText.Text == "" || FeeText.Text == "")
			{
				MessageBox.Show("Fill empty fields");
				return;
			}
			_article.AuthorOfArticle = _authors[selectedIndex];
			_article.ArticleName = ArticleNameText.Text;
			_article.PagesNum = int.Parse(PagesNumText.Text);
			_article.Fee = int.Parse(FeeText.Text);
			DialogResult = DialogResult.OK;
		}

		private void ListOfJournals_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;
		}

		private void ArticleInfo_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					_article.AuthorOfArticle = _authors[ListOfAuthors.SelectedIndex];
					_article.ArticleName = ArticleNameText.Text;
					_article.PagesNum = int.Parse(PagesNumText.Text);
					_article.Fee = int.Parse(FeeText.Text);
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
