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
    public partial class Etudiant : Form
    {
        public Etudiant()
        {
            InitializeComponent();
        }


        public void vider()
        {
            cb_numet.Text = "";
            txt_prenom.Clear();
            txt_nom.Clear();
        }

        private void Etudiant_Load(object sender, EventArgs e)
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
                        cb_numet.Items.Add(reader[0].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into etudiant values(@nom,@prenom)";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@nom";
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Size = 30;
                parameter.Value = txt_nom.Text;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@prenom";
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Size = 30;
                parameter.Value = txt_prenom.Text;
                cmd.Parameters.Add(parameter);



                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussit ");
                    vider();
                    cmd.CommandText = "select * from etudiant";
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cb_numet.Items.Clear();
                    while (reader.Read())
                    {
                        cb_numet.Items.Add(reader[0].ToString());
                    }

                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void cb_numet_SelectedIndexChanged(object sender, EventArgs e)
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
                        if (reader[0].ToString() == cb_numet.Text)
                        {
                            txt_prenom.Text = reader[2].ToString();
                            txt_nom.Text = reader[1].ToString();


                        }
                    }


                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "update etudiant set NomI=@nom,PrenomI=@prenom where NumI=@num ";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@num";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = int.Parse(cb_numet.Text);
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@nom";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = txt_nom.Text;
                cmd.Parameters.Add(parameter);


                parameter = new SqlParameter();
                parameter.ParameterName = "@prenom";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = txt_prenom.Text;
                cmd.Parameters.Add(parameter);




                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification Réussit ");
                    vider();
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE FROM etudiant where NumI=@num ";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@num";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = int.Parse(cb_numet.Text);
                cmd.Parameters.Add(parameter);



                try
                {
                    connection.Open();
                    DialogResult dialogResult = MessageBox.Show("Est-ce que vous êtes sûr de vouloir supprimer " + txt_nom.Text + " qui a le num " + cb_numet.Text, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Element introuvable !!!!! ");
                        }
                        else
                        {
                            MessageBox.Show("Suppression Réussit ");
                            vider();
                            cmd.CommandText = "select * from etudiant";
                            SqlDataReader reader = cmd.ExecuteReader();
                            cb_numet.Items.Clear();
                            while (reader.Read())
                            {
                                cb_numet.Items.Add(reader[0].ToString());
                            }
                        }


                    }





                    connection.Close();


                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
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
                    bool tr = false;
                    while (reader.Read())
                    {
                        if (reader[0].ToString() == cb_numet.Text)
                        {
                            txt_prenom.Text = reader[2].ToString();
                            txt_nom.Text = reader[1].ToString();
                            tr = true;

                        }
                    }
                    if (tr == false)
                        MessageBox.Show("Element introuvable !!");
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_vider_Click(object sender, EventArgs e)
        {
            vider();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("select * from etudiant ");

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader sql = cmd.ExecuteReader();

                    sql.Read();

                    cb_numet.Text = sql[0].ToString();
                    txt_prenom.Text = sql[1].ToString();
                    txt_nom.Text = sql[2].ToString();


                    connection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format("select * from etudiant ");

                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader sql = cmd.ExecuteReader();

                    while (sql.Read())
                    {
                        cb_numet.Text = sql[0].ToString();
                        txt_prenom.Text = sql[1].ToString();
                        txt_nom.Text = sql[2].ToString();
                        
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("error" + ex.Message);
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu x = new Menu();
            x.Show();
            this.Hide();
        }
    }
}
