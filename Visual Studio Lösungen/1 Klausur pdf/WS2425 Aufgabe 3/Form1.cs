using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS2425_Aufgabe_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //object weil Liste verschiedene Typen nehmen können soll
            Dictionary<string, List<object>> d = new Dictionary<string, List<object>>()
            {
                { "a", new List<object> { 1, 2, 3 } },
                { "b", new List<object> { 3, "p" } },
                { "c", new List<object> { 8 } }
            };

            label2.Text = "Das Dictionary hat " + anzahlWertWoerterbuch(d).ToString() + " Werte den Schlüsseln zugeordnet.";
        }

        //hier ist der wichtige code
        private int anzahlWertWoerterbuch(Dictionary<string, List<object>> d)
        {
            int sum = 0;

            foreach (var entry in d)
            {
                if (entry.Value != null)
                {
                    sum += entry.Value.Count;
                }
            }

            return sum;
        }
    }
}
