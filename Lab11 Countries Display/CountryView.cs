using System;
using Lab11_Countries_Display;
using static System.Net.Mime.MediaTypeNames;

namespace Lab11_Countries_Display
{
	public class CountryView
	{
		//properties
		public Country DisplayCountry { get; set; }

		//constructor
		public CountryView(Country _country)
		{
			DisplayCountry = _country;
		}

		//method
		public void Display(Country c)
		{
			Console.WriteLine(c.Name);
			Console.WriteLine(c.Continent);
			foreach (string s in c.Colors) 
			{
				Console.WriteLine(s);
			}
		}
	}
}



//Property: Public Country DisplayCountry

//Constructor: take in a Country and set to DisplayCountry

//Method: Public void Display() -Print Name, Continent, and Colors from Country DisplayCountry
