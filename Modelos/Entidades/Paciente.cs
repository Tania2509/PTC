using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Entidades
{
    public class Paciente
    {
        private int idPaciente;
        private string nombrePa;
        private string apellidoPa;
        private DateTime fechaNacimiento;
        private string telefonoPa;
        private string direccionPa;
        private string correoPa;
        private string dui;

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePa { get => nombrePa; set => nombrePa = value; }
        public string ApellidoPa { get => apellidoPa; set => apellidoPa = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TelefonoPa { get => telefonoPa; set => telefonoPa = value; }
        public string DireccionPa { get => direccionPa; set => direccionPa = value; }
        public string CorreoPa { get => correoPa; set => correoPa = value; }
        public string Dui { get => dui; set => dui = value; }
 

        public bool InsertarPaciente()
        {
        
        SqlConnection con = Conexion.Conexion.conectar();

        
            string comando = "Insert into Paciente (nonbrePa, apellidoPa, fechaMacimiento, telefonoa, dirrecionPa, correoPa, dui);"+"VALUES (@Nombre, @Apellido, @FechaNacimiento, @Telefono, @Direccion, @Correo, @Dui);";

            SqlCommand cmd = new SqlCommand(comando, con);

            cmd.Parameters.AddWithValue("@Nombre", idPaciente);
            cmd.Parameters.AddWithValue("@Apellido", ApellidoPa);
            cmd.Parameters.AddWithValue("@FechaNacimiento",FechaNacimiento);
            cmd.Parameters.AddWithValue("@Telefono",TelefonoPa);
            cmd.Parameters.AddWithValue("@Direccion",DireccionPa);
            cmd.Parameters.AddWithValue("@Correo",CorreoPa);
            cmd.Parameters.AddWithValue("@Dui", dui);

            return cmd.ExecuteNonQuery() > 0;

        }

        public static DataTable CargarNombre()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaceinte, nombrePa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

        public static DataTable CargarCorreo()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaceinte, correoPa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }
        public static DataTable CargarApellido()
        {
            SqlConnection conexion = Conexion.Conexion.conectar();
            string consultaQuery = "select idPaceinte, apellidoPa from Paciente";
            SqlDataAdapter add = new SqlDataAdapter(consultaQuery, conexion);
            DataTable tablaVirtual = new DataTable();
            add.Fill(tablaVirtual);
            return tablaVirtual;
        }

    }
}
