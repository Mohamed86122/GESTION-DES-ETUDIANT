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
    public partial class Consultation : Form
    {
        public Consultation()
        {
            InitializeComponent();
        }

        private void bt_vider_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = String.Format("select * from etudiant");
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_etudiant.Items.Add(reader[0].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR " + ex.Message);
                }
            }
        }

        private void cb_etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = String.Format("select * from etudiant e inner join notes on e.NumI=#NumI  inner join matiere on #NumMat=NumM ");
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (cb_etudiant.Text == reader[0].ToString())
                        {
                            dataGridView1.Rows.Add(reader[8].ToString(), reader[6].ToString(), reader[9].ToString(), (int.Parse(reader[6].ToString()) * int.Parse(reader[9].ToString())));
                            
                        }
                    }
                    connection.Close();
                    float coeff = 0, moyg = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        moyg = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) + moyg;
                        coeff = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + coeff;
                    }
                   
                    moyg = moyg /coeff ;
                    if(moyg.ToString()=="NaN")
                    lb_moygen.Text = "0";
                    else
                        lb_moygen.Text = moyg.ToString();
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }



            }
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Hide();
        }
    }
    
   
}
