using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS2425_Aufgabe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<(string, int)> L = new List<(string, int)>()
            {
                ("Apfel", 15),
                ("Banane", 8),
                ("Fräser", 12),
                ("Kiwi",9),
                ("Pfirsich", 2)
            };
            L.Sort((a, b) => a.Item2.CompareTo(b.Item2));
            label2.Text = print(L);
        }

        //Ignore this part, its only for visualization
        private string print(List<(string, int)> list)
        {
            string result = "L = [";
            for (int i = 0; i < list.Count - 1; i++)
            {
                result += "( '" + list[i].Item1 + "', '" + list[i].Item2 + "'), ";
            }
            result += "( '" + list[list.Count - 1].Item1 + "', '" + list[list.Count - 1].Item2 + "')] ";
            return result;
        }
    }
}
