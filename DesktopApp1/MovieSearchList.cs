using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using ConsoleApp1;

namespace ConsoleApp1
{
    class MovieSearchList
    {
        private List<Movie> _list;

        internal List<Movie> List { get => _list; set => _list = value; }

        public MovieSearchList ()
        {
            List = new List<Movie>();
        }

        private string makesearchurl(string title)
        {
            title.Replace(" ", "_");
            string temp = "http://www.omdbapi.com/?s=" + title + "&apikey=1b3b7f47";
            return temp;
        }

        public void GetMovieSearchfromIMDA(string keysearch)
        {
            List.Clear();
            WebClient client = new WebClient();
            Uri siteUri = new Uri(makesearchurl(keysearch));
            
            string content = client.DownloadString(siteUri);
  
            content = content.Substring(11);
            while (content.IndexOf("]") > 5)
            {
                string temporary = content;
                int indexofelement = temporary.IndexOf("}");
                temporary=temporary.Remove(indexofelement);
                //Console.WriteLine(temporary);
                List.Add(new Movie(temporary));
                content = content.Substring(indexofelement + 1);
            }
        }

       
    }

}
