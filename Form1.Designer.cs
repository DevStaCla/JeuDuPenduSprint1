﻿
namespace JeuDuPendu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbbAlphabet = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.txtPly1 = new System.Windows.Forms.TextBox();
            this.grpLetters = new System.Windows.Forms.GroupBox();
            this.btnPly2Confirm = new System.Windows.Forms.Button();
            this.btnPly1Confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMysteryWord = new System.Windows.Forms.Label();
            this.lblInputConfirm = new System.Windows.Forms.Label();
            this.lblLettersEntered = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(338, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cbbAlphabet
            // 
            this.cbbAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbAlphabet.FormattingEnabled = true;
            this.cbbAlphabet.Location = new System.Drawing.Point(194, 113);
            this.cbbAlphabet.Name = "cbbAlphabet";
            this.cbbAlphabet.Size = new System.Drawing.Size(40, 26);
            this.cbbAlphabet.TabIndex = 3;
            this.cbbAlphabet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbAlphabet_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rejouer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblWinner.Location = new System.Drawing.Point(49, 368);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(264, 31);
            this.lblWinner.TabIndex = 5;
            this.lblWinner.Text = "Victoire du joueur X !";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(21, 14);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(101, 24);
            this.lblPlayer1.TabIndex = 6;
            this.lblPlayer1.Text = "JOUEUR 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(21, 90);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(101, 24);
            this.lblPlayer2.TabIndex = 7;
            this.lblPlayer2.Text = "JOUEUR 2";
            // 
            // txtPly1
            // 
            this.txtPly1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPly1.Location = new System.Drawing.Point(194, 40);
            this.txtPly1.Name = "txtPly1";
            this.txtPly1.Size = new System.Drawing.Size(162, 24);
            this.txtPly1.TabIndex = 8;
            this.txtPly1.Click += new System.EventHandler(this.txtPly1_Click);
            this.txtPly1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPly1_KeyPress);
            // 
            // grpLetters
            // 
            this.grpLetters.Controls.Add(this.lblLettersEntered);
            this.grpLetters.Location = new System.Drawing.Point(25, 277);
            this.grpLetters.Name = "grpLetters";
            this.grpLetters.Size = new System.Drawing.Size(296, 55);
            this.grpLetters.TabIndex = 9;
            this.grpLetters.TabStop = false;
            this.grpLetters.Text = "Lettres déjà proposées";
            // 
            // btnPly2Confirm
            // 
            this.btnPly2Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPly2Confirm.Location = new System.Drawing.Point(240, 113);
            this.btnPly2Confirm.Name = "btnPly2Confirm";
            this.btnPly2Confirm.Size = new System.Drawing.Size(68, 26);
            this.btnPly2Confirm.TabIndex = 10;
            this.btnPly2Confirm.Text = "Valider";
            this.btnPly2Confirm.UseVisualStyleBackColor = true;
            this.btnPly2Confirm.Click += new System.EventHandler(this.btnPly2Confirm_Click);
            // 
            // btnPly1Confirm
            // 
            this.btnPly1Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPly1Confirm.Location = new System.Drawing.Point(362, 40);
            this.btnPly1Confirm.Name = "btnPly1Confirm";
            this.btnPly1Confirm.Size = new System.Drawing.Size(68, 25);
            this.btnPly1Confirm.TabIndex = 11;
            this.btnPly1Confirm.Text = "Valider";
            this.btnPly1Confirm.UseVisualStyleBackColor = true;
            this.btnPly1Confirm.Click += new System.EventHandler(this.btnPly1Confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Entre le mot à deviner :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Propose une lettre :";
            // 
            // lblMysteryWord
            // 
            this.lblMysteryWord.AutoSize = true;
            this.lblMysteryWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMysteryWord.Location = new System.Drawing.Point(51, 211);
            this.lblMysteryWord.Name = "lblMysteryWord";
            this.lblMysteryWord.Size = new System.Drawing.Size(230, 24);
            this.lblMysteryWord.TabIndex = 14;
            this.lblMysteryWord.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _";
            this.lblMysteryWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInputConfirm
            // 
            this.lblInputConfirm.AutoSize = true;
            this.lblInputConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputConfirm.ForeColor = System.Drawing.Color.Red;
            this.lblInputConfirm.Location = new System.Drawing.Point(433, 46);
            this.lblInputConfirm.Name = "lblInputConfirm";
            this.lblInputConfirm.Size = new System.Drawing.Size(0, 16);
            this.lblInputConfirm.TabIndex = 15;
            // 
            // lblLettersEntered
            // 
            this.lblLettersEntered.AutoSize = true;
            this.lblLettersEntered.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettersEntered.Location = new System.Drawing.Point(12, 26);
            this.lblLettersEntered.Name = "lblLettersEntered";
            this.lblLettersEntered.Size = new System.Drawing.Size(0, 18);
            this.lblLettersEntered.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 423);
            this.Controls.Add(this.lblInputConfirm);
            this.Controls.Add(this.lblMysteryWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPly1Confirm);
            this.Controls.Add(this.btnPly2Confirm);
            this.Controls.Add(this.grpLetters);
            this.Controls.Add(this.txtPly1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbAlphabet);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Jeu du pendu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpLetters.ResumeLayout(false);
            this.grpLetters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbbAlphabet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.TextBox txtPly1;
        private System.Windows.Forms.GroupBox grpLetters;
        private System.Windows.Forms.Button btnPly2Confirm;
        private System.Windows.Forms.Button btnPly1Confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMysteryWord;
        private System.Windows.Forms.Label lblInputConfirm;
        private System.Windows.Forms.Label lblLettersEntered;
    }
}

