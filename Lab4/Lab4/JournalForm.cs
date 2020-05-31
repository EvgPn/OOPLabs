using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
	public partial class JournalForm : Form
	{
		public Journal _journal;

		public JournalForm(Journal journal)
		{
			InitializeComponent();
			_journal = journal;
			EditButton.Enabled = false;		
			DeleteButton.Enabled = false;

			Periodicity[] periodicities = (Periodicity[])Enum.GetValues(typeof(Periodicity));
			foreach (Periodicity periodicity in periodicities)
			{
				PeriodicitiesText.Items.Add(periodicity.ToString());
			}
			if (_journal != null && _journal.JournalName != null && journal.Periodicity != null)
			{
				PeriodicitiesText.SelectedIndex = PeriodicitiesText.Items.IndexOf(journal.Periodicity.ToString());
				JournalNameText.Text = journal.JournalName;
				_journal.CalculateNumOfPagesAndAuthors();				
				if (journal.Articles != null)
				{
					journal.Articles.ForEach(article =>
					{
						ListOfArticles.Items.Add(article);
					});
				}
			}
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Article article = new Article();
			ArticleForm articleForm = new ArticleForm(article);
            if (articleForm.ShowDialog() == DialogResult.OK)
            {
                _journal.AddArticle(article);
                _journal.CalculateNumOfPagesAndAuthors();
                ListOfArticles.Items.Add(article.ToString());                
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }

		private void ListOfJournals_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;			
			DeleteButton.Enabled = true;
		}

        private void EditButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListOfArticles.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _journal.Articles.Count)
            {
                MessageBox.Show("Choose article");
                return;
            }
            ArticleForm articleForm = new ArticleForm(_journal.Articles[selectedIndex]);
            if (articleForm.ShowDialog() == DialogResult.OK)
            {
                ListOfArticles.Items[selectedIndex] = _journal.Articles[selectedIndex].ToString();
                _journal.CalculateNumOfPagesAndAuthors();                
            }
            else
            {
                MessageBox.Show("Changes was not saved");
            }
        }        
                
        private void SaveButton_Click(object sender, EventArgs e)
        {
            _journal.JournalName = JournalNameText.Text;
            if (PeriodicitiesText.SelectedItem == null || JournalNameText.Text == "")
            {
                MessageBox.Show("Fill empty fields");
                return;
            }
            _journal.Periodicity = (Periodicity)Enum.Parse(typeof(Periodicity), PeriodicitiesText.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }

        private void JournalForm_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Save changes?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _journal.JournalName = JournalNameText.Text;
                    _journal.Periodicity = (Periodicity)Enum.Parse(typeof(Periodicity), PeriodicitiesText.SelectedItem.ToString());
                    _journal.Articles = _journal.Articles != null ? _journal.Articles : null;
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListOfArticles.SelectedIndex;
            if (selectedIndex < 0 || selectedIndex >= _journal.Articles.Count)
            {
                MessageBox.Show("Choose article");
                return;
            }
            _journal.Articles.RemoveAt(selectedIndex);
            ListOfArticles.Items.RemoveAt(selectedIndex);
        }
    }
}
