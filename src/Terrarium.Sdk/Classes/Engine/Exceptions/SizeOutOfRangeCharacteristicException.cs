//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Engine.Exceptions
{
    /// <summary>
    ///    <para>Size must be within a certain bounds.</para>
    /// </summary>
    public class SizeOutOfRangeCharacteristicException : GameEngineException
    {
        /// <summary>
        ///    <para>Size must be within a certain bounds.</para>
        /// </summary>
        public SizeOutOfRangeCharacteristicException()
            : base("Size must be <= " + EngineSettings.MaxMatureSize + " and >= " +
                   EngineSettings.MinMatureSize)
        {
        }
    }
}