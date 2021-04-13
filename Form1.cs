using System;
using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Währungsrechner
{
	public partial class Forms1 : Form
	{
		string vonWährungSymbol, nachWährungSymbol; //String für Switch. Gibt am ende die Symbole an 
		const string apistringurl = "https://openexchangerates.org/api/latest.json?app_id=4e829938db044e74ad613c10d76cb10c&symbols=GBP,EUR,JPY,INR,RUB"; //URL die auf die Schnittstelle zugreift - - - &base=EUR Geht nicht weil free version

		public string Get(string uri) //Magic get Methode. Ladet eine JSON herunter mit Werten zur berechnung der währungen. Wird später in der class Antwort weiterverarbeitet
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
			request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate; //Kompressiert die datei die man über die webrequest erhählt

			using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) //returned die antwort auf die request in einer variable
			using (Stream stream = response.GetResponseStream()) //Erstellt einen byte stream aus der response
			using (StreamReader reader = new StreamReader(stream)) //Ließt den byte stream aus und pakt diese als string in die variable
			{
				return reader.ReadToEnd(); //Der ausgelesene string wird returned
			}
		}
		public Forms1() //Die comboboxen starten mit einem selektierten wert
		{
			InitializeComponent();
			comboVon.SelectedIndex = 0;
			comboNach.SelectedIndex = 5;
		}

		private void label1_Click(object sender, EventArgs e)//sollte gelöscht werden
		{

		}

		private void BerechnungButton(object sender, EventArgs e) //Was ausgeführt wird wenn man den einziegen Button des programms drückt
		{
			//	MessageBox.Show("f"); //test
			//Summe = double.TryParse(summeTBox.Text, out double result); //Wandelt die in die erste textbox eingetragene Summe in Double um
			if (!double.TryParse(summeTBox.Text, out double sum))
			{
				return;
			}

			string von = comboVon.SelectedItem.ToString(); //Der ausgewählte wert in den beiden Comboboxen wird ausgelesen
			string zu = comboNach.SelectedItem.ToString();

			string jsonstring = Get(apistringurl); //Deklariert jsonstring. jsonstring beinhaltet die heruntergeladenen+übersetzten daten.

			Antwort deserializedProduct = JsonConvert.DeserializeObject<Antwort>(jsonstring); //Magic code. "deserialized" die zu einem string verarbeitete JSON datei und macht die werte verfügbar für die weiterberechnung

			double from = 0, to = 0; //Deklariert doubles, die werte je nach ausgewählter währung bekommen

			switch (von) //zuweisung der ausgewählten VON währung
			{
				case "Euro":
					from = deserializedProduct.Rates.Euro; //Deklariert eine variable die wert aus Antwort.Rates.Euro bekommt
					vonWährungSymbol = "€";
					break;
				case "Pfund":
					from = deserializedProduct.Rates.Pfund;
					vonWährungSymbol = "£";
					break;
				case "Dollar":
					from = 1;
					vonWährungSymbol = "$";
					break;
				case "Yen":
					from = deserializedProduct.Rates.Yen;
					vonWährungSymbol = "¥";
					break;
				case "Rupie":
					from = deserializedProduct.Rates.Rupie;
					vonWährungSymbol = "₹";
					break;
				case "Rubel":
					from = deserializedProduct.Rates.Rubel;
					vonWährungSymbol = "₽";
					break;
			}

			switch (zu) //zuweisung der ausgewählten ZU währung
			{
				case "Euro":
					to = deserializedProduct.Rates.Euro;
					nachWährungSymbol = "€";
					break;
				case "Pfund":
					to = deserializedProduct.Rates.Pfund;
					nachWährungSymbol = "£";
					break;
				case "Dollar":
					to = 1;
					nachWährungSymbol = "$";
					break;
				case "Yen":
					to = deserializedProduct.Rates.Yen;
					nachWährungSymbol = "¥";
					break;
				case "Rupie":
					to = deserializedProduct.Rates.Rupie;
					nachWährungSymbol = "₹";
					break;
				case "Rubel":
					to = deserializedProduct.Rates.Rubel;
					nachWährungSymbol = "₽";
					break;
			}

			double erg = sum / from * to; //Berechnet das ergebnis

			ErgLabel.Text = sum + vonWährungSymbol + $" sind umgerechnet {Math.Round(erg, 2)}" + nachWährungSymbol; //fügt das ergebnis in das ergebnislabel hinzu und runded dieses auf 2 stellen hinter dem komma


		//	const double euro = 1; //Basiswert
		//	const double pfund = 1.15438;
		//	const double dollar = 0.839807;
		//	const double yen = 0.00768163;
		//	const double rupie = 0.0111971;
		//	const double rubel = 0.0108605;

			//	double from = 0, to = 0;

			//	switch (von)
			//	{
			//		case "Euro":
			//			from = euro;
			//			break;
			//		case "Pfund":
			//			from = pfund;
			//			break;
			//		case "Dollar":
			//			from = dollar;
			//			break;
			//		case "Yen":
			//			from = yen;
			//			break;
			//		case "Rupie":
			//			from = rupie;
			//			break;
			//		case "Rubel":
			//			from = rubel;
			//			break;
			//	}

			//	switch (zu)
			//	{
			//		case "Euro":
			//			to = euro;
			//			break;
			//		case "Pfund":
			//			to = pfund;
			//			break;
			//		case "Dollar":
			//			to = dollar;
			//			break;
			//		case "Yen":
			//			to = yen;
			//			break;
			//		case "Rupie":
			//			to = rupie;
			//			break;
			//		case "Rubel":
			//			to = rubel;
			//			break;
			//	}

			//	double erg = sum * from / to;

			//	ErgLabel.Text = $"x y sind umgerechnet {Math.Round(erg,2)}";  
			//
		}
	}
}
