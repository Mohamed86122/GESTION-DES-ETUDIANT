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
    public partial class Confirmation : Form
    { 
        string Libelle,Str;
        int Coeff,NumE,TR;
        




        public Confirmation()
        {
            InitializeComponent();
        }
        public Confirmation(string libelle,int coeff,int nume, string str,int tr)
        {
            
            InitializeComponent();
            Libelle = libelle;
            Coeff = coeff;
            NumE = nume;
            Str = str;
            TR = tr;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            char[] ens = comboBox1.Text.ToCharArray();
            lb_en.Text = ens[0].ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
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
                        comboBox1.Items.Add(reader[0].ToString() + " , " + reader[1].ToString() + " , " + reader[3].ToString());
                    }
                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_annuller_Click(object sender, EventArgs e)
        {
            Globale.hide = true;
            this.Hide();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "select * from matiere m inner join enseignant e on e.NumEn=m.#NumE where libelle=@str and e.NumEn != @num";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@str";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = Str;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@num";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = NumE;
                cmd.Parameters.Add(parameter);


                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader[1].ToString() == Libelle)
                        {
                            comboBox1.Items.Add(reader[4].ToString() + " , " + reader[5].ToString()+" , "+ reader[7].ToString());
                            
                        }
                        //SqlCommand cmd1 = new SqlCommand();
                        //cmd1.Connection = connection;
                        //cmd1.CommandText = "select * from enseignant";
                        //if (reader[7].ToString()==)
                        //{
                        //    comboBox2.Items.Add(red[0].ToString());
                        //}
                    }


                    connection.Close();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);
                }

            }
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection connection = new SqlConnection(Globale.conn))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;




                cmd.CommandText = "update matiere set libelle=@nom,coeff=@coeff,#NumE=@nume where libelle=@str and NumM = @tr";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@nom";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = Libelle;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@coeff";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = Coeff;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@nume";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = lb_en.Text;
                cmd.Parameters.Add(parameter);

                

                parameter = new SqlParameter();
                parameter.ParameterName = "@str";
                parameter.SqlDbType = SqlDbType.NVarChar;
                parameter.Size = 30;
                parameter.Value = Str;
                cmd.Parameters.Add(parameter);

                parameter = new SqlParameter();
                parameter.ParameterName = "@tr";
                parameter.SqlDbType = SqlDbType.Int;
                parameter.Value = TR;
                cmd.Parameters.Add(parameter);






                try
                {
                    connection.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Modification Réussit ");
                    
                    connection.Close();
                    Globale.hide = true;
                    this.Hide();
                }
                catch (SqlException et)
                {
                    MessageBox.Show(et.Message);

                }

            }
        }
    }
}
