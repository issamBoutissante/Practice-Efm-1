using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_EFM_1
{
    public partial class Gestion_Emprunts : Form
    {
        SqlConnection connection;
        public Gestion_Emprunts()
        {
            InitializeComponent();
            connection = new SqlConnection(Global.connectionString);
        }

        private void Gestion_Emprunts_Load(object sender, EventArgs e)
        {
            RemplirCombos();
            RefrechNumero();
        }
        void RemplirCombos()
        {
            this.ouvragesPasEmprinteTableAdapter.Fill(this.biblioDataSet.OuvragesPasEmprinte);
            this.adherentsTableAdapter.Fill(this.biblioDataSet.adherents);
        }
        void CheckConnectionState()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }
        void RefrechNumero()
        {
            CheckConnectionState();
            try
            {
                connection.Open();
                object result=new SqlCommand("select max(numEmp) from emprunts", connection).ExecuteScalar();
                if (string.IsNullOrEmpty(result.ToString()))
                {
                    numero.Text = "1";
                    return;
                }
                numero.Text = ((int)result+1).ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void Annuler_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DialogResult result=MessageBox.Show("vous ete sure de supprimer cette emprunt ?","Question",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                new SqlCommand($"delete Emprunts where numEmp={numero.Text}",connection).ExecuteNonQuery();
                MessageBox.Show("l'emprint a ete supprime");
                RefrechNumero();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                new SqlCommand($"insert into Emprunts values({numero.Text},{codeAdherent.SelectedValue}," +
                    $"{codeOuvrage.SelectedValue},'{dateEmprunte.Text}','{dateRetour.Text}')",connection).ExecuteNonQuery();
                MessageBox.Show("l'emprint a ete ajoute");
                RefrechNumero();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void imprimerOuvrages_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DataTable ouvrageTable = new DataTable();
                new SqlDataAdapter("select codeOuv,titOuv,nomDit,nomAdh,dateEmp from ouvrages join emprunts on ouvrages.codeOuv = Emprunts.codOuv " +
                    "join adherents " +
                    "on adherents.codAdh = Emprunts.codAdh ", connection).Fill(ouvrageTable);
                OuvrageCrystalReport ouvrageReport = new OuvrageCrystalReport();
                ouvrageReport.SetDataSource(ouvrageTable);
                crystalReportViewer1.ReportSource = ouvrageReport;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void imprimerAdherents_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DataTable adherentsTable=new DataTable();
                new SqlDataAdapter($"select codAdh,nomAdh,cinAdh,dnAdh from adherents where dnAdh between" +
                    $" '{Date_De.Text}' and '{Date_A.Text}'; ",connection).Fill(adherentsTable);
                adherentsCrystalReports adherentReports = new adherentsCrystalReports();
                adherentReports.SetDataSource(adherentsTable);
                adherentReports.SetParameterValue("date_de", Date_De.Text);
                adherentReports.SetParameterValue("date_a", Date_A.Text);
                crystalReportViewer1.ReportSource = adherentReports;
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void EmpruntParAnne_Click(object sender, EventArgs e)
        {
            try
            {
                this.empruntsTableAdapter.Fill(this.biblioDataSet.Emprunts);
                EmpruntsParAnneCrystalReport EPA = new EmpruntsParAnneCrystalReport();
                EPA.SetDataSource((DataTable)this.biblioDataSet.Emprunts);
                crystalReportViewer1.ReportSource = EPA;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}