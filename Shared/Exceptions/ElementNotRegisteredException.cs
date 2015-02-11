﻿using System;
using System.Runtime.Serialization;

namespace TestAutomation.Shared.Exceptions
{
    class ElementNotRegisteredException : Exception
    {
        public ElementNotRegisteredException(){}

        public ElementNotRegisteredException(string message) : base(message){}

        protected ElementNotRegisteredException(SerializationInfo info, StreamingContext context) : base(info, context){}

        public ElementNotRegisteredException(string message, Exception innerException) : base(message, innerException){}
    }
}
