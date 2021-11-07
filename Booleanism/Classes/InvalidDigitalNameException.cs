/*
------------------------<<<<<<>>>>>>>>------------------------------------
This code is written by SYED MURTAZA as a project of OOP Subject on
March 29, 2018 after the approval of course's instructor Mrs. Maryam Feroze.
------------------------<<<<<<>>>>>>>>------------------------------------
*/

using System;

namespace Booleanism
{
    class InvalidDigitalNameException : Exception
    {
        String specifiedName;
        public InvalidDigitalNameException(String name)
        {
            specifiedName = name;
        }

        public override string Message
        {
            get
            {
                return "InvalidDigitalNameException: No Digital's instant found with \"" + specifiedName + "\".";
            }
        }
    }
}
