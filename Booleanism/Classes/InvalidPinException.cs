/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 29, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;

namespace Booleanism
{
    class InvalidPinException : Exception
    {
        public InvalidPinException()
        {

        }

        public override string Message
        {
            get
            {
                return "INVALIDPINEXCEPTION: \nThe pin, you want to access is not present.";
            }
        }
    }
}
