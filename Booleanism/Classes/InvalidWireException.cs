using System;

namespace Booleanism
{
    class InvalidWireException : Exception
    {
        String givenName;
        public InvalidWireException()
        {
            givenName = "WIRE's NAME NOT SET";
        }

        public InvalidWireException(string name)
        {
            givenName = name;
        }

        public override string Message
        {
            get
            {
                return "The wire (" + givenName + ") is not present in the list.\nMake sure you've entered the correct name.";
            }
        }
    }
}
