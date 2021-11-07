/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 29, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;

namespace Booleanism
{
    /// <summary>
    /// This Exception will be thrown in case of Invalid Control tended to configure.
    /// </summary>
    class InvalidControlException : Exception
    {
        String type = "";
        public InvalidControlException(String type)
        {
            this.type = type;
        }

        public override string Message
        {
            get
            {
                return "InvalidControlException: \"" +type + "\" is not the valid control."  ;
            }
        }
    }
}
