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
        private bool mod = false;
        private bool ajout = false;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
      
      

        private void Ajouter_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            Ann.Enabled = true;
            Enregistrer.Enabled = true;
            Modifier.Enabled = false;
            Ajouter.Enabled = false;
            Suprimer.Enabled = false;
            comboBox1.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            ajout = true;
           

        }



        private void Suprimer_Click(object sender, EventArgs e)
        {
            string box_msg = "confirmer la suppression";

            string box_title = "confiramtion";



            if (MessageBox.Show(box_msg, box_title, MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

                cnx.Open();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cnx.Open();
                cmd.Connection = cnx;
                cmd.CommandText = "delete from fortest where nom='" + textBox1.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
                Ann.Enabled = false;
                Enregistrer.Enabled = false;
                Modifier.Enabled = false;
                Ajouter.Enabled = true;
                Suprimer.Enabled = false;
                comboBox1.Enabled = true;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            comboBox1.Items.Clear();
            jika();

        }


        private void Modifier_Click(object sender, EventArgs e)
        {
                Ann.Enabled = false;
                Enregistrer.Enabled = true;
                Modifier.Enabled = false;
                Ajouter.Enabled = true;
                Suprimer.Enabled = false;
                comboBox1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                mod = true;


        }
        private void Ann_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();

            Ann.Enabled = false;
            Enregistrer.Enabled = false;
            Modifier.Enabled = false;
            Ajouter.Enabled = true;
            Suprimer.Enabled = false;
            comboBox1.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;

        }
        private void Enregistrer_Click(object sender, EventArgs e)
        {
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cmd.Connection = cnx;
            cnx.Open();


            if (ajout)
            {
                
              
                cmd.CommandText = "insert into fortest values('" + textBox1.Text + "','" + textBox2.Text + "') ";
                cmd.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                ajout = false;
            }
            
                if (mod)
                {
                
                cmd.CommandText = "update fortest set nom ='" + textBox1.Text + "' where prenom='" + textBox2.Text + "' ";
                cmd.ExecuteNonQuery();
                cnx.Close();
                ajout = false;
            }
                cnx.Close();

                Ann.Enabled = false;
                Enregistrer.Enabled = false;
                Modifier.Enabled = true;
                Ajouter.Enabled = true;
                Suprimer.Enabled = true;
                comboBox1.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                comboBox1.Items.Clear();
                jika();




        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = comboBox1.SelectedItem.ToString().Trim();
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM fortest ";
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    
                    textBox1.Text = rd["nom"].ToString();
                    textBox2.Text = rd["prenom"].ToString();
                }
            }
            cnx.Close();


        }
            public void jika()
        {
            cmd.Connection = cnx;
            cmd.CommandText = "select * from fortest";
            if (cmd.Connection.State == ConnectionState.Open)
            {
                cmd.Connection.Close();
            }
            cnx.Open();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {

                comboBox1.Items.Add("nom : " + dr["nom"]);


            }


        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            Ann.Enabled = false;
            Enregistrer.Enabled = false;
            Modifier.Enabled = false;
            Ajouter.Enabled = true;
            Suprimer.Enabled = false;
            comboBox1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            jika();
          




        }

       
    }
}
