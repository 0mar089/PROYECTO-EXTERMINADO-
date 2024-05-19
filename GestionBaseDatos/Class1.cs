using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace GestionBaseDatos
{
    public class BaseDatos
    {
        SQLiteConnection cnx;

        public void OpenDB()
        {
            string dataSource = "Data Source=C:\\Users\\omarb\\OneDrive\\Documents\\UNIVERSIDAD\\1 AÑO\\2 quatrimestre\\PP\\PROGRAMACIÓN\\PROYECTO-PP\\BaseDatos\\basedatos.db";
            this.cnx = new SQLiteConnection(dataSource);
            this.cnx.Open();
        }
        
        public void CloseDB()
        {
            this.cnx.Close();
        }

        public DataTable GetCompañias()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT * FROM compañias";
            SQLiteDataAdapter adp = new SQLiteDataAdapter(sql, this.cnx);
            adp.Fill(dt);
            return dt;
        }
    }
}
