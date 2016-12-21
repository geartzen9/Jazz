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

            //Add items to combobox.
            Object translate1 = new Object();
            Object translate2 = new Object();
            translate1 = "English > Dutch";
            translate2 = "Dutch > English";
            comboBox1.Items.Add(translate1);
            comboBox1.Items.Add(translate2);
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            string webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/EN-NL.html");
            richTextBox1.Text = webData;

            //Look which language is selected in the combobox.
            if (comboBox1.SelectedIndex == 0)
            {
                webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/EN-NL.html");
            }
            
            else if (comboBox1.SelectedIndex == 1)
            {
                webData = wc.DownloadString("http://www.gepps.nl/Jazz/language/NL-EN.html");
            }

            String[] commands = { "clear", "quit", "word:"};

            //Clear screen when user types "clear".
            if (e.KeyCode == Keys.Enter && input.Text == commands[0])
            {
                output.Text = null;
                output.Text += "Het scherm is schoongemaakt.";
                input.Text = null;
            }

            //Quit application when user types "quit".
            else if (e.KeyCode == Keys.Enter && input.Text == commands[1])
            {
                System.Windows.Forms.Application.Exit();

                e.Handled = true;
            }

            //Translate a word.
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

            //If the user types in "hi" or "hello", give feedback.
            else if (e.KeyCode == Keys.Enter && input.Text == "hello" || e.KeyCode == Keys.Enter && input.Text == "hi")
            {
                Random rand = new Random();
                int num = rand.Next(1, 5);
                String[] choose = { "Hello!", "Hi...", "Good day!", "Greatings!", "Hello user!" };
                string choise = choose[num];

                output.Text += Environment.NewLine + choise;
            }

            //Give feedback when Jazz doesn't know a command.
            else if (e.KeyCode == Keys.Enter && input.Text != commands[0] && input.Text != commands[1] && input.Text != commands[2] && input.Text != "hello" && input.Text != "hi")
            {
                output.Text += Environment.NewLine + "I don't know what you meen...";
            }

            //Clear input box when user presses enter.
            if (e.KeyCode == Keys.Enter)
            {
                input.Text = null;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        //Focus to input box.
        private void Form1_Load(object sender, EventArgs e)
        {
            input.Select();
        }

        //Help form appears when user pressed helpBut.
        private void helpBut_Click(object sender, EventArgs e)
        {
            helpForm help = new helpForm();
            help.Show();
        }

        //Go to webpage to add a word. (doesn't work yet)
        private void addWordBut_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
    }
}