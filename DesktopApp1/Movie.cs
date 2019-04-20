using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Movie
    {
        private string _title;
        private string _year;
        private string _runtime;
        private string _genre;
        private string _actors;
        private string _plot;
        private string _value;
        private string _img;

        public string Title { get => _title; set => _title = value; }
        public string Year { get => _year; set => _year = value; }
        public string Runtime { get => _runtime; set => _runtime = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string Actors { get => _actors; set => _actors = value; }
        public string Plot { get => _plot; set => _plot = value; }
        public string Value { get => _value; set => _value = value; }
        public string Img { get => _img; set => _img = value; }

        public Movie()
        {
        }
        public Movie(string content)
        {

            //getInfoFromOMDBA(content);
            Title = findmovieinformation("Title", content);
            Year = findmovieinformation("Year", content);
            Img = findmovieinformation("Poster", content);
            //Runtime = findmovieinformation("Runtime", content);
            //Genre = findmovieinformation("Genre", content);
            //Actors = findmovieinformation("Actors", content);
            //Plot = findmovieinformation("Plot", content);
            //Value = findmovieinformation("Value", content);

        }

        /// <summary>
        /// Function that collect data fromOMDBA about movie 
        /// </summary>
        /// <param name="title">Movies title</param>
        /// <returns>true if gathering information was successful otherwise false</returns>
        public bool getInfoFromOMDBA(string title)
        {
            WebClient client = new WebClient();
            Uri siteUri = new Uri(makeurl(title));

            string content = client.DownloadString(siteUri);
            if (findmovieinformation("Error", content) == "")
            {
                Title = findmovieinformation("Title", content);
                Year = findmovieinformation("Year", content);
                Runtime = findmovieinformation("Runtime", content);
                Genre = findmovieinformation("Genre", content);
                Actors = findmovieinformation("Actors", content);
                Plot = findmovieinformation("Plot", content);
                Value = findmovieinformation("Value", content);
                Img = findmovieinformation("Poster", content);
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Function make URL to given title 
        /// </summary>
        /// <param name="title"></param>
        /// <returns>String that is a URL to given title information </returns>
        private string makeurl(string title)
        {
            title.Replace(" ", "_");
            string temp = "http://www.omdbapi.com/?t=" + title + "&apikey=1b3b7f47";
            return temp;
        }
        /// <summary>
        /// Function which search for key into string from database and returns information about certain attribute 
        /// </summary>
        /// <param name="key">attribute that we are searching for</param>
        /// <param name="httprespond">content from database with all attributes</param>
        /// <returns>Information about given attribute of movie</returns>
        private string findmovieinformation(string key, string httprespond)
        {
            string temp = httprespond.Substring(httprespond.IndexOf(key) + key.Length + 3);
            temp = temp.Remove(temp.IndexOf('"'));

            return temp;
        }

     
        /// <summary>
        /// Function overriing ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString() 
        {
            string title = "\nTitle: " + Title;
            string year = "\nYear: " + Year ;
            string runtime = "\nRuntime:" + Runtime ;
            string genre = "\nGenre: "+Genre;
            string actors = "\nActors: "+Actors;
            string plot = "\nPlot: "+Plot;
            string value = "\nValue: "+Value;
            string img = "\nPoster: " + Img;
            return title + year + runtime + genre + actors + plot + value+img;
        }
    }
}
