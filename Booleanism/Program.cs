using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Booleanism
{
    
    static class Program
    {
        public static Color PrimaryColor { get {return Color.FromArgb(46, 49, 146); }  }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            //if (IsAssociated())
            //    FileAssociationHelper.AssociateFileExtension(".bool", "Booleanism File", "This file extension is used to store the information of circuit, made through Booleanism.", Application.ExecutablePath);
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string [] arg = { @"‪C:\Users\SYED MURTAZA\Desktop\Circuit.bool" };
            
                Application.Run(new Form2());


        }

        public static bool IsAssociated()
        {
            return (Registry.ClassesRoot.OpenSubKey(".bool")==null);
        }

    }
}
