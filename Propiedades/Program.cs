using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    internal class Program
    {
        public enum Socket
        {
            [Description("Exprecion Regular")]
            puerto0 = 8980,
            [Description("Calculadora Basica")]
            puerto1 = 8981,
            [Description("Datos personales")]
            puerto2 = 8982,
            [Description("Agenda de Telefonos")]
            puerto3 = 8983,
            [Description("Notas Rápidas")]
            puerto4 = 8984,
            [Description("Registro de Actividades")]
            puerto5 = 8985,
            [Description("Sistema de Mensajes")]
            puerto6 = 8986,
            [Description("Recordatorio de Eventos")]
            puerto7 = 8987,
            [Description("Gestión de Documentos")]
            puerto8 = 8988,
            [Description("Explorador de Archivos")]
            puerto9 = 8989,
            [Description("Gestión de Contactos")]
            puerto10 = 8990,


        }
        static void Main(string[] args)
        {
            int puerto = 0;
            Console.WriteLine("Ingresa un puerto");
            puerto = Convert.ToInt16(Console.ReadLine());
            switch ((Socket)puerto)
            {
                case Socket.puerto0:
                    Console.WriteLine("Configurado puerto 8980,Exprecion Regular");
                    break;
                case Socket.puerto1:
                    Console.WriteLine("Configurado puerto 8981,Calculadora Basica");
                    break;
                case Socket.puerto2:
                    Console.WriteLine("Configurado puerto 8982,Datos Personales");
                    break;
                case Socket.puerto3:
                    Console.WriteLine("Configurado puerto 8983,Agenda de Telefonos");
                    break;
                case Socket.puerto4:
                    Console.WriteLine("Configurado puerto 8984,Notas Rápidas");
                    break;
                case Socket.puerto5:
                    Console.WriteLine("Configurado puerto 8985,Registro de Actividades");
                    break;
                case Socket.puerto6:
                    Console.WriteLine("Configurado puerto 8986,Sistema de Mensajes");
                    break;
                case Socket.puerto7:
                    Console.WriteLine("Configurado puerto 8987,Recordatorio de Eventos");
                    break;
                case Socket.puerto8:
                    Console.WriteLine("Configurado puerto 8988,Gestión de Documentos");
                    break;
                case Socket.puerto9:
                    Console.WriteLine("Configurado puerto 8989,Explorador de Archivos");
                    break;
                case Socket.puerto10:
                    Console.WriteLine("Configurado puerto 8990,Gestión de Contactos");
                    break;
            }
        }
    }
}
