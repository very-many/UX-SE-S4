using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS2425_Aufgabe_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var variable = "Dumm";
            variable.GetType();
            if (variable.GetType() == typeof(string))
            {
                label2.Text = "Zeichenkette";
            }
            else if (variable.GetType() == typeof(int))
            {
                label2.Text = "Ganzzahl";
            }
            else
            {
                label2.Text = variable.GetType().ToString();
            }
        }
    }
}
