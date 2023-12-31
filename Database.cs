﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppLogin
{
    internal class Database
    {
        MySqlConnection connection;
        MySqlCommand command;

        public Database()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server="localhost";
            builder.UserID="root";
            builder.Password="";
            builder.Database="vasarlas";
            builder.CharacterSet="utf8";
            connection=new MySqlConnection(builder.ConnectionString);
            command= connection.CreateCommand();
            try
            {
                nyit();

                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        private void zar()
        {
            if (connection.State!=System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State!=System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public List<Termek> GetTermekek()
        {
            nyit();
            List<Termek> termekek = new List<Termek>();
            command.CommandText = "SELECT `termekid`,`termeknev`,`ar`,`db` FROM `termek` WHERE 1 ORDER BY termeknev";

            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    termekek.Add(new Termek(dr.GetInt32("termekid"), dr.GetString("termeknev"), dr.GetInt32("ar"), dr.GetInt32("db")));
                }
            }
            zar();
            return termekek;
        }
        public int validUser(string name, string pass)
        {
            nyit();
            int userid=-1;
            command.CommandText = "SELECT vasarlo.jelszo, vasarlo.vasarloid FROM vasarlo WHERE vasarlo.nev=@nev";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", name);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string taroltjelszo = reader.GetString("jelszo");
                if (taroltjelszo.Equals(pass))
                {
                    userid=reader.GetInt32("vasarloid");
                }
                zar();
            }

            return userid;
        }
        public bool vasarlas(int termekid, decimal darab)
        {
            bool siker=false;
            MySqlTransaction tr = null;
            try
            {
                tr=connection.BeginTransaction();
                command.Transaction = tr;
                command.CommandText="INSERT INTO `vasarlas` (`vasarloid`, `termekid`, `vasaroltdb`) VALUES (@vasarloid, @termekid, @vasaroltdb);";
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@vasarloid", Program.UserId);
                command.Parameters.AddWithValue("@termekid", termekid);
                command.Parameters.AddWithValue("@vasaroltdb", darab);
                command.ExecuteNonQuery();
                command.CommandText=$"UPDATE `termek` SET`db`=db-{darab} WHERE `termekid`={termekid};";
                command.ExecuteNonQuery();
                tr.Commit();
                siker=true;
            }
            catch (MySqlException ex)
            {
                tr.Rollback();
            }
            return siker;
        }
    }
}
