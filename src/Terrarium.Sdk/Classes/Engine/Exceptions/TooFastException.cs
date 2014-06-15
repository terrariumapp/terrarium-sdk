//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Engine.Exceptions
{
    /// <summary>
    /// This organism cannot move this fast.
    /// </summary>
    public class TooFastException : OrganismException
    {
        internal TooFastException()
            : base("This organism cannot move this fast.")
        {
        }
    }
}