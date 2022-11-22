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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace formule
{
    public partial class Form1 : Form
    {
        static string chaine = @"Data Source=DESKTOP-JOF72QM;Initial Catalog=formule;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\App_Data\VotreBD.mdf;Integrated Security=True;User Instance=True"
        //"Server=.\SQLEXPRESS; DataBase=VotreBD;USER ID=sa; PASSWORD="
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ajouter_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into fortest values('" + textBox1.Text + "','" + textBox2.Text + "') ";
            cmd.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            cnx.Close();

            Suprimer.Enabled = false;
          

        }



        private void Suprimer_Click(object sender, EventArgs e)
        {
            string box_msg = "confirmer la suppression";

            string box_title = "confiramtion";



            if (MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo) == DialogResult.Yes)

            {

                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from fortest where nom ='" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                textBox1.Clear();
                textBox2.Clear();

            }
        }


        private void Modifier_Click(object sender, EventArgs e)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update nom,prenom set nom ='" + textBox1.Text + "' where prenom='" + textBox2.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();




        }
        private void Ann_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

        }
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "select * from fortest";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            adapter.Fill(dt);
            cnx.Close();
        }

     

        
    }
}
