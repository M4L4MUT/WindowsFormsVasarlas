using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLogin
{
    public partial class Form_Törles : Form
    {
        string mod = null;
        public Form_Törles(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_Törles_Load(object sender, EventArgs e)
        {
            updateTorolttermekekLista();
        }
        private void updateTorolttermekekLista()
        {
            listBox_termektorles.Items.Clear();
            Program.command.CommandText = "SELECT `termekid`,`termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";
            try
            {
                if (Program.connection.State != ConnectionState.Open)
                {
                    Program.connection.Open();
                }
                using (MySqlDataReader dr = Program.command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listBox_termektorles.Items.Add(new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db")));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_termektorles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_termektorles.SelectedIndex < 0)
            {
                return;
            }
            Termek kivalasztottToroltTermek = (Termek)listBox_termektorles.SelectedItem;
            textBox_torlestermekid.Text = kivalasztottToroltTermek.termekid.ToString();
            textBox_torlestermeknev.Text = kivalasztottToroltTermek.termeknev;
            numericUpDown_ar.Value = kivalasztottToroltTermek.ar;
            numericUpDown_raktarKeszlet.Value = kivalasztottToroltTermek.db;
        }

        private void textBox_torlestermekid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_vasarlas_Click(object sender, EventArgs e)
        {
            Program.command.CommandText =$"DELETE FROM `termek` WHERE termek.termekid = {textBox_torlestermekid.Text.ToString()};";
            Program.command.ExecuteNonQuery();
            MessageBox.Show("Sikeres törlés!");
            Program.formVasarlas.updateTermekekLista();
        }
    }
}
