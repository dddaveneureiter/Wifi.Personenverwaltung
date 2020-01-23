using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Data.PersVer;

namespace Wifi.PersonenVerwaltung
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void menuItemOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "DAT Datei|*.dat|Alle Dateien|*.*";
			dialog.InitialDirectory = "c:\\Solutions";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				DisplayData(Manager.PersonLesen(dialog.FileName));
			}

		}

		private void menuItemSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter = "DAT Datei|*.dat|Alle Dateien|*.*";
			dialog.InitialDirectory = "c:\\Solutions";

			if (dialog.ShowDialog() == DialogResult.OK)
			{
				List<Person> outList = new List<Person>();
				// das Person Objekt wurde in der Methode DisplayData im Tag Property der ListViewItems abgelegt
				foreach (ListViewItem item in this.listViewPerson.Items) outList.Add((Person)item.Tag);
				Manager.PersonSchreiben(dialog.FileName, outList);
			}

		}


		private void DisplayData(List<Person> personList)
		{
			this.listViewPerson.Items.Clear();
			foreach (Person person in personList) ItemAdd(person);

		}

		private void menuItemNew_Click(object sender, EventArgs e)
		{
			FormEdit editForm = new FormEdit();
			if (editForm.ShowDialog() == DialogResult.OK)
			{
				ItemAdd(editForm.Person);
				
			}
		}

		private void menuItemDel_Click(object sender, EventArgs e)
		{
			if (this.listViewPerson.SelectedItems.Count == 1 && MessageBox.Show("Wollen Sie die Person wirklich löschen?", 
				"Frage", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.listViewPerson.Items.Remove(this.listViewPerson.SelectedItems[0]);
				for (int i = 0; i < this.listViewPerson.Items.Count; i++)
				{
					if (i % 2 == 0) this.listViewPerson.Items[i].BackColor = Color.White;
					else this.listViewPerson.Items[i].BackColor = Color.LightSteelBlue;
				}

			}

		}

		private void listViewPerson_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			ListViewItem item = this.listViewPerson.GetItemAt(e.X, e.Y);
			Person person = item.Tag as Person;
			FormEdit editForm = new FormEdit(person);
			if (editForm.ShowDialog() == DialogResult.OK)
			{
				item.Text = person.Vorname;
				item.SubItems[1].Text = person.Nachname;
				item.SubItems[2].Text = person.Geschlecht;
				item.SubItems[3].Text = person.GeburtsDatum.ToShortDateString();
			}


		}

		private void ItemAdd(Person person)
		{
			// neue Zeile anlegen
			ListViewItem item = new ListViewItem();
			// das Tag ist vom Typ object und kann damit ist es möglichdamit alle Arten von Daten aufnehmen, hier: eine Objektreferenz auf die Person!
			item.Tag = person;
			// die erste Spalte
			item.Text = person.Vorname;
			// alle weiteren Spalten werden über die SubItems Collection eingefügt, ist ein Wert nicht vorhanden, muß zumindest ein Leerwert (z.B. string.Empty)
			// eingefügt werden, damit die Spalten zu den angelegt ColumHeaders passen.
			item.SubItems.Add(person.Nachname);
			item.SubItems.Add(person.Geschlecht);
			item.SubItems.Add(person.GeburtsDatum == DateTime.MinValue ? string.Empty : person.GeburtsDatum.ToShortDateString());

			this.listViewPerson.Items.Add(item);
			// damit jede 2. Zeile eine andere Farbe bekommt
			if (this.listViewPerson.Items.Count % 2 == 0) item.BackColor = Color.LightSteelBlue;
		}

		private void listViewPerson_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
