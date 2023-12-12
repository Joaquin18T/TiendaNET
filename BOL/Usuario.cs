using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;                      //Acceso a conexion + BD
using System.Data;              //Objetos manejadores datos
using System.Data.SqlClient;    //Acceso MSSQL Server
using ENTITIES;

namespace BOL
{
    //Clase publica
    public class Usuario
    {
        //Instancia de la clase conexion
        DBAccess conexion = new DBAccess();

        /// <summary>
        /// Inicia sesion utilizando datos del servidor
        /// </summary>
        /// <param name="email">Identificador o nombre de usuario</param>
        /// <returns>Objeto DataTable conteniendo toda la fila (varios campos)</returns>
        public DataTable iniciarSesion(string email)
        {
            //1. Objeto que contendra el resultado
            //dataTable se usa para guardar temporalmente datos que quieres usar
            DataTable dt = new DataTable(); 

            //2. Abrir conexion
            conexion.abrirConexion();

            //3. Objeto para evitar consulta
            SqlCommand comando = new SqlCommand("spu_usuarios_login", conexion.getConexion());

            //4. Tipo de comando (procedimiento almacenado)
            comando.CommandType = CommandType.StoredProcedure;

            //5. Pasar la(s) variables
            comando.Parameters.AddWithValue("@email", email);

            //6. Ejecutar y obtener/leer los datos
            dt.Load(comando.ExecuteReader());

            //7. Cerrar
            conexion.cerrarConexion();

            //8. Retornamos el objeto con la info
            return dt;
        }

        public DataTable login(string email)
        {
            return conexion.listarDatosVariable("spu_usuarios_login", "@email", email);
        }

        public int Registrar(EUsuario entidad)
        {
            int totalRegistros=0;
            SqlCommand comando = new SqlCommand("spu_usuarios_registrar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            conexion.abrirConexion();
            try
            {
                comando.Parameters.AddWithValue("@apellidos", entidad.apellidos);
                comando.Parameters.AddWithValue("@nombres", entidad.nombres);
                comando.Parameters.AddWithValue("@email", entidad.email);
                comando.Parameters.AddWithValue("@claveacceso", entidad.claveacceso);
                comando.Parameters.AddWithValue("@nivelacceso", entidad.nivelAcceso);

                totalRegistros= comando.ExecuteNonQuery();
            }
            catch 
            {
                totalRegistros = -1;
            }
            finally
            {
                conexion.cerrarConexion();
            }

            return totalRegistros;
        }
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            SqlCommand comando = new SqlCommand("spu_usuarios_listar", conexion.getConexion());
            comando.CommandType = CommandType.StoredProcedure;

            conexion.abrirConexion();
            dt.Load(comando.ExecuteReader());
            conexion.cerrarConexion();

            return dt;
        }
    }
}
