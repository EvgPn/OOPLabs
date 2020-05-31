using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab4
{
	public partial class MainForm : Form
	{
		private List<Journal> _journals = new List<Journal>();

		public MainForm()
		{
			InitializeComponent();
			EditButton.Enabled = false;
			InfoButton.Enabled = false;
			DeleteButton.Enabled = false;

			_journals = Journal.ReadJournalList("journals");
			_journals.ForEach(journalListInfo =>
			{
				ListOfJournals.Items.Add(journalListInfo.ToShortString());
			});
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Journal journal = new Journal();
			JournalForm journalForm = new JournalForm(journal);
			if (journalForm.ShowDialog() == DialogResult.OK)
			{
				ListOfJournals.Items.Add(journal.ToShortString());
				_journals.Add(journal);
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (_journals != null)
			{
				Journal.WriteJournalsToFile("journals", _journals);
				MessageBox.Show("Saved successfully!");
			}
			else
			{
				MessageBox.Show("There are nothing to save");
			}
			DialogResult = DialogResult.OK;
			Close();
		}

		private void EditButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfJournals.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _journals.Count)
			{
				MessageBox.Show("Choose journal");
				return;
			}
			JournalForm journalForm = new JournalForm(_journals[ListOfJournals.SelectedIndex]);
			if (journalForm.ShowDialog() == DialogResult.OK)
			{
				ListOfJournals.Items[selectedIndex] = _journals[ListOfJournals.SelectedIndex].ToShortString();
			}
			else
			{
				MessageBox.Show("Changes was not saved");
			}
		}

		private void InfoButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfJournals.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _journals.Count)
			{
				MessageBox.Show("Choose journal");
			}
			else
			{
				MessageBox.Show(_journals[selectedIndex].ToString());
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			int selectedIndex = ListOfJournals.SelectedIndex;
			if (selectedIndex < 0 || selectedIndex >= _journals.Count)
			{
				MessageBox.Show("Choose journal");
				return;
			}
			_journals.RemoveAt(selectedIndex);
			ListOfJournals.Items.RemoveAt(selectedIndex);
		}

		private void ListOfJournals_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditButton.Enabled = true;
			InfoButton.Enabled = true;
			DeleteButton.Enabled = true;
		}
	}
}
