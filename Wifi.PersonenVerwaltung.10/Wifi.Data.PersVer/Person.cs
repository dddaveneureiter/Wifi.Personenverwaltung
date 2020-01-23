using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Wifi.Data.PersVer
{
	public class Person
	{

		// ***********************************************************************************
		#region static methods

		#endregion

		// ***********************************************************************************
		#region constructors
		public Person()
		{

		}

		public Person(string datenZeile)
		{
			string[] teile = datenZeile.Split('\t');
			this.Vorname = teile[0];
			this.Nachname = teile[1];
			// ternärer Operator: wie eine IF Anweisung!!!
			this.Geschlecht = (teile.Length > 2 ? teile[2] : string.Empty);
			this.GeburtsDatum = (teile.Length > 3 ? DateTime.Parse(teile[3]) : DateTime.MinValue);

			if (teile.Length > 4)
			{
				for (int i = 4; i < teile.Length - 1; i += 2)
					this.KontaktListe.Add(new Kontakt() { Bezeichnung = teile[i], Wert = teile[i + 1] });
			}


		}
		#endregion

		// ***********************************************************************************
		#region properties

		public string Vorname { get; set; }
		public string Nachname { get; set; }
		public string Geschlecht { get; set; } = "d";
		public DateTime GeburtsDatum { get; set; } = DateTime.MinValue;
		public List<Kontakt> KontaktListe { get; set; } = new List<Kontakt>();

		#endregion

		// ***********************************************************************************
		#region public methods

		public override string ToString()
		{
			return $"{this.Vorname} {this.Nachname}";
		}

		public override int GetHashCode()
		{
			int hash = 0;

			hash ^= this.Vorname.GetHashCode();
			hash ^= this.Nachname.GetHashCode();
			hash ^= this.Geschlecht.GetHashCode();

			return hash;
		}

		public void Speichern(StreamWriter writer)
		{
			string tmp = string.Empty;
			foreach (Kontakt kontakt in this.KontaktListe) tmp += kontakt.Speichern();
			writer.WriteLine($"{this.Vorname}\t{this.Nachname}\t{this.Geschlecht}\t{this.GeburtsDatum}\t{tmp}");
		}
		#endregion
	}
}
