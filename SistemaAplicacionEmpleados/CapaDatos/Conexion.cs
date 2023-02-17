using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        SqlConnection conexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MiSistemaEmpleados;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False");
        public void abrir_conexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }
        public void cerrar_conexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public int BuscarUsuarios(string usuario, string contrasena)
        {
            SqlCommand cmd;
            SqlDataReader datareader;
            string correcto = "Ingresando...";
            string incorrecto = "Datos Incorrectos";
            string comandoSQLconsultarRegistro = "Select usuario, contrasena from USUARIOS where usuario='" + usuario + "' and PWDCOMPARE('"+contrasena+"',contrasena)=1 ";
            int contador = 0;
            try
            {
                //entre comillas dobles cuando es entero, cuando es varchar entre comillas simples y dentro comillas dobles.
                //Adicional, dentro de todo va + +
                cmd = new SqlCommand(comandoSQLconsultarRegistro, conexion);
                datareader = cmd.ExecuteReader();
                while (datareader.Read())
                {
                    contador++;
                }
                datareader.Close();
            }
            catch (Exception ex)
            {
                incorrecto = "No se pudo consultar:" + ex.ToString();
                Console.WriteLine(incorrecto);
            }
            Console.WriteLine("Valor: "+contador);
            return contador;

        }

        public string insertar(int codigo, string nombre, double precio)
        {
            SqlCommand cmd;
            string salida = "Se inserto";
            string comandoSQLinsertar = "Insert into dbProductList(codigo, nombre, precio) values (" + codigo + ",'" + nombre + "'," + precio + ")";
            try
            {
                //entre comillas dobles cuando es entero, cuando es varchar entre comillas simples y dentro comillas dobles.
                //Adicional, dentro de todo va + +
                cmd = new SqlCommand(comandoSQLinsertar, conexion);
                cmd.ExecuteNonQuery();
                //MessageBox.Show(salida);
            }
            catch (Exception ex)
            {
                salida = "No se inserto: " + ex.ToString();
            }

            return salida;
        }
    }
}

/*select* from USUARIOS;
INSERT INTO USUARIOS VALUES ('Administrador','4dm1', PWDENCRYPT('12345'))*/