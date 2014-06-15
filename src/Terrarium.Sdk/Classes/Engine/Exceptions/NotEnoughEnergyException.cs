//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Engine.Exceptions
{
    /// <summary>
    /// Not enough energy to perform this action.
    /// </summary>
    public class NotEnoughEnergyException : OrganismException
    {
        internal NotEnoughEnergyException()
            : base("Not enough energy to perform this action.")
        {
        }
    }
}