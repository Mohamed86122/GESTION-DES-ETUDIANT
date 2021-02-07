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
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }
        public void vider()
        {
            cb_matiere.Text = "";
            cb_etud.Text = "";
            lb_coeff.Text = "";
            lb_nom.Text = "";
            lb_prenom.Text = "";
            txt_note.Clear();
        }
        private void Notes_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from etudiant";

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_etud.Items.Add(reader[0].ToString());
                    }
                    reader.Close();
                    cmd.CommandText = "select distinct(libelle) from matiere";
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_matiere.Items.Add(reader[0].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
            
        }

        private void cb_etud_SelectedIndexChanged(object sender, EventArgs e)
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
                        if (cb_etud.Text == reader[0].ToString())
                        {
                            lb_nom.Text = reader[1].ToString();
                            lb_prenom.Text = reader[2].ToString();
                        }
                    }
                    connection.Close();



                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
               


                try
                {
                    connection.Open();
                    cmd.CommandText = "select * from matiere";
                    
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (cb_matiere.Text == reader[1].ToString())
                        {
                            cb_matiere.Text = reader[0].ToString();
                        }
                    }
                    reader.Close();
                    cmd.CommandText = "insert into notes values(@NumI,@#NumMat,@note)";
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@Numi";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Value = cb_etud.Text;
                    cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter();
                    parameter.ParameterName = "@#NumMat";
                    parameter.SqlDbType = SqlDbType.Int;
                    parameter.Value = cb_matiere.Text;
                    cmd.Parameters.Add(parameter);

                    parameter = new SqlParameter();
                    parameter.ParameterName = "@note";
                    parameter.SqlDbType = SqlDbType.Float;
                    parameter.Value = txt_note.Text;
                    cmd.Parameters.Add(parameter);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout réussi !!!!!!!!!!!!!!! ");
                    vider();
                    connection.Close();

                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void cb_matiere_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                using (SqlConnection connection = new SqlConnection(Globale.conn))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = String.Format("select * from matiere");
                    try
                    {
                        connection.Open();
                        cmd.ExecuteNonQuery();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (cb_matiere.Text == reader[1].ToString())
                            {
                               
                                lb_coeff.Text = reader[2].ToString();
                            }
                        }
                        connection.Close();



                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error" + ex.Message);
                    }
                }
            
        }
        private void txt_note_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Annuller_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Hide();

        }
    }
}
