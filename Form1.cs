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

        /// <summary>
        /// lance la phase 1 du programme (J1 choisit un mot)
        /// </summary>
        private void Phase1()
        {
            // initialisation de la liste contenant l'alphabet
            RemplitCombo(cbbAlphabet);
            // désactivation de la liste et du bouton du J2
            cbbAlphabet.Enabled = false;
            btnPly2Confirm.Enabled = false;
            // focus sur le champ du J1
            txtPly1.Select();
        }

        /// <summary>
        /// lance la phase 2 du programme (J2 devine le mot)
        /// </summary>
        private void Phase2(char[] lettres)
        {
            // désactivation du champ et du bouton du J1
            txtPly1.Enabled = false;
            btnPly1Confirm.Enabled = false;
            // activation de la liste et du bouton du J2
            cbbAlphabet.Enabled = true;
            cbbAlphabet.Focus();
            btnPly2Confirm.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Phase1();
        }

        private void RemplitCombo(ComboBox liste)
        {
            liste.Items.Clear();
            for (int i = 0; i < 26; i++)
            {
                liste.Items.Add((char)('A' + i));
            }
        }

        private void btnPly1Confirm_Click(object sender, EventArgs e)
        {
            String mot = txtPly1.Text.ToUpper();
            char[] lettres = new char[mot.Length];
            int i = 0;
            bool correct = true;
            if (mot.Length == 0 || mot.Length > 15)
            {
                lblInputConfirm.ForeColor = Color.Red;
                lblInputConfirm.Text = "Tape entre 1 et 15 lettres";
            }
            else
            {
                while (correct && i < mot.Length)
                {
                    int test = mot[i];
                    if (mot[i] >= 65 && mot[i] <= 90)
                    {
                        lettres[i] = mot[i];
                        i++;
                    }
                    else
                    {
                        correct = false;
                    }
                }
                if (correct)
                {
                    lblInputConfirm.ForeColor = Color.Green;
                    lblInputConfirm.Text = "Mot enregistré";
                    Phase2(lettres);
                }
                else
                {
                    lblInputConfirm.ForeColor = Color.Red;
                    lblInputConfirm.Text = "Caractère interdit";
                }
            }            
        }

        private void txtPly1_Click(object sender, EventArgs e)
        {
            lblInputConfirm.Text = "";
        }

        private void txtPly1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnPly1Confirm_Click(null, null);
            }
            else
            {
                txtPly1_Click(null, null);
            }
        }

        private void btnPly2Confirm_Click(object sender, EventArgs e)
        {
            lblLettersEntered.Text += cbbAlphabet.SelectedItem;
            cbbAlphabet.Items.Remove(cbbAlphabet.SelectedItem);
        }

        private void cbbAlphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnPly2Confirm_Click(null, null);
            }
        }
    }
}
