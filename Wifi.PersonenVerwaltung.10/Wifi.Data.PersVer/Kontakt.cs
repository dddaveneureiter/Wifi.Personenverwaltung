using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Data.PersVer
{
	public class Kontakt
	{

		public string Bezeichnung { get; set; }
		public string Wert { get; set; }

		// Kurzform von 
		// public string Speichern()
		// {
		//		return $"{this.Bezeichnung}\t{this.Wert}";
		// }
		public string Speichern() => $"{this.Bezeichnung}\t{this.Wert}\t";
	}
}
