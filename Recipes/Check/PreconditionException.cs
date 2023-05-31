//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

namespace Full_GRASP_And_SOLID
{
    public class PreconditionException : Exception
        {
            public PreconditionException() : base() 
            {
            }
            public PreconditionException(string message) : base(message) 
            {
            }
        }

}