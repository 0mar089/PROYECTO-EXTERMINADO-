using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionBaseDatos
{
    public class BaseDatos
    {
        SQLiteConnection cnx;

        public void OpenDB()
        {
            string dataSource = "Data Source=..\\..\\..\\..\\BaseDatos\\basedatos.db";
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
