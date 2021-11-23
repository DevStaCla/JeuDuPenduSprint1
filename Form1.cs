using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RemplitCombo(cbbAlphabet);
        }

        static void RemplitCombo(ComboBox liste)
        {
            liste.Items.Clear();
            for (int i = 0; i < 26; i++)
            {
                liste.Items.Add((char)('A' + i));
            }
        }
    }
}
