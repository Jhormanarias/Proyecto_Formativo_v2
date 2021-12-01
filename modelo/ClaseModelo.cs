using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria de conexion a sql server
using System.Data.SqlClient;
using System.Data;

namespace modelo
{
	class ClaseModelo
	{
		//creo la conexion 
		public static string cadena = "Server=(local)\\SQLEXPRESS;Database=BD_MVC;User Id = ADSI; Password=2144539;";
		public static DataTable tabla = new DataTable();
		public static string msgExcep = "";

		// crear funcion seleccionar todo
		 public static DataTable func_TraerTodos()
		{
			try
			{
				SqlConnection conexion = new SqlConnection(cadena);
				string consulta = "SELECT * FROM Tbl_Empleado";
				SqlDataAdapter adap = new SqlDataAdapter(consulta, conexion);
				adap.Fill(tabla);
				return tabla;
			}
			catch (Exception e)
			{
				msgExcep = e.ToString();
				return tabla;
			}
		}


	}
}
