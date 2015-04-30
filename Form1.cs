using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {

            //Add something like this:
            if (AskBox.Text == "How are you?")
            {
                AskBox.Clear();
                OutputBox.AppendText("I am fine.\r\n");
            }

            //Or add little games like this:
            if (AskBox.Text == "Rock!")
            {
                switch(random.Next(3))
                {
                    case 0:
                        AskBox.Clear();
                        OutputBox.AppendText("Rock! A draw.\r\n");
                        break;
                    case 1:
                        AskBox.Clear();
                        OutputBox.AppendText("Paper! I win.\r\n");
                        break;
                    case 2:
                        AskBox.Clear();
                        OutputBox.AppendText("Scissors! You win.\r\n");
                        break;
                }
            }

            if (AskBox.Text == "Paper!")
            {
                switch (random.Next(3))
                {
                    case 0:
                        AskBox.Clear();
                        OutputBox.AppendText("Rock! You win.\r\n");
                        break;
                    case 1:
                        AskBox.Clear();
                        OutputBox.AppendText("Paper! A draw.\r\n");
                        break;
                    case 2:
                        AskBox.Clear();
                        OutputBox.AppendText("Scissors! I win.\r\n");
                        break;
                }
            }

            if (AskBox.Text == "Scissors!")
            {
                switch (random.Next(3))
                {
                    case 0:
                        AskBox.Clear();
                        OutputBox.AppendText("Rock! I win.\r\n");
                        break;
                    case 1:
                        AskBox.Clear();
                        OutputBox.AppendText("Paper! You win.\r\n");
                        break;
                    case 2:
                        AskBox.Clear();
                        OutputBox.AppendText("Scissors! A draw.\r\n");
                        break;
                }
            }
        }
    }
}
