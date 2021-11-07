/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 29, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleanism
{
    /// <summary>
    /// This Exception will be thrown in case of a Null Digital's instant.
    /// </summary>
    class NullDigitalException : Exception
    {
        public NullDigitalException()
        {

        }
        
        public override string Message
        {
            get
            {
                return "NULLDIGITALEXCEPTION: Digital's instant that you want to access is null.";
            }
        }
    }
}
