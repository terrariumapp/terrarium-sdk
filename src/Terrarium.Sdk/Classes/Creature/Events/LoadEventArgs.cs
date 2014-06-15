﻿//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

using System;

namespace Terrarium.Sdk.Classes.Creature.Events
{
    /// <summary>
    ///  <para>
    ///   Special object used to hold arguments passed to the
    ///   LoadEventHandler delegate.  Currently no information is
    ///   passed to creatures using this object.
    ///  </para>
    /// </summary>
    [Serializable]
    public class LoadEventArgs : OrganismEventArgs
    {
    }
}