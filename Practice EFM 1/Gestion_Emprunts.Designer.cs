
namespace Practice_EFM_1
{
    partial class Gestion_Emprunts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.dateEmprunte = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateRetour = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.codeAdherent = new System.Windows.Forms.ComboBox();
            this.adherentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biblioDataSet = new Practice_EFM_1.biblioDataSet();
            this.codeOuvrage = new System.Windows.Forms.ComboBox();
            this.ouvragesPasEmprinteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.adherentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biblioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvragesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adherentsTableAdapter = new Practice_EFM_1.biblioDataSetTableAdapters.adherentsTableAdapter();
            this.empruntsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empruntsTableAdapter = new Practice_EFM_1.biblioDataSetTableAdapters.EmpruntsTableAdapter();
            this.ouvragesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ouvragesTableAdapter = new Practice_EFM_1.biblioDataSetTableAdapters.ouvragesTableAdapter();
            this.ouvragesPasEmprinteTableAdapter = new Practice_EFM_1.biblioDataSetTableAdapters.OuvragesPasEmprinteTableAdapter();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Annuler = new System.Windows.Forms.Button();
            this.imprimerAdherents = new System.Windows.Forms.Button();
            this.imprimerOuvrages = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesPasEmprinteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "numero";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(113, 44);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(119, 20);
            this.numero.TabIndex = 33;
            // 
            // dateEmprunte
            // 
            this.dateEmprunte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateEmprunte.Location = new System.Drawing.Point(371, 57);
            this.dateEmprunte.Name = "dateEmprunte";
            this.dateEmprunte.Size = new System.Drawing.Size(119, 20);
            this.dateEmprunte.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "date Emprunte";
            // 
            // dateRetour
            // 
            this.dateRetour.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRetour.Location = new System.Drawing.Point(371, 97);
            this.dateRetour.Name = "dateRetour";
            this.dateRetour.Size = new System.Drawing.Size(119, 20);
            this.dateRetour.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "date Retour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "code Adherent";
            // 
            // codeAdherent
            // 
            this.codeAdherent.DataSource = this.adherentsBindingSource;
            this.codeAdherent.DisplayMember = "nomAdh";
            this.codeAdherent.FormattingEnabled = true;
            this.codeAdherent.Location = new System.Drawing.Point(113, 82);
            this.codeAdherent.Name = "codeAdherent";
            this.codeAdherent.Size = new System.Drawing.Size(119, 21);
            this.codeAdherent.TabIndex = 39;
            this.codeAdherent.ValueMember = "codAdh";
            // 
            // adherentsBindingSource
            // 
            this.adherentsBindingSource.DataMember = "adherents";
            this.adherentsBindingSource.DataSource = this.biblioDataSet;
            // 
            // biblioDataSet
            // 
            this.biblioDataSet.DataSetName = "biblioDataSet";
            this.biblioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeOuvrage
            // 
            this.codeOuvrage.DataSource = this.ouvragesPasEmprinteBindingSource;
            this.codeOuvrage.DisplayMember = "titOuv";
            this.codeOuvrage.FormattingEnabled = true;
            this.codeOuvrage.Location = new System.Drawing.Point(371, 21);
            this.codeOuvrage.Name = "codeOuvrage";
            this.codeOuvrage.Size = new System.Drawing.Size(119, 21);
            this.codeOuvrage.TabIndex = 41;
            this.codeOuvrage.ValueMember = "codeOuv";
            // 
            // ouvragesPasEmprinteBindingSource
            // 
            this.ouvragesPasEmprinteBindingSource.DataMember = "OuvragesPasEmprinte";
            this.ouvragesPasEmprinteBindingSource.DataSource = this.biblioDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "code Ouvrage";
            // 
            // adherentsBindingSource1
            // 
            this.adherentsBindingSource1.DataMember = "adherents";
            this.adherentsBindingSource1.DataSource = this.biblioDataSetBindingSource;
            // 
            // biblioDataSetBindingSource
            // 
            this.biblioDataSetBindingSource.DataSource = this.biblioDataSet;
            this.biblioDataSetBindingSource.Position = 0;
            // 
            // ouvragesBindingSource1
            // 
            this.ouvragesBindingSource1.DataMember = "ouvrages";
            this.ouvragesBindingSource1.DataSource = this.biblioDataSetBindingSource;
            // 
            // adherentsTableAdapter
            // 
            this.adherentsTableAdapter.ClearBeforeFill = true;
            // 
            // empruntsBindingSource
            // 
            this.empruntsBindingSource.DataMember = "Emprunts";
            this.empruntsBindingSource.DataSource = this.biblioDataSet;
            // 
            // empruntsTableAdapter
            // 
            this.empruntsTableAdapter.ClearBeforeFill = true;
            // 
            // ouvragesBindingSource
            // 
            this.ouvragesBindingSource.DataMember = "ouvrages";
            this.ouvragesBindingSource.DataSource = this.biblioDataSet;
            // 
            // ouvragesTableAdapter
            // 
            this.ouvragesTableAdapter.ClearBeforeFill = true;
            // 
            // ouvragesPasEmprinteTableAdapter
            // 
            this.ouvragesPasEmprinteTableAdapter.ClearBeforeFill = true;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(505, 37);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 42;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(505, 77);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 43;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.Annuler_Click);
            // 
            // imprimerAdherents
            // 
            this.imprimerAdherents.Location = new System.Drawing.Point(622, 77);
            this.imprimerAdherents.Name = "imprimerAdherents";
            this.imprimerAdherents.Size = new System.Drawing.Size(134, 23);
            this.imprimerAdherents.TabIndex = 44;
            this.imprimerAdherents.Text = "Imprimer Les adherents";
            this.imprimerAdherents.UseVisualStyleBackColor = true;
            this.imprimerAdherents.Click += new System.EventHandler(this.imprimerAdherents_Click);
            // 
            // imprimerOuvrages
            // 
            this.imprimerOuvrages.Location = new System.Drawing.Point(622, 37);
            this.imprimerOuvrages.Name = "imprimerOuvrages";
            this.imprimerOuvrages.Size = new System.Drawing.Size(134, 23);
            this.imprimerOuvrages.TabIndex = 45;
            this.imprimerOuvrages.Text = "Imprimer les ouvrages";
            this.imprimerOuvrages.UseVisualStyleBackColor = true;
            this.imprimerOuvrages.Click += new System.EventHandler(this.imprimerOuvrages_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 123);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(801, 328);
            this.crystalReportViewer1.TabIndex = 46;
            // 
            // Gestion_Emprunts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.imprimerOuvrages);
            this.Controls.Add(this.imprimerAdherents);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.codeOuvrage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.codeAdherent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateRetour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.dateEmprunte);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Emprunts";
            this.Text = "Gestion_Emprunts";
            this.Load += new System.EventHandler(this.Gestion_Emprunts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesPasEmprinteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adherentsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biblioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empruntsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ouvragesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.DateTimePicker dateEmprunte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox codeAdherent;
        private System.Windows.Forms.ComboBox codeOuvrage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource biblioDataSetBindingSource;
        private biblioDataSet biblioDataSet;
        private System.Windows.Forms.BindingSource adherentsBindingSource;
        private biblioDataSetTableAdapters.adherentsTableAdapter adherentsTableAdapter;
        private System.Windows.Forms.BindingSource empruntsBindingSource;
        private biblioDataSetTableAdapters.EmpruntsTableAdapter empruntsTableAdapter;
        private System.Windows.Forms.BindingSource ouvragesBindingSource;
        private biblioDataSetTableAdapters.ouvragesTableAdapter ouvragesTableAdapter;
        private System.Windows.Forms.BindingSource adherentsBindingSource1;
        private System.Windows.Forms.BindingSource ouvragesBindingSource1;
        private System.Windows.Forms.BindingSource ouvragesPasEmprinteBindingSource;
        private biblioDataSetTableAdapters.OuvragesPasEmprinteTableAdapter ouvragesPasEmprinteTableAdapter;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button imprimerAdherents;
        private System.Windows.Forms.Button imprimerOuvrages;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}