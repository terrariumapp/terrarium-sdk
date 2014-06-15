//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Engine.Exceptions
{
    /// <summary>
    /// You tried to perform an action on another organism that was not visible to you.
    /// </summary>
    public class NotVisibleException : OrganismException
    {
        internal NotVisibleException()
            : base("This organism is not visible.")
        {
        }
    }
}