﻿using System.Runtime.Serialization;

namespace GoOrCs.SharedKernel.Runtime.Exceptions;

public class AuthorizationException : Exception
{
    public string Type { get; set; } = "AUTHORIZATION";
    
    public AuthorizationException() : this(string.Empty)
    {
    }

    public AuthorizationException(string message) : base(message)
    {
    }

    public AuthorizationException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected AuthorizationException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}