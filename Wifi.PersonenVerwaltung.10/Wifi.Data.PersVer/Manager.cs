using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.Data.PersVer
{
	public static class Manager
	{

		public static List<Person> PersonLesen(string fileName)
		{
			List<Person> personList = new List<Person>();
			StreamReader reader = new StreamReader(fileName, Encoding.UTF8);
			while (!reader.EndOfStream) personList.Add(new Person(reader.ReadLine()));
			reader.Close();
			return personList;
		}

		public static void PersonSchreiben(string fileName, List<Person> personList)
		{
			StreamWriter writer = new StreamWriter(fileName, false, Encoding.UTF8);
			foreach (Person person in personList) person.Speichern(writer);
			writer.Close();
		}


	}
}
