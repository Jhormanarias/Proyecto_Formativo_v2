using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria de conexion a sql server
using System.Data.SqlClient;
using System.Data;

namespace Models
{
	class ClaseModels
	{
		//creo la conexion 
		public static string cadena = "Server=(local)\\SQLEXPRESS;Database=Proyecto;User Id = ADSI; Password=2144539;";
		public static DataTable tabla = new DataTable();
		public static string msgExcep = "";
	}
}
