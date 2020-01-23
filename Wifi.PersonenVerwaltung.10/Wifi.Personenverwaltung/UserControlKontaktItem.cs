using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wifi.Data.PersVer;

namespace Wifi.PersonenVerwaltung
{
	public partial class UserControlKontaktItem : UserControl
	{
		private Kontakt kontakt = null;

		public UserControlKontaktItem()
		{
			InitializeComponent();
		}
		public UserControlKontaktItem(Kontakt kontakt)
		{
			InitializeComponent();
			this.kontakt = kontakt;
			this.comboBoxBezeichnung.SelectedItem = kontakt.Bezeichnung;
			this.textBoxWert.Text = kontakt.Wert;
		}

		public Kontakt Kontakt
		{
			get
			{
				if (this.comboBoxBezeichnung.SelectedItem != null)
				{
					if (this.kontakt == null) this.kontakt = new Kontakt();
					this.kontakt.Bezeichnung = this.comboBoxBezeichnung.SelectedItem.ToString();
					this.kontakt.Wert = this.textBoxWert.Text;
				}
				return this.kontakt;
			}
		}
	}
}
