using API.Formularios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string auxParametros = "";
            clMSC.clMSC rutinas = new clMSC.clMSC();

            for (int i = 0; i < args.Length; i++)
            {
                auxParametros += args[i].Trim() + " ";
            }

            string[] args2 = auxParametros.Split('/');

            //string usuario = Environment.UserName;
            //string nombre = Environment.UserDomainName;
            //string estacion = Environment.MachineName;
            //string[] args2 = { @"MOLINO14\MOLINO14", "MaestroEntidades", usuario, "1", "admin", nombre, estacion, "cargo", "ruta programa de acceso" };
            if (args2.Length != 13)
            {
                MessageBox.Show("El número de parámetros no coincide, se encontrarón " + args2.Length.ToString() + " de 13");
            }
            else
            {
                Properties.Settings.Default.Login = args2[0];
                Properties.Settings.Default.IDPerfil = System.Convert.ToInt16(args2[1]);
                Properties.Settings.Default.Perfil = args2[2];
                Properties.Settings.Default.Nombre = args2[3];
                Properties.Settings.Default.NombreCorto = args2[4];
                Properties.Settings.Default.Cargo = args2[5];
                Properties.Settings.Default.RutaProgramaAcceso = args2[6];
                Properties.Settings.Default.PrivilegioAccesoMenu = args2[7];
                Properties.Settings.Default.PrivilegioAccesoFuncionalidad = args2[8];
                //Properties.Settings.Default.ServidorSQLCentral = args2[9];
                //Properties.Settings.Default.BaseSQLCentral = args2[10];
                //Properties.Settings.Default.ServidorSQLMaestroEntidades = args2[11];
                //Properties.Settings.Default.BaseSQLMaestroEntidades = args2[12];

                if (File.Exists("ControlDeAcceso.ini"))
                {
                    string line; bool auxBandera = false;
                    FileStream fs = new FileStream("ControlDeAcceso.ini", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs);

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (auxBandera) { Properties.Settings.Default.PrivilegioAccesoFuncionalidad = rutinas.Desencriptar(line); }
                        if (line.ToUpper() == "AF") { auxBandera = true; }
                    }

                    reader.Close(); reader.Dispose();
                    fs.Close(); fs.Dispose();
                }

                Properties.Settings.Default.Save();
                Application.Run(new mdiPrincipal());
            }
        }
    }
}
