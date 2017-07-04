namespace Compta
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
            this.prefixe = new System.Windows.Forms.TextBox();
            this.numFiche = new System.Windows.Forms.NumericUpDown();
            this.dateOperation = new System.Windows.Forms.DateTimePicker();
            this.gpeType = new System.Windows.Forms.GroupBox();
            this.isDepense = new System.Windows.Forms.RadioButton();
            this.isRecette = new System.Windows.Forms.RadioButton();
            this.gpePaiement = new System.Windows.Forms.GroupBox();
            this.isCarte = new System.Windows.Forms.RadioButton();
            this.isEspeces = new System.Windows.Forms.RadioButton();
            this.isCheque = new System.Windows.Forms.RadioButton();
            this.isVirement = new System.Windows.Forms.RadioButton();
            this.numPaiement = new System.Windows.Forms.TextBox();
            this.montant = new System.Windows.Forms.TextBox();
            this.beneficiaire = new System.Windows.Forms.TextBox();
            this.gpeDetails = new System.Windows.Forms.GroupBox();
            this.categorie1 = new System.Windows.Forms.ComboBox();
            this.designation1 = new System.Windows.Forms.TextBox();
            this.sousMontant1 = new System.Windows.Forms.TextBox();
            this.categorie2 = new System.Windows.Forms.ComboBox();
            this.designation2 = new System.Windows.Forms.TextBox();
            this.sousMontant2 = new System.Windows.Forms.TextBox();
            this.categorie3 = new System.Windows.Forms.ComboBox();
            this.designation3 = new System.Windows.Forms.TextBox();
            this.sousMontant3 = new System.Windows.Forms.TextBox();
            this.categorie4 = new System.Windows.Forms.ComboBox();
            this.designation4 = new System.Windows.Forms.TextBox();
            this.sousMontant4 = new System.Windows.Forms.TextBox();
            this.categorie5 = new System.Windows.Forms.ComboBox();
            this.designation5 = new System.Windows.Forms.TextBox();
            this.sousMontant5 = new System.Windows.Forms.TextBox();
            this.bCreerFiche = new System.Windows.Forms.Button();
            this.bAjoutCompta = new System.Windows.Forms.Button();
            this.bRAZ = new System.Windows.Forms.Button();
            this.bImportFiche = new System.Windows.Forms.Button();
            this.bImprimerFiche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFiche)).BeginInit();
            this.gpeType.SuspendLayout();
            this.gpePaiement.SuspendLayout();
            this.gpeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // prefixe
            // 
            this.prefixe.Location = new System.Drawing.Point(204, 30);
            this.prefixe.Name = "prefixe";
            this.prefixe.Size = new System.Drawing.Size(38, 20);
            this.prefixe.TabIndex = 0;
            this.prefixe.Text = "1617";
            // 
            // numFiche
            // 
            this.numFiche.Location = new System.Drawing.Point(249, 29);
            this.numFiche.Name = "numFiche";
            this.numFiche.Size = new System.Drawing.Size(50, 20);
            this.numFiche.TabIndex = 1;
            // 
            // dateOperation
            // 
            this.dateOperation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOperation.Location = new System.Drawing.Point(322, 29);
            this.dateOperation.Name = "dateOperation";
            this.dateOperation.Size = new System.Drawing.Size(107, 20);
            this.dateOperation.TabIndex = 2;
            // 
            // gpeType
            // 
            this.gpeType.Controls.Add(this.isRecette);
            this.gpeType.Controls.Add(this.isDepense);
            this.gpeType.Location = new System.Drawing.Point(49, 90);
            this.gpeType.Name = "gpeType";
            this.gpeType.Size = new System.Drawing.Size(102, 100);
            this.gpeType.TabIndex = 3;
            this.gpeType.TabStop = false;
            this.gpeType.Text = "Type d\'opération";
            // 
            // isDepense
            // 
            this.isDepense.AutoSize = true;
            this.isDepense.Location = new System.Drawing.Point(7, 29);
            this.isDepense.Name = "isDepense";
            this.isDepense.Size = new System.Drawing.Size(68, 17);
            this.isDepense.TabIndex = 0;
            this.isDepense.TabStop = true;
            this.isDepense.Text = "Dépense";
            this.isDepense.UseVisualStyleBackColor = true;
            // 
            // isRecette
            // 
            this.isRecette.AutoSize = true;
            this.isRecette.Location = new System.Drawing.Point(7, 53);
            this.isRecette.Name = "isRecette";
            this.isRecette.Size = new System.Drawing.Size(63, 17);
            this.isRecette.TabIndex = 1;
            this.isRecette.TabStop = true;
            this.isRecette.Text = "Recette";
            this.isRecette.UseVisualStyleBackColor = true;
            // 
            // gpePaiement
            // 
            this.gpePaiement.Controls.Add(this.numPaiement);
            this.gpePaiement.Controls.Add(this.isVirement);
            this.gpePaiement.Controls.Add(this.isCheque);
            this.gpePaiement.Controls.Add(this.isEspeces);
            this.gpePaiement.Controls.Add(this.isCarte);
            this.gpePaiement.Location = new System.Drawing.Point(158, 90);
            this.gpePaiement.Name = "gpePaiement";
            this.gpePaiement.Size = new System.Drawing.Size(250, 113);
            this.gpePaiement.TabIndex = 4;
            this.gpePaiement.TabStop = false;
            this.gpePaiement.Text = "Type de paiement";
            // 
            // isCarte
            // 
            this.isCarte.AutoSize = true;
            this.isCarte.Location = new System.Drawing.Point(7, 20);
            this.isCarte.Name = "isCarte";
            this.isCarte.Size = new System.Drawing.Size(50, 17);
            this.isCarte.TabIndex = 0;
            this.isCarte.TabStop = true;
            this.isCarte.Text = "Carte";
            this.isCarte.UseVisualStyleBackColor = true;
            // 
            // isEspeces
            // 
            this.isEspeces.AutoSize = true;
            this.isEspeces.Location = new System.Drawing.Point(7, 44);
            this.isEspeces.Name = "isEspeces";
            this.isEspeces.Size = new System.Drawing.Size(66, 17);
            this.isEspeces.TabIndex = 1;
            this.isEspeces.TabStop = true;
            this.isEspeces.Text = "Espèces";
            this.isEspeces.UseVisualStyleBackColor = true;
            // 
            // isCheque
            // 
            this.isCheque.AutoSize = true;
            this.isCheque.Location = new System.Drawing.Point(7, 68);
            this.isCheque.Name = "isCheque";
            this.isCheque.Size = new System.Drawing.Size(62, 17);
            this.isCheque.TabIndex = 2;
            this.isCheque.TabStop = true;
            this.isCheque.Text = "Chèque";
            this.isCheque.UseVisualStyleBackColor = true;
            // 
            // isVirement
            // 
            this.isVirement.AutoSize = true;
            this.isVirement.Location = new System.Drawing.Point(7, 92);
            this.isVirement.Name = "isVirement";
            this.isVirement.Size = new System.Drawing.Size(66, 17);
            this.isVirement.TabIndex = 3;
            this.isVirement.TabStop = true;
            this.isVirement.Text = "Virement";
            this.isVirement.UseVisualStyleBackColor = true;
            // 
            // numPaiement
            // 
            this.numPaiement.Location = new System.Drawing.Point(144, 19);
            this.numPaiement.Name = "numPaiement";
            this.numPaiement.Size = new System.Drawing.Size(100, 20);
            this.numPaiement.TabIndex = 4;
            // 
            // montant
            // 
            this.montant.Location = new System.Drawing.Point(516, 80);
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(100, 20);
            this.montant.TabIndex = 5;
            // 
            // beneficiaire
            // 
            this.beneficiaire.Location = new System.Drawing.Point(456, 143);
            this.beneficiaire.Name = "beneficiaire";
            this.beneficiaire.Size = new System.Drawing.Size(228, 20);
            this.beneficiaire.TabIndex = 6;
            // 
            // gpeDetails
            // 
            this.gpeDetails.Controls.Add(this.sousMontant5);
            this.gpeDetails.Controls.Add(this.designation5);
            this.gpeDetails.Controls.Add(this.categorie5);
            this.gpeDetails.Controls.Add(this.sousMontant4);
            this.gpeDetails.Controls.Add(this.designation4);
            this.gpeDetails.Controls.Add(this.categorie4);
            this.gpeDetails.Controls.Add(this.sousMontant3);
            this.gpeDetails.Controls.Add(this.designation3);
            this.gpeDetails.Controls.Add(this.categorie3);
            this.gpeDetails.Controls.Add(this.sousMontant2);
            this.gpeDetails.Controls.Add(this.designation2);
            this.gpeDetails.Controls.Add(this.categorie2);
            this.gpeDetails.Controls.Add(this.sousMontant1);
            this.gpeDetails.Controls.Add(this.designation1);
            this.gpeDetails.Controls.Add(this.categorie1);
            this.gpeDetails.Location = new System.Drawing.Point(31, 278);
            this.gpeDetails.Name = "gpeDetails";
            this.gpeDetails.Size = new System.Drawing.Size(630, 238);
            this.gpeDetails.TabIndex = 7;
            this.gpeDetails.TabStop = false;
            this.gpeDetails.Text = "Détails des opérations";
            // 
            // categorie1
            // 
            this.categorie1.FormattingEnabled = true;
            this.categorie1.Location = new System.Drawing.Point(6, 33);
            this.categorie1.Name = "categorie1";
            this.categorie1.Size = new System.Drawing.Size(194, 21);
            this.categorie1.TabIndex = 0;
            // 
            // designation1
            // 
            this.designation1.Location = new System.Drawing.Point(207, 33);
            this.designation1.Name = "designation1";
            this.designation1.Size = new System.Drawing.Size(220, 20);
            this.designation1.TabIndex = 1;
            // 
            // sousMontant1
            // 
            this.sousMontant1.Location = new System.Drawing.Point(434, 33);
            this.sousMontant1.Name = "sousMontant1";
            this.sousMontant1.Size = new System.Drawing.Size(100, 20);
            this.sousMontant1.TabIndex = 2;
            // 
            // categorie2
            // 
            this.categorie2.FormattingEnabled = true;
            this.categorie2.Location = new System.Drawing.Point(6, 60);
            this.categorie2.Name = "categorie2";
            this.categorie2.Size = new System.Drawing.Size(194, 21);
            this.categorie2.TabIndex = 3;
            // 
            // designation2
            // 
            this.designation2.Location = new System.Drawing.Point(206, 61);
            this.designation2.Name = "designation2";
            this.designation2.Size = new System.Drawing.Size(220, 20);
            this.designation2.TabIndex = 4;
            // 
            // sousMontant2
            // 
            this.sousMontant2.Location = new System.Drawing.Point(434, 61);
            this.sousMontant2.Name = "sousMontant2";
            this.sousMontant2.Size = new System.Drawing.Size(100, 20);
            this.sousMontant2.TabIndex = 5;
            // 
            // categorie3
            // 
            this.categorie3.FormattingEnabled = true;
            this.categorie3.Location = new System.Drawing.Point(6, 87);
            this.categorie3.Name = "categorie3";
            this.categorie3.Size = new System.Drawing.Size(194, 21);
            this.categorie3.TabIndex = 6;
            // 
            // designation3
            // 
            this.designation3.Location = new System.Drawing.Point(206, 87);
            this.designation3.Name = "designation3";
            this.designation3.Size = new System.Drawing.Size(220, 20);
            this.designation3.TabIndex = 7;
            // 
            // sousMontant3
            // 
            this.sousMontant3.Location = new System.Drawing.Point(434, 87);
            this.sousMontant3.Name = "sousMontant3";
            this.sousMontant3.Size = new System.Drawing.Size(100, 20);
            this.sousMontant3.TabIndex = 8;
            // 
            // categorie4
            // 
            this.categorie4.FormattingEnabled = true;
            this.categorie4.Location = new System.Drawing.Point(6, 114);
            this.categorie4.Name = "categorie4";
            this.categorie4.Size = new System.Drawing.Size(194, 21);
            this.categorie4.TabIndex = 9;
            // 
            // designation4
            // 
            this.designation4.Location = new System.Drawing.Point(206, 115);
            this.designation4.Name = "designation4";
            this.designation4.Size = new System.Drawing.Size(220, 20);
            this.designation4.TabIndex = 10;
            // 
            // sousMontant4
            // 
            this.sousMontant4.Location = new System.Drawing.Point(434, 115);
            this.sousMontant4.Name = "sousMontant4";
            this.sousMontant4.Size = new System.Drawing.Size(100, 20);
            this.sousMontant4.TabIndex = 11;
            // 
            // categorie5
            // 
            this.categorie5.FormattingEnabled = true;
            this.categorie5.Location = new System.Drawing.Point(6, 141);
            this.categorie5.Name = "categorie5";
            this.categorie5.Size = new System.Drawing.Size(194, 21);
            this.categorie5.TabIndex = 12;
            // 
            // designation5
            // 
            this.designation5.Location = new System.Drawing.Point(206, 141);
            this.designation5.Name = "designation5";
            this.designation5.Size = new System.Drawing.Size(220, 20);
            this.designation5.TabIndex = 13;
            // 
            // sousMontant5
            // 
            this.sousMontant5.Location = new System.Drawing.Point(434, 141);
            this.sousMontant5.Name = "sousMontant5";
            this.sousMontant5.Size = new System.Drawing.Size(100, 20);
            this.sousMontant5.TabIndex = 14;
            // 
            // bCreerFiche
            // 
            this.bCreerFiche.Location = new System.Drawing.Point(49, 532);
            this.bCreerFiche.Name = "bCreerFiche";
            this.bCreerFiche.Size = new System.Drawing.Size(135, 23);
            this.bCreerFiche.TabIndex = 8;
            this.bCreerFiche.Text = "Créer la fiche";
            this.bCreerFiche.UseVisualStyleBackColor = true;
            // 
            // bAjoutCompta
            // 
            this.bAjoutCompta.Location = new System.Drawing.Point(191, 531);
            this.bAjoutCompta.Name = "bAjoutCompta";
            this.bAjoutCompta.Size = new System.Drawing.Size(160, 23);
            this.bAjoutCompta.TabIndex = 9;
            this.bAjoutCompta.Text = "Ajouter au livre de comptes";
            this.bAjoutCompta.UseVisualStyleBackColor = true;
            // 
            // bRAZ
            // 
            this.bRAZ.Location = new System.Drawing.Point(358, 532);
            this.bRAZ.Name = "bRAZ";
            this.bRAZ.Size = new System.Drawing.Size(100, 23);
            this.bRAZ.TabIndex = 10;
            this.bRAZ.Text = "Vider le formulaire";
            this.bRAZ.UseVisualStyleBackColor = true;
            // 
            // bImportFiche
            // 
            this.bImportFiche.Location = new System.Drawing.Point(465, 531);
            this.bImportFiche.Name = "bImportFiche";
            this.bImportFiche.Size = new System.Drawing.Size(100, 23);
            this.bImportFiche.TabIndex = 11;
            this.bImportFiche.Text = "Ouvrir une fiche";
            this.bImportFiche.UseVisualStyleBackColor = true;
            // 
            // bImprimerFiche
            // 
            this.bImprimerFiche.Location = new System.Drawing.Point(572, 530);
            this.bImprimerFiche.Name = "bImprimerFiche";
            this.bImprimerFiche.Size = new System.Drawing.Size(112, 23);
            this.bImprimerFiche.TabIndex = 12;
            this.bImprimerFiche.Text = "Imprimer la fiche";
            this.bImprimerFiche.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 578);
            this.Controls.Add(this.bImprimerFiche);
            this.Controls.Add(this.bImportFiche);
            this.Controls.Add(this.bRAZ);
            this.Controls.Add(this.bAjoutCompta);
            this.Controls.Add(this.bCreerFiche);
            this.Controls.Add(this.gpeDetails);
            this.Controls.Add(this.beneficiaire);
            this.Controls.Add(this.montant);
            this.Controls.Add(this.gpePaiement);
            this.Controls.Add(this.gpeType);
            this.Controls.Add(this.dateOperation);
            this.Controls.Add(this.numFiche);
            this.Controls.Add(this.prefixe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numFiche)).EndInit();
            this.gpeType.ResumeLayout(false);
            this.gpeType.PerformLayout();
            this.gpePaiement.ResumeLayout(false);
            this.gpePaiement.PerformLayout();
            this.gpeDetails.ResumeLayout(false);
            this.gpeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prefixe;
        private System.Windows.Forms.NumericUpDown numFiche;
        private System.Windows.Forms.DateTimePicker dateOperation;
        private System.Windows.Forms.GroupBox gpeType;
        private System.Windows.Forms.RadioButton isRecette;
        private System.Windows.Forms.RadioButton isDepense;
        private System.Windows.Forms.GroupBox gpePaiement;
        private System.Windows.Forms.TextBox numPaiement;
        private System.Windows.Forms.RadioButton isVirement;
        private System.Windows.Forms.RadioButton isCheque;
        private System.Windows.Forms.RadioButton isEspeces;
        private System.Windows.Forms.RadioButton isCarte;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.TextBox beneficiaire;
        private System.Windows.Forms.GroupBox gpeDetails;
        private System.Windows.Forms.TextBox sousMontant5;
        private System.Windows.Forms.TextBox designation5;
        private System.Windows.Forms.ComboBox categorie5;
        private System.Windows.Forms.TextBox sousMontant4;
        private System.Windows.Forms.TextBox designation4;
        private System.Windows.Forms.ComboBox categorie4;
        private System.Windows.Forms.TextBox sousMontant3;
        private System.Windows.Forms.TextBox designation3;
        private System.Windows.Forms.ComboBox categorie3;
        private System.Windows.Forms.TextBox sousMontant2;
        private System.Windows.Forms.TextBox designation2;
        private System.Windows.Forms.ComboBox categorie2;
        private System.Windows.Forms.TextBox sousMontant1;
        private System.Windows.Forms.TextBox designation1;
        private System.Windows.Forms.ComboBox categorie1;
        private System.Windows.Forms.Button bCreerFiche;
        private System.Windows.Forms.Button bAjoutCompta;
        private System.Windows.Forms.Button bRAZ;
        private System.Windows.Forms.Button bImportFiche;
        private System.Windows.Forms.Button bImprimerFiche;
    }
}

