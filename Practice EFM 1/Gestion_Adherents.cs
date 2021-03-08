using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Practice_EFM_1
{
    public partial class Gestion_Adherents : Form
    {
        SqlConnection connection;
        SqlDataAdapter adherentsAdapter;
        DataSet dataSet;
        BindingManagerBase bmb;
        public Gestion_Adherents()
        {
            InitializeComponent();
            connection = new SqlConnection(Global.connectionString);
            dataSet = new DataSet();
        }

        private void Gestion_Adherents_Load(object sender, EventArgs e)
        {
            adherentsAdapter = new SqlDataAdapter("select * from adherents", connection);
            adherentsAdapter.Fill(dataSet, "adherents");
            bmb = BindingContext[dataSet.Tables["adherents"].DefaultView];
            code.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "codAdh");
            nom.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "nomAdh");
            adresse.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "adrAdh");
            tel.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "telAdh");
            cin.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "cinAdh");
            dateNaissance.DataBindings.Add("Value", dataSet.Tables["adherents"].DefaultView, "dnAdh");
            type.DataBindings.Add("Text", dataSet.Tables["adherents"].DefaultView, "typAdh");
            dataGridView1.DataSource = dataSet.Tables["adherents"].DefaultView;
        }

        private void prem_Click(object sender, EventArgs e)
        {
            bmb.Position = 0;
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            DataRow row = dataSet.Tables["adherents"].NewRow();
            row.BeginEdit();
            row["codAdh"] = code.Text;
            row["nomAdh"] = nom.Text;
            row["adrAdh"] = adresse.Text;
            row["telAdh"] = tel.Text;
            row["cinAdh"] = cin.Text;
            row["dnAdh"] = dateNaissance.Value;
            row["typAdh"] = type.Text;
            row.EndEdit();
            dataSet.Tables["adherents"].Rows.Add(row);
            SqlCommandBuilder cm = new SqlCommandBuilder(adherentsAdapter);
            adherentsAdapter.Update(dataSet.Tables["adherents"]);
        }

        private void dernier_Click(object sender, EventArgs e)
        {
            bmb.Position = bmb.Count - 1;
        }

        private void precedent_Click(object sender, EventArgs e)
        {
            if(bmb.Position>0)
                bmb.Position--;
        }

        private void suivant_Click(object sender, EventArgs e)
        {
            if (bmb.Position < bmb.Count - 1)
                bmb.Position++;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataSet.Tables["adherents"].DefaultView.RowFilter = null;
        }

        private void lettre_TextChanged(object sender, EventArgs e)
        {
        
            if (FilterByLitterRadio.Checked && !string.IsNullOrEmpty(lettre.Text))
            {
                if (new DataView(dataSet.Tables["adherents"], $"Substring(nomAdh,1,1)='{lettre.Text}'", "", DataViewRowState.CurrentRows).Count == 0)
                {
                    MessageBox.Show($"aucun nom commance par {lettre.Text}");
                    return;
                }
                dataSet.Tables["adherents"].DefaultView.RowFilter = $"Substring(nomAdh,1,1)='{lettre.Text}'";
            }
        }
    }
}
