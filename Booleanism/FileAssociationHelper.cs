﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Booleanism
{
    static class FileAssociationHelper
    {
        public static void AssociateFileExtension(string fileExtension, string name, string description, string appPath)
        {
            //Create a key with specified file extension
            RegistryKey _extensionKey = Registry.ClassesRoot.CreateSubKey(fileExtension, RegistryKeyPermissionCheck.ReadSubTree);
            _extensionKey.SetValue("", name);

            //Create main key for the specified file format
            RegistryKey _formatNameKey = Registry.ClassesRoot.CreateSubKey(name);
            _formatNameKey.SetValue("", description);
            _formatNameKey.CreateSubKey("DefaultIcon").SetValue("", "\"" + appPath + "\",0");

            //Create teh 'Open' action under 'Shell' key
            RegistryKey _shellActionsKey = _formatNameKey.CreateSubKey("Shell");
            _shellActionsKey.CreateSubKey("open").CreateSubKey("command").SetValue("", "\"" + appPath + "\" \"%1\"");

            _extensionKey.Close();
            _formatNameKey.Close();
            _shellActionsKey.Close();

            // Update Windows Explorer windows for this new file association
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        public static void RemoveFileAssociation(string fileExtension, string name)
        {
            //Remove file extension key
            RegistryKey _extensionKey = Registry.ClassesRoot.OpenSubKey(fileExtension);
            if (_extensionKey != null)
            {
                _extensionKey.Dispose();

                Registry.ClassesRoot.DeleteSubKeyTree(fileExtension);
            }

            //Remove format key and actions
            RegistryKey _formatNameKey = Registry.ClassesRoot.OpenSubKey(name);
            if (_formatNameKey != null)
            {                
                Registry.ClassesRoot.DeleteSubKeyTree(name);
            }

            // Update Windows Explorer windows for this new file association
            SHChangeNotify(0x08000000, 0x0000, IntPtr.Zero, IntPtr.Zero);
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);
    }    

}