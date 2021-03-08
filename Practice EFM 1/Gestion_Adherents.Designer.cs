
namespace Practice_EFM_1
{
    partial class Gestion_Adherents
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
            this.tel = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.cin = new System.Windows.Forms.TextBox();
            this.type = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.premier = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.precedent = new System.Windows.Forms.Button();
            this.dernier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lettre = new System.Windows.Forms.TextBox();
            this.FilterByLitterRadio = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(330, 30);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(119, 20);
            this.tel.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(108, 74);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(119, 20);
            this.nom.TabIndex = 2;
            // 
            // adresse
            // 
            this.adresse.Location = new System.Drawing.Point(108, 114);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(119, 20);
            this.adresse.TabIndex = 3;
            // 
            // cin
            // 
            this.cin.Location = new System.Drawing.Point(330, 70);
            this.cin.Name = "cin";
            this.cin.Size = new System.Drawing.Size(119, 20);
            this.cin.TabIndex = 4;
            // 
            // type
            // 
            this.type.Location = new System.Drawing.Point(330, 144);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(119, 20);
            this.type.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "tel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "nom Adherent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "adresse adherent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "cin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "date naissance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Type";
            // 
            // premier
            // 
            this.premier.Location = new System.Drawing.Point(522, 28);
            this.premier.Name = "premier";
            this.premier.Size = new System.Drawing.Size(94, 23);
            this.premier.TabIndex = 13;
            this.premier.Text = "|<<";
            this.premier.UseVisualStyleBackColor = true;
            this.premier.Click += new System.EventHandler(this.prem_Click);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(522, 67);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(94, 23);
            this.suivant.TabIndex = 14;
            this.suivant.Text = ">>";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // precedent
            // 
            this.precedent.Location = new System.Drawing.Point(522, 106);
            this.precedent.Name = "precedent";
            this.precedent.Size = new System.Drawing.Size(94, 23);
            this.precedent.TabIndex = 15;
            this.precedent.Text = "<<";
            this.precedent.UseVisualStyleBackColor = true;
            this.precedent.Click += new System.EventHandler(this.precedent_Click);
            // 
            // dernier
            // 
            this.dernier.Location = new System.Drawing.Point(522, 144);
            this.dernier.Name = "dernier";
            this.dernier.Size = new System.Drawing.Size(94, 23);
            this.dernier.TabIndex = 16;
            this.dernier.Text = ">>|";
            this.dernier.UseVisualStyleBackColor = true;
            this.dernier.Click += new System.EventHandler(this.dernier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(634, 95);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(94, 23);
            this.Ajouter.TabIndex = 17;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // dateNaissance
            // 
            this.dateNaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNaissance.Location = new System.Drawing.Point(330, 105);
            this.dateNaissance.Name = "dateNaissance";
            this.dateNaissance.Size = new System.Drawing.Size(119, 20);
            this.dateNaissance.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "code";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(108, 31);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(119, 20);
            this.code.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lettre);
            this.groupBox1.Controls.Add(this.FilterByLitterRadio);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(21, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 48);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "filter d\'affichage des adherences";
            // 
            // lettre
            // 
            this.lettre.Location = new System.Drawing.Point(193, 22);
            this.lettre.Name = "lettre";
            this.lettre.Size = new System.Drawing.Size(41, 20);
            this.lettre.TabIndex = 23;
            this.lettre.TextChanged += new System.EventHandler(this.lettre_TextChanged);
            // 
            // FilterByLitterRadio
            // 
            this.FilterByLitterRadio.AutoSize = true;
            this.FilterByLitterRadio.Location = new System.Drawing.Point(58, 25);
            this.FilterByLitterRadio.Name = "FilterByLitterRadio";
            this.FilterByLitterRadio.Size = new System.Drawing.Size(129, 17);
            this.FilterByLitterRadio.TabIndex = 1;
            this.FilterByLitterRadio.TabStop = true;
            this.FilterByLitterRadio.Text = "le nom commance par";
            this.FilterByLitterRadio.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "tous";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Gestion_Adherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.code);
            this.Controls.Add(this.dateNaissance);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.dernier);
            this.Controls.Add(this.precedent);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.premier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.cin);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.tel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Gestion_Adherents";
            this.Text = "Gestion Adherents";
            this.Load += new System.EventHandler(this.Gestion_Adherents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox adresse;
        private System.Windows.Forms.TextBox cin;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button premier;
        private System.Windows.Forms.Button suivant;
        private System.Windows.Forms.Button precedent;
        private System.Windows.Forms.Button dernier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DateTimePicker dateNaissance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FilterByLitterRadio;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox lettre;
    }
}