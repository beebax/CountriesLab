using System;
using static System.Formats.Asn1.AsnWriter;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace Lab11_Countries_Display
{
    public class CountryListView
    {
        //properties
        public List<Country> Countries { get; set; }


        //constructor
        public CountryListView(List<Country> _countries)
        {
            Countries = _countries;
        }

        //methods
        public void Display()
        {
            foreach (Country c in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(c)}  {c.Name}");
            }
        }
    }
}


//Property: Public List<Country> Countries - store parameter from constructor here

//Constructor: take a list of countries

//Method: Public void Display() - Print the name of each country in the list + their index num