using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
//libreria para conexion a SQL Server
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace Controllers
{
	public class ClaseControlAdmin
	{
        public static string cadena = "Data Source=.;Initial Catalog=BD_PROYECTO;User ID=ADSI;Password=2144539";
        public static string excepcion = "";
        public static long idvisitante = 0;
        public static string nomvisitante = "";
        //variables publicas 
        public static long idbien = 0;
        public static long idusuario = 0;
        public static string usuario = "";
        public static string rol = "";
        //Prueba
        private int Inicio;
        private int Final;

        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }

        //funcion conectar
        public static bool func_conectar()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadena);
                conexion.Open();

                return true;
            }
            catch (Exception ex)
            {
                excepcion = ex.ToString();
                return false;
            }
        }

        //--------------------------------------------- BUSCAR VISITANTE Y BIEN ---------------------------------------

        //FUNCION TRAER NOMBRE DEL VISITANTE Y BIEN CON DOCUMENTO
        public static string Func_TraeNomVisitante(long doc)
        {
            string valor = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERVISIBIEN", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@DOC",
                Value = doc,
                SqlDbType = SqlDbType.Int
            });

            adap.Fill(tabla);
            //pregunto si hay datos en la tabla
            if (tabla.Rows.Count > 0)
            {
                valor = tabla.Rows[0][1].ToString() + ' ' + tabla.Rows[0][2].ToString();
            }
            return valor;
        }

        //FUNCION TRAER NOMBRE DEL VISITANTE Y BIEN CON SERIAL
        public static string Func_TraeNomVisitanteS(string serial)
        {
            string valor = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERVISIBIEN", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@SERIAL",
                Value = serial,
                SqlDbType = SqlDbType.NVarChar,
                Size = 50
            });

            adap.Fill(tabla);
            //pregunto si hay datos en la tabla
            if (tabla.Rows.Count > 0)
            {
                valor = tabla.Rows[0][1].ToString() + ' ' + tabla.Rows[0][2].ToString();
            }
            return valor;
        }


        //---------------------------------------------------------------------------------------------------------------------

        //TRER LOS DATOS DEL VISITANTE
        //PARAMETRO: DOC DEL VISITANDE
        //RETORNO: TABLA (IDBIEN-NOMBRE-APELLIDO-TIPOBIEN-SERIAL-COLOR-OBSERVACION)
        public static DataTable Func_BusVisitante(long doc)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERVISIBIEN", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("@DOC", SqlDbType.BigInt).Value = doc;
            adap.Fill(tabla);
            return tabla;
        }

        public static DataTable Func_BusVisitanteBien(string serial)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERVISIBIEN", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("@SERIAL", SqlDbType.NVarChar).Value = serial;
            adap.Fill(tabla);
            return tabla;
        }

        //REGISTRO ENTRADA O SALIDA DEL BIEN
        public static bool Fun_ControlBien(long idbien)
        {
            try
            {

                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);

                tabla = Fun_ValidarBien(idbien);

                string horas = DateTime.Now.ToString("hh:mm:ss tt");
                string fecha = DateTime.Now.ToString("dd-MM-yyyy");

                if (tabla.Rows.Count >= 2)
                {
                    SqlDataAdapter adap1 = new SqlDataAdapter("UPDATE CONTROLB SET hora_salida = ' " + horas + "' WHERE id_bien= '" + idbien.ToString() + "'", conexion);
                    adap1.Fill(tabla);
                }
                else
                {
                    SqlDataAdapter adap1 = new SqlDataAdapter("INSERT INTO CONTROLB (fecha_registro, hora_entrada, hora_salida, id_usuario, id_bien) VALUES ('" + fecha + "', ' " + horas + "', NULL, '" + idusuario + "', '" + idbien.ToString() + "' )", conexion);
                    adap1.Fill(tabla);
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }


        //CONSULTO EL ESTADO Y SELECCIONO EL BIEN
        public static DataTable Fun_ValidarBien(long idbien)
        {
            string idmaximo = "";
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("SELECT MAX(id_control) FROM CONTROLB WHERE hora_salida IS NULL AND id_bien = '" + idbien + "'", conexion);
            adap.Fill(tabla);
            idmaximo = tabla.Rows[0][0].ToString();

            SqlDataAdapter adap0 = new SqlDataAdapter("SELECT * FROM CONTROLB WHERE hora_salida IS NULL AND id_bien = '" + idbien + "' and id_control = '" + idmaximo + "'", conexion);
            adap0.Fill(tabla);

            return tabla;
        }
        //funcion q recibe el id del bien, luego con el id consulta la hora de entrada si esta vacia en 
        //caso de q se le valla a dar entrada al bien, en caso de q no este vacia es por q el bien ya ingreso
        //seria lo mismo para la salida validar q el ultimo registro en la db MAX(ID) del bien en el cual
        //la hora de salida este vacia y si lo esta puede darle salida de lo contrario no puede por q el bien ya salio


        //------------------------------------------------- REPOSTES -------------------------------------------------------

        //CONSULTO LOS REPORTES DEL CONTROL
        public DataSet Func_Reportes()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTAR", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@inicio", Inicio1);
            comando.Parameters.AddWithValue("@final", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;


        }


        //FILTRO LOS REPORTES
        public DataSet Func_Filtrar(DateTime fecha, long doc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADOX2", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DOC", doc);
            comando.Parameters.AddWithValue("@FECHA", fecha);
            comando.Parameters.AddWithValue("@INICIO", Inicio1);
            comando.Parameters.AddWithValue("@FINAL", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
        public DataSet Func_Filtrarx(DateTime fecha, long doc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADOX2", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DOC", doc);
            comando.Parameters.AddWithValue("@FECHA", fecha);
            comando.Parameters.AddWithValue("@INICIO", 1);
            comando.Parameters.AddWithValue("@FINAL", 10);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        public DataSet Func_FiltrarDoc(long doc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DOC", doc);
            comando.Parameters.AddWithValue("@INICIO", Inicio1);
            comando.Parameters.AddWithValue("@FINAL", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        public DataSet Func_FiltrarDocx(long doc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@DOC", doc);
            comando.Parameters.AddWithValue("@INICIO", 1);
            comando.Parameters.AddWithValue("@FINAL", 10);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
        public DataSet Func_FiltrarFe(DateTime fecha)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FECHA", fecha);
            comando.Parameters.AddWithValue("@INICIO", Inicio1);
            comando.Parameters.AddWithValue("@FINAL", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        public DataSet Func_FiltrarFex(DateTime fecha)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARFILTRADO", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@FECHA", fecha);
            comando.Parameters.AddWithValue("@INICIO", 1);
            comando.Parameters.AddWithValue("@FINAL", 10);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }
    }
}
