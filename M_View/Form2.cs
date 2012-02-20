using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M_View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Form1 mainForm;
        private static string aboutText = "G_View (Game Viewer)";
        private static string aboutText1 = "Version 1.0a";
        private static string aboutText2 = "Simple Program that parses Movie information from Imdb and displays it.";
        private static string aboutText3 = "Developed by Cathal McNally (mcnallycathal@yahoo.ie)";
        private static string aboutText4 = "Using IMDb.cs by Abhinay Rathore (http://www.AbhinayRathore.com)";


        public Form2(Form1 mainForm)
        {

            this.mainForm = mainForm;
            InitializeComponent();
            aboutTextBox.Text = aboutText + Environment.NewLine + Environment.NewLine + aboutText1 + Environment.NewLine + Environment.NewLine + aboutText2 + Environment.NewLine + Environment.NewLine + aboutText3 + Environment.NewLine + Environment.NewLine + aboutText4;
            
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
