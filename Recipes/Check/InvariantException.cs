//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;
using System.Runtime.Serialization;

namespace Full_GRASP_And_SOLID
{
    public class InvariantException : Exception
        {
            public InvariantException() : base() 
            {
            }
            public InvariantException(string message) : base(message) 
            {
            }
        }

}