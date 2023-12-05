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
    public partial class Form_Termék : Form
    {
        string mod = null;
        public Form_Termék(string mod)
        {
            InitializeComponent();
            this.mod=mod;
        }

        private void Form_Termék_Load(object sender, EventArgs e)
        {
            
        }

        private void button_létrehozás_Click(object sender, EventArgs e)
        {
            Program.command.CommandText=$"INSERT INTO `termek` (`termeknev`, `ar`, `db`) VALUES ('{textBox_ujtermeknev.Text}', '{numericUpDown_ujar.Value}', '{numericUpDown_ujraktarKeszlet.Value}');";
            Program.command.ExecuteNonQuery();
            MessageBox.Show("Sikeres felvétel!");
            Program.formVasarlas.updateTermekekLista();
        }
    }
}
