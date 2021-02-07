using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tp_Etudiant
{
    public partial class Moyenne_de_Classe : Form
    {
        public Moyenne_de_Classe()
        {
            InitializeComponent();
        }

        private void Moyenne_de_Classe_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = String.Format("SELECT MOYETUMAT.NumI,MOYETUMAT.NomI ,MOYETUMAT.PrenomI, SUM(MOYETUMAT.MoyEtuMat*MOYETUMAT.coeff)/SUM(MOYETUMAT.coeff) AS 'MgEtu'"+
                                                "FROM(SELECT etudiant.NumI, etudiant.NomI, etudiant.PrenomI, m1.libelle, coeff, AVG(note) AS MoyEtuMat " +
                                                "from etudiant  inner join notes n on etudiant.NumI = n.#NumI  inner join matiere m1 on m1.NumM=n.#NumMat " +
                                                "group by etudiant.NumI, etudiant.NomI, etudiant.PrenomI, m1.libelle, coeff) as MOYETUMAT " +
                                                "group by MOYETUMAT.NumI, MOYETUMAT.NomI, MOYETUMAT.PrenomI ");


                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                       
                            dataGridView1.Rows.Add(reader[1].ToString(), reader[2].ToString(), reader[3].ToString());
                            
                        
                    }
                    connection.Close();
                    float coeff = 0; int  moyg = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        coeff= float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + coeff;
                        moyg = i;
                    }
                  
                    coeff = coeff / moyg;
                    if (coeff.ToString() == "NaN")
                        lb_moyC.Text = "0";
                    else
                        lb_moyC.Text = coeff.ToString();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }



            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Hide();
        }
    }
}
