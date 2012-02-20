using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace M_View
{
    public partial class Form1 : Form
    {

        private static string currentDir = Directory.GetCurrentDirectory();
        private static string[] paths = Directory.GetDirectories(currentDir);
        private static int counter = -1;
        private static bool downloaded = false;
        private static bool error = false;
        private static string movieName;
        private static string statWorking = "Status: Downloading ";
        private static string statLoaded = "Status: Loaded ";
        private static string statError = "Error: Try Reloading and Check that the folder name is an actual Movie name!";

        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons and menu items
        private void nextBtn_Click(object sender, EventArgs e)
        {
            this.nextSelection();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            this.previousSelection();
        }

        private void reloadBtn_Click(object sender, EventArgs e)
        {
            this.reloadSelection();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.nextSelection();
        }

        private void previousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.previousSelection();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reloadSelection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        #endregion

        private void nextSelection()
        {
            error = false;
            downloaded = true;
            counter++;
            for (int i = 0; i < paths.Length; i++)
            {
                if (counter == i)
                {

                    movieName = new DirectoryInfo(paths[i]).Name;
                    if (downloaded)
                    {
                        status.Text = statWorking + "| " + movieName + " |";
                    }
                    IMDb imdb = new IMDb(movieName, true);
                    titleTb.Text = imdb.Title;
                    try
                    {
                        filmImgSrc.Load(imdb.Poster);
                    }
                    catch (Exception u)
                    {
                        MessageBox.Show("Couldn't load the Movie image!\nTry the Reload Button or make sure the folder name is an actual movie name!\n\nException Text : \n" + u.ToString(), "Image failed to load! Soz :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        error = true;
                    }
                }
                else if (counter >= paths.Length)
                {
                    counter = paths.Length - 1;
                }
            }
            downloaded = false;
            if (downloaded == false)
            {
                status.Text = statLoaded + "| " + movieName + " |";
            }
            if (error == true)
            {
                status.Text = statError;
            }
        }

        private void previousSelection()
        {
            error = false;
            downloaded = true;
            if (counter <= 0)
            {
                counter = 1;
            }

            counter--;

            for (int i = counter; i >= 0; i--)
            {
                if (counter == i)
                {

                    movieName = new DirectoryInfo(paths[i]).Name;
                    if (downloaded)
                    {
                        status.Text = statWorking + "| " + movieName + " |";
                    }
                    IMDb imdb = new IMDb(movieName, true);
                    titleTb.Text = imdb.Title;
                    try
                    {
                        filmImgSrc.Load(imdb.Poster);
                    }
                    catch (Exception u)
                    {
                        MessageBox.Show("Couldn't load the Movie image!\nTry the Reload Button or make sure the folder name is an actual movie name!\n\nException Text : \n" + u.ToString(), "Image failed to load! Soz :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        error = true;
                    }
                }
            }
            downloaded = false;
            if (downloaded == false)
            {
                status.Text = statLoaded + "| " + movieName + " |";
            }
            if (error == true)
            {
                status.Text = statError;
            }
        }

        private void reloadSelection()
        {
            error = false;
            downloaded = true;
            movieName = new DirectoryInfo(paths[counter]).Name;
            if (downloaded)
            {
                status.Text = statWorking + "| " + movieName + " |";
            }
            IMDb imdb = new IMDb(movieName, true);
            titleTb.Text = imdb.Title;

            try
            {
                filmImgSrc.Load(imdb.Poster);
            }
            catch (Exception u)
            {
                MessageBox.Show("Couldn't load the Movie image!\nTry the Reload Button or make sure the folder name is an actual movie name!\n\nException Text : \n" + u.ToString(), "Image failed to load! Soz :(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                error = true;
            }
            downloaded = false;
            if (downloaded == false)
            {
                status.Text = statLoaded + "| " + movieName + " |";
            }
            if (error == true)
            {
                status.Text = statError;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 subForm = new Form2(this);
            subForm.Show();
        }
    }
}
