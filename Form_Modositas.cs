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
    public partial class Form_Modositas : Form
    {
        string mod = null;
        public Form_Modositas(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        private void button_modositas_Click(object sender, EventArgs e)
        {
            Program.command.CommandText = $"UPDATE `termek` SET `termeknev`='{textBox_modositastermeknev.Text}',`ar`='{numericUpDown_modositasar.Value}',`db`='{numericUpDown_modositasraktarKeszlet.Value}' WHERE termek.termekid={textBox_modositastermekid.Text.ToString()}";
            Program.command.ExecuteNonQuery();
            MessageBox.Show("Sikeres módosítás!");
            Program.formVasarlas.updateTermekekLista();
        }
        private void updateModositastermekekLista()
        {
            listBox_termekmodositas.Items.Clear();
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
                        listBox_termekmodositas.Items.Add(new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db")));
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox_termekmodositas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_termekmodositas.SelectedIndex < 0)
            {
                return;
            }
            Termek kivalasztottModositasTermek = (Termek)listBox_termekmodositas.SelectedItem;
            textBox_modositastermekid.Text = kivalasztottModositasTermek.termekid.ToString();
            textBox_modositastermeknev.Text = kivalasztottModositasTermek.termeknev;
            numericUpDown_modositasar.Value = kivalasztottModositasTermek.ar;
            numericUpDown_modositasraktarKeszlet.Value = kivalasztottModositasTermek.db;
        }

        private void Form_Modositas_Load(object sender, EventArgs e)
        {
            updateModositastermekekLista();
        }
    }
}
