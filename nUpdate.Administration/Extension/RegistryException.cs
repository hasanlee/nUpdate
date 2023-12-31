﻿// RegistryException.cs, 10.06.2019
// Copyright (C) Dominic Beger 17.06.2019

using System;

namespace nUpdate.Administration.Extension
{
    /// <summary>
    ///     This exception is thrown when there is an error when reading, writing or modifying file assocation info.
    /// </summary>
    [Serializable]
    public class RegistryException : ApplicationException
    {
        /// <summary>
        ///     Initializes a new instance of the RegistryException class.
        /// </summary>
        public RegistryException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the RegistryException class with a specified error message.
        /// </summary>
        /// <param name="message">A System.String that describes the error.</param>
        public RegistryException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the ApplicationException class with a specified error message and a reference to the
        ///     inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        ///     The exception that is the cause of the current exception. If the innerException parameter
        ///     is not a null reference (Nothing in Visual Basic), the current exception is raised in a catch block that handles
        ///     the inner exception.
        /// </param>
        public RegistryException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}