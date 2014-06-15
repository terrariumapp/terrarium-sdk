//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Engine.Exceptions
{
    /// <summary>
    /// Must be hungry (i.e. have a Normal or Deterioration energy level) to perform this action.
    /// </summary>
    public class NotHungryException : OrganismException
    {
        internal NotHungryException()
            : base("Organism must be hungry to perform this action.")
        {
        }
    }
}