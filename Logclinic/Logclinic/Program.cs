using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logclinic
{
   
    static class Program
    { 
        //Variável para controle de perfil
        public static string NivelAcesso = "NULL";

        public static string OperadorId = "NULL";

        public static string LocalBank = "DESKTOP-001MESA\\SQLEXPRESS";


        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
       
        [STAThread]
             
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
            //Application.Run(new FrmPrincipal());
        }
    }
}
