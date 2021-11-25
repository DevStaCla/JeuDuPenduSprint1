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
        // déclaration du mot à trouver et du nombre de lettres à trouver
        char[] lettres;
        int nbCarac;
        // déclaration du nombre d'essais
        int essais = 10;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// lance la phase 1 du programme (J1 choisit un mot)
        /// </summary>
        private void Phase1()
        {
            // réinitialisation des champs et valeurs
            txtPly1.Text = "";
            txtPly1.Enabled = true;
            btnPly1Confirm.Enabled = true;
            lblInputConfirm.Text = "";
            lblLettersEntered.Text = "";
            lblSecretWord.Text = "";
            lblSecretWord.ForeColor = Color.Black;
            lblWinner.Text = "";
            essais = 10;
            pctPendu.Image = (Image)JeuDuPendu.Properties.Resources.ResourceManager.GetObject("pendu0");
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
        private void Phase2()
        {
            // désactivation du champ et du bouton du J1
            txtPly1.Enabled = false;
            btnPly1Confirm.Enabled = false;
            // activation de la liste et du bouton du J2
            cbbAlphabet.Enabled = true;
            cbbAlphabet.Focus();
            btnPly2Confirm.Enabled = true;
            // initialisation du label du mot à deviner
            for (int i = 0; i < lettres.Length; i++)
            {
                lblSecretWord.Text += "_";
            } 
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
            lettres = new char[mot.Length];
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
                    txtPly1.Text = "";
                    nbCarac = mot.Length;
                    Phase2();
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
            // test si le caractère est bien A-Z
            if (! (cbbAlphabet.SelectedIndex == -1))
            {
                // copie de l'état actuel des lettres devinées par J2
                string strNewSecWord = lblSecretWord.Text;
                // booléen pour dire si lettre est présente ou non
                bool lettrePresente = false;
                // comparaison de la lettre avec celles du mot à deviner
                for (int i = 0; i < lettres.Length; i++)
                {
                    if (cbbAlphabet.SelectedItem.Equals(lettres[i]))
                    {
                        strNewSecWord = strNewSecWord.Substring(0, i) + cbbAlphabet.SelectedItem + lblSecretWord.Text.Substring(i + 1, lettres.Length - i - 1);
                        lettrePresente = true;
                        nbCarac--;
                    }
                }
                // remplacement du mot secret
                lblSecretWord.Text = strNewSecWord;
                // ajout de la lettre à la liste des lettres déjà proposées
                lblLettersEntered.Text += cbbAlphabet.SelectedItem;
                // suppression de la lettre dans la liste Combobox
                cbbAlphabet.Items.Remove(cbbAlphabet.SelectedItem);
                // teste si la lettre a été trouvée au moins une fois
                if (lettrePresente == false)
                {
                    essais--;
                    int nbImage = 10 - essais;
                    pctPendu.Image = (Image)JeuDuPendu.Properties.Resources.ResourceManager.GetObject("pendu" + nbImage);
                }
                // test s'il reste des essais ou non
                if (essais == 0)
                {
                    // désactivation des champs de J2
                    cbbAlphabet.Enabled = false;
                    btnPly2Confirm.Enabled = false;
                    // affichage du mot à deviner
                    lblSecretWord.ForeColor = Color.Red;
                    lblSecretWord.Text = "";
                    for (int i = 0; i < lettres.Length; i++)
                    {
                        lblSecretWord.Text += lettres[i];
                    }
                    // proclamation du vainqueur
                    lblWinner.Text = "Victoire du joueur 1 !";
                }
                // test si toutes les lettres ont été trouvées
                if (nbCarac == 0)
                {
                    // désactivation des champs de J2
                    cbbAlphabet.Enabled = false;
                    btnPly2Confirm.Enabled = false;
                    // proclamation du vainqueur
                    lblWinner.Text = "Victoire du joueur 2 !";
                }
            }            
        }

        private void cbbAlphabet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnPly2Confirm_Click(null, null);
            }
        }

        private void imgRejouer_Click(object sender, EventArgs e)
        {
            Phase1();
        }
    }
}
