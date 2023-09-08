using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace Pry1Semestre2
{
    class Empleados
    {
        string cadena;
        OleDbConnection conector;
        OleDbCommand comando;
        OleDbDataAdapter adaptador;
        DataTable tabla;

        public Empleados()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=EMPRESA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Empleados";
            adaptador.Fill(tabla);

        }


        public void ver(DataGridView grilla)
        {
            grilla.DataSource = tabla;
            
        }

    }
}
