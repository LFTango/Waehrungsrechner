using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Währungsrechner
{

	//JsonProperty "serialized" die werte mit dem exakten namen aus der heruntergeladenen JSON Datei, und entnimmt die passenden Werte 

	class Antwort
	{
		//[JsonProperty("disclaimer")] public string Disclaimer {get; set;}
		//[JsonProperty("license")] public string License { get; set; }
		//[JsonProperty("timestamp")] public string Timestamp { get; set; }
		//[JsonProperty("base")] public string Base { get; set; }
		[JsonProperty("rates")] public Rates Rates { get; set; } 

	}

	class Rates
	{
		[JsonProperty("GBP")] public double Pfund { get; set; }
		[JsonProperty("INR")] public double Rupie { get; set; }
		[JsonProperty("JPY")] public double Yen { get; set; }
		[JsonProperty("RUB")] public double Rubel { get; set; }
		[JsonProperty("EUR")] public double Euro { get; set; }
	}
}
