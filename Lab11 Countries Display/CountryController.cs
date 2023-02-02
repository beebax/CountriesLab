using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace Lab11_Countries_Display
{
	public class CountryController
	{
        //properties
        //pretend this is a database
        List<Country> CountryDb = new List<Country>()
        {
            new Country("Belize", "North America", new List<string>(){"red", "white", "blue"}),
            new Country("Mexico", "North America", new List<string>(){"red", "white", "blue"}),
            new Country("Suriname", "South America", new List<string>(){"red", "white", "blue"}),
            new Country("Pakistan", "Asia",new List<string>(){"red", "white", "blue"}),
            new Country("Lithuania", "Europe", new List<string>(){"red", "white", "blue"}),
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display(c);
        }


        //Upon getting the country out of CountryDb,
        //pass that country along to the CountryAction() method

        public void WelcomeAction()
        {
            CountryListView listview = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.Please select a country from the following list:");

            listview.Display();

            bool working;
            bool confirming;

            while (working = true)
            {
                Console.Write("Please select a country by index number: ");
                int countryChoice = int.Parse(Console.ReadLine().ToLower().Trim());

                CountryAction(CountryDb[countryChoice]);

                while (confirming = true)
                {
                    Console.WriteLine("Would you like to learn about another country? Y/N");
                    string userCont = Console.ReadLine().ToLower().Trim();
                    if (userCont == "y")
                    {
                        confirming = false;
                        break;
                    }
                    else if (userCont == "n")
                    {
                        Console.WriteLine("Thank you, goodbye.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                   
                }

            }
        }
    }
}

//Enum.Parse<ConsoleColor>(color)

//Property: List<Country> CountryDb - this stands in for our country database.

//Method: Public void CountryAction(Country c)
//Take in a Country model, pass the model into the CountryView constructor
//Call DisplayCountry on your CountryView object.

//Method: Public void WelcomeAction()
//No parameter
//Pass CountryDb into CountryListView

//Then print welcome message.
//Then call Display() on CountryListView
//Then allow user to select a country by index.
//Get country from CountryDb
//Pass to CountryAction() ethod
//Ask if user wants to learn about another country.
