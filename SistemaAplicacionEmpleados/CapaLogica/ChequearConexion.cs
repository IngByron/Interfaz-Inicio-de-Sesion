using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaLogica
{
    public class ChequearConexion
    {

        public string nombre, usuario, contrasena;
        Conexion cn = new Conexion();
        public void conectarDB()
        {
            cn.abrir_conexion();
        }
        public void desconectarDB()
        {
            cn.cerrar_conexion();
        }

        public int ChequearLogin(string usuario, string contrasena)
        {
            conectarDB();
            if (cn.BuscarUsuarios(usuario, contrasena) == 0)
            {
                Console.WriteLine("No existe la cuenta");
                return 0;
            }
            else
            {
                Console.WriteLine("Cuenta encontrada");
                return 1;
                
            }
            
        }
        
    }
}
