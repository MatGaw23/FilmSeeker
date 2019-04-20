using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class FilmSeeker : Form
    {
        MovieSearchList list = new MovieSearchList();
        public FilmSeeker()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.GetMovieSearchfromIMDA(search.Text);
            
            Movie m = new Movie();
            m.getInfoFromOMDBA(list.List[0].Title);
            
            valuebox.Visible = true;
            star.Visible = true;
            titlebox.Visible = true;
            yearbox.Visible = true;
            runtimebox.Visible = true;
            genrebox.Visible = true;
            actorsbox.Visible = true;
            plotbox.Visible = true;
            valuebox.Visible = true;


            titlebox.Text = "Title: " + m.Title;
            yearbox.Text = "Year: " + m.Year;
            runtimebox.Text = "Runtime: " + m.Runtime;
            genrebox.Text = "Genre: " + m.Genre;
            actorsbox.Text = "Actors: " + m.Actors;
            plotbox.Text = "Plot: " + m.Plot;
            valuebox.Text = m.Value;
            pictureBox1.Load(m.Img);
        }

        
       
    }
}
