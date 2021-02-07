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
    public partial class Matiere : Form
    {
        string str;
        int tr;
        public Matiere()
        {
            InitializeComponent();
        }
        public void vider()
        {
            cb_libelle.Text = "";
            nm_coeff.Value = 0;
            cb_enseignant.Text="";
            lb_NomE.Text = "";
            lb_specialité.Text = "";
        }
        


        private void Matiere_Load(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select distinct(libelle), coeff from matiere ";

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_libelle.Items.Add(reader[0].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void cb_enseignant_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from enseignant";

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();




                    while (reader.Read())
                    {
                        if (reader[0].ToString() == cb_enseignant.Text)
                        {
                            lb_NomE.Text = reader[1].ToString();
                            lb_specialité.Text = reader[3].ToString();


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

        private void cb_libelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            str=cb_libelle.Text;
            checkBox1.Checked = false;
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                cb_enseignant.Items.Clear();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from matiere m inner join enseignant e on e.NumEn=m.#NumE where libelle=@libelle";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@libelle";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = str;
                cmd.Parameters.Add(parameter);
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == str)
                        {
                            tr = int.Parse(reader[0].ToString());
                            cb_enseignant.Items.Add(reader[4].ToString());
                            nm_coeff.Value = int.Parse(reader[2].ToString());

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

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "insert into matiere values(@nom,@coeff,@nume)";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@nom";
                parameter.SqlDbType = SqlDbType.VarChar;
                parameter.Size = 30;
                parameter.Value = cb_libelle.Text;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@coeff";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = nm_coeff.Value;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@nume";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = int.Parse(cb_enseignant.Text);
                cmd.Parameters.Add(parameter);



                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ajout Réussit ");
                    vider();
                    cmd.CommandText = "select distinct(libelle), coeff from matiere";
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cb_libelle.Items.Clear();
                    while (reader.Read())
                    {
                        cb_libelle.Items.Add(reader[0].ToString());
                    }

                    connection.Close();
                   
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            Confirmation confirmation = new Confirmation(cb_libelle.Text,int.Parse( nm_coeff.Value.ToString()), int.Parse(cb_enseignant.Text),str, tr);
            confirmation.Show();
            vider();

            if(Globale.hide=true)
            {
                cb_libelle.Items.Clear();
                Matiere_Load(sender, e);
                Globale.hide = false;
            }
            
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "DELETE m FROM matiere m  inner join enseignant e on m.#NumE = e.NumEn  where m.NumM  = @num  ";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@num";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = tr;
                cmd.Parameters.Add(parameter);



                try
                {
                    connection.Open();
                    DialogResult dialogResult = MessageBox.Show("Est-ce que vous êtes sûr de vouloir supprimer " + cb_libelle.Text, "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                            cmd.CommandText = "select * from matiere";
                            SqlDataReader reader = cmd.ExecuteReader();
                            cb_libelle.Items.Clear();
                            while (reader.Read())
                            {
                                cb_libelle.Items.Add(reader[1].ToString());
                            }
                        }
                    }
                } catch(SqlException et)
                {
                    MessageBox.Show(et.Message);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cb_enseignant.Items.Clear();
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select* from enseignant ";

                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cb_enseignant.Items.Add(reader[0].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }
    }
}
