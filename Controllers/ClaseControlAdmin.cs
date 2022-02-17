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
                SqlDbType = SqlDbType.BigInt
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


        //------------------------------------------------- REPORTES -------------------------------------------------------

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


        //------------------------------------------------- GESTIONAR EQUIPO ------------------------------------------------

        //Funcion para buscar visitante
        public static DataTable Func_BuscarVistante(long doc)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERVISITANTE", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("@DOC", SqlDbType.BigInt).Value = doc;
            adap.Fill(tabla);
            return tabla;
        }

        //Funcion para insertar un bien con id de visitante
        public static bool Func_insertarBien(string serial, string tipodebien, string marca, string color, string cargador, long idvisitante )
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_INGRESARBIEN", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@SERIAL", SqlDbType.NVarChar).Value = serial;
                adap.SelectCommand.Parameters.Add("@TIPOBIEN", SqlDbType.VarChar).Value = tipodebien;
                adap.SelectCommand.Parameters.Add("@MARCA", SqlDbType.VarChar).Value = marca;
                adap.SelectCommand.Parameters.Add("@COLOR", SqlDbType.VarChar).Value = color;
                adap.SelectCommand.Parameters.Add("@CARGADOR", SqlDbType.NVarChar).Value = cargador;
                adap.SelectCommand.Parameters.Add("@IDVISITANTE", SqlDbType.BigInt).Value = idvisitante;
                adap.Fill(tabla);
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }

        //Funcion para llenar la tabla bienes con paginado
        public DataSet Func_Bienes()
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_LISTARBIENES", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@inicio", Inicio1);
            comando.Parameters.AddWithValue("@final", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        //Funcion para eliminar bien colsuntando por el serial
        public static bool Func_EliminarBien(string serialBien)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_ELIMINARBIEN", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@SERIALBIEN", SqlDbType.NVarChar).Value = serialBien;
                adap.Fill(tabla);
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
                //MessageBox.Show("Error: " + ex.ToString());
            }
        }

        //Funcion para editar bien colsuntando por el serial
        public static bool Func_EditarBien(long idbien, string serial, string tipodebien, string marca, string color, string cargador)
        {
            try
            {
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_EDITARBIEN", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@IDBIEN", SqlDbType.BigInt).Value = idbien;
                adap.SelectCommand.Parameters.Add("@SERIALBIEN", SqlDbType.NVarChar).Value = serial;
                adap.SelectCommand.Parameters.Add("@TIPOBIEN", SqlDbType.VarChar).Value = tipodebien;
                adap.SelectCommand.Parameters.Add("@MARCA", SqlDbType.VarChar).Value = marca;
                adap.SelectCommand.Parameters.Add("@COLOR", SqlDbType.VarChar).Value = color;
                adap.SelectCommand.Parameters.Add("@CARGADOR", SqlDbType.NVarChar).Value = cargador;
                adap.Fill(tabla);
                return true;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
                //MessageBox.Show("Error: " + ex.ToString());
            }
        }

        public DataSet Func_BuscarBienesx(string serialdoc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_BUSCARBIENES", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SERIALDOC", serialdoc);
            comando.Parameters.AddWithValue("@INICIO", 1);
            comando.Parameters.AddWithValue("@FINAL", 10);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        public DataSet Func_BuscarBienes(string serialdoc)
        {
            SqlConnection conexion = new SqlConnection(cadena);
            SqlCommand comando = new SqlCommand("PA_BUSCARBIENES", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@SERIALDOC", serialdoc);
            comando.Parameters.AddWithValue("@INICIO", Inicio1);
            comando.Parameters.AddWithValue("@FINAL", Final1);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt;
        }

        //------------------------------------------------- GESTIONAR VISITANTE ------------------------------------------------

        //--------------------------------------------FORMULARIOCONTROLADMIN - USUARIO-------------------------------------------
        public static DataTable Func_TraerUsuario(long doc)
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = new SqlConnection(cadena);
            SqlDataAdapter adap = new SqlDataAdapter("PA_TRAERUSUARIO ", conexion);
            adap.SelectCommand.CommandType = CommandType.StoredProcedure;
            adap.SelectCommand.Parameters.Add("@DOC", SqlDbType.BigInt).Value = doc;
            adap.Fill(tabla);
            return tabla;
        }

        public static bool Func_InsertUsuario(string nom, string ape, string doc, string contra, string correo, string rol)
		{
			try
			{
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_INSERTUSUARIO ", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@NOM", SqlDbType.VarChar).Value = nom;
                adap.SelectCommand.Parameters.Add("@APE", SqlDbType.VarChar).Value = ape;
                adap.SelectCommand.Parameters.Add("@DOC", SqlDbType.NVarChar).Value = doc;
                adap.SelectCommand.Parameters.Add("@CONTRA", SqlDbType.VarChar).Value = contra;
                adap.SelectCommand.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = correo;
                adap.SelectCommand.Parameters.Add("@ROL", SqlDbType.VarChar).Value = rol;
                adap.Fill(tabla);
                return true;

            }
			catch (Exception e)
			{
				e.ToString();
                return false;
			}
		}

        public static bool Func_EliminarUsuario(long id)
		{
            try
            {
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_ELIMINARUSUARIO", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@ID", SqlDbType.Int).Value = id;
                adap.Fill(tabla);
                return true;
            }
            catch (Exception e)
            {

                e.ToString();
                return false;
			}
		}

        public static bool Func_ActualizarUser(long id, string nom, string ape, string doc, string contra, string correo, string rol)
		{
            try
            {
                DataTable tabla = new DataTable();
                SqlConnection conexion = new SqlConnection(cadena);
                SqlDataAdapter adap = new SqlDataAdapter("PA_ACTUALIZARUSU ", conexion);
                adap.SelectCommand.CommandType = CommandType.StoredProcedure;
                adap.SelectCommand.Parameters.Add("@ID_USER", SqlDbType.VarChar).Value = id;
                adap.SelectCommand.Parameters.Add("@NOM", SqlDbType.VarChar).Value = nom;
                adap.SelectCommand.Parameters.Add("@APE", SqlDbType.VarChar).Value = ape;
                adap.SelectCommand.Parameters.Add("@DOC", SqlDbType.NVarChar).Value = doc;
                adap.SelectCommand.Parameters.Add("@CONTRA", SqlDbType.VarChar).Value = contra;
                adap.SelectCommand.Parameters.Add("@CORREO", SqlDbType.VarChar).Value = correo;
                adap.SelectCommand.Parameters.Add("@ROL", SqlDbType.VarChar).Value = rol;
                adap.Fill(tabla);
                return true;

            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
    }
}
