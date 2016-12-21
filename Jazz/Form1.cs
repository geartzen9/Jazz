using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jazz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Items toevoegen aan Combobox1
            Object translate1 = new Object();
            Object translate2 = new Object();
            translate1 = "Engels > Nederlands";
            translate2 = "Nederlands > Engels";
            comboBox1.Items.Add(translate1);
            comboBox1.Items.Add(translate2);
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/EN-NL.html");
            richTextBox1.Text = webData;

            //Kijken welke talen er zijn geselecteerd.
            if (comboBox1.SelectedIndex == 0)
            {
                webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/EN-NL.html");
            }
            
            else if (comboBox1.SelectedIndex == 1)
            {
                webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/NL-EN.html");
            }

            String[] commands = { "schoonmaken", "afsluiten", "woord:"};

            //Het scherm leegmaken als de gebruiker 'schoonmaken' intypt.
            if (e.KeyCode == Keys.Enter && input.Text == commands[0])
            {
                output.Text = null;
                output.Text += "Het scherm is schoongemaakt.";
                input.Text = null;
            }

            //De applicatie afsluiten als de gebruiker 'afsluiten' intypt.
            else if (e.KeyCode == Keys.Enter && input.Text == commands[1])
            {
                System.Windows.Forms.Application.Exit();

                e.Handled = true;
            }

            //Defineer een woord.
            else if (e.KeyCode == Keys.Enter && input.Text.Contains(commands[2]))
            {
                output.Text += Environment.NewLine;
                string[] getword = input.Text.Split(':');
                string wordToLearn = getword[1];

                foreach (string line in richTextBox1.Lines)
                {
                    if (line.Contains(wordToLearn))
                    {
                        output.Text += line.ToString();
                        output.Text += Environment.NewLine;
                    }
                }
            }

            //Als de speler hoi of hallo zegt, zegt Jazz weer hallo terug op verschillende manieren.
            else if (e.KeyCode == Keys.Enter && input.Text == "hallo" || e.KeyCode == Keys.Enter && input.Text == "hoi")
            {
                Random rand = new Random();
                int num = rand.Next(1, 5);
                String[] choose = { "Hallo!", "Hoi...", "Goeie dag!", "Gegroet!", "Hallo gebruiker!" };
                string choise = choose[num];

                output.Text += Environment.NewLine + choise;
            }

            //Feedback geven als Jazz een woord niet kent.
            else if (e.KeyCode == Keys.Enter && input.Text != commands[0] && input.Text != commands[1] && input.Text != commands[2] && input.Text != "hello" && input.Text != "hi")
            {
                output.Text += Environment.NewLine + "Ik weet niet wat je bedoelt...";
            }

            //Ervoor zorgen dat input leeg wordt en dat je het Windows error sound niet hoort.
            if (e.KeyCode == Keys.Enter)
            {
                input.Text = null;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Focus naar het input field.
        private void Form1_Load(object sender, EventArgs e)
        {
            input.Select();
        }

        //Help form komt als je op deze knop klikt
        private void helpBut_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }

        //Ga naar de webpagina
        private void addWordBut_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gepps.nl/Jazz/addword.html");
        }
    }
}