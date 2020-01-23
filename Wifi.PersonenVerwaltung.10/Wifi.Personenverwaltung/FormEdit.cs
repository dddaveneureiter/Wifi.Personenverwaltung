using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Data.PersVer;

namespace Wifi.PersonenVerwaltung
{
	public partial class FormEdit : Form
	{

		private Person person = null;

		public FormEdit()
		{
			InitializeComponent();
		}

		public FormEdit(Person person)
		{
			InitializeComponent();
			this.person = person;
			this.textBoxVorname.Text = person.Vorname;
			this.textBoxNachname.Text = person.Nachname;

			switch (person.Geschlecht)
			{
				case "m":
					this.radioButtonGeschlechtM.Checked = true;
					break;
				case "w":
					this.radioButtonGeschlechtW.Checked = true;
					break;
				default:
					this.radioButtonGeschlechtD.Checked = true;
					break;
			}

			this.dateTimePickerGebDat.Value = (person.GeburtsDatum == DateTime.MinValue ? DateTime.Now : person.GeburtsDatum);

			UserControlKontaktItem uc = null;
			foreach(Kontakt kontakt in person.KontaktListe)
			{
				uc = new UserControlKontaktItem(kontakt);
				this.flowLayoutPanelKontakt.Controls.Add(uc);
			}


		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (this.person == null) this.person = new Person();
			this.person.Vorname = this.textBoxVorname.Text;
			this.person.Nachname = this.textBoxNachname.Text;
			if (this.radioButtonGeschlechtW.Checked) this.person.Geschlecht = "w";
			else if (this.radioButtonGeschlechtM.Checked) this.person.Geschlecht = "m";
			else this.person.Geschlecht = "d";
			this.person.GeburtsDatum = this.dateTimePickerGebDat.Value;

			this.person.KontaktListe = new List<Kontakt>();
			foreach (UserControlKontaktItem uc in this.flowLayoutPanelKontakt.Controls)
				if (uc.Kontakt != null) this.person.KontaktListe.Add(uc.Kontakt);

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void buttonCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public Person Person
		{
			get
			{
				return this.person;
			}
		}

		private void buttonKontaktAdd_Click(object sender, EventArgs e)
		{
			UserControlKontaktItem uc = new UserControlKontaktItem();
			this.flowLayoutPanelKontakt.Controls.Add(uc);
		}

		private void flowLayoutPanelKontakt_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
