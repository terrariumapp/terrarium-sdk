using Terrarium.Sdk.Enumerations;

namespace Terrarium.Sdk.Interfaces
{
    /// <summary>
    ///  <para>
    ///   Species information properties that are applicable only to plants
    ///   and that should be made available to developers.  Use this to find
    ///   out general information about a particular plant species' capabilities.
    ///  </para>
    /// </summary>
    public interface IPlantSpecies
    {
        /// <summary>
        ///  <para>
        ///   Returns the SkinFamily the creature will use when being displayed in the Terrarium.
        ///  </para>
        /// </summary>
        /// <returns>
        ///  System.String identifying the creature's skin family.
        /// </returns>
        PlantSkinFamily SkinFamily
        {
            get;
        }         
    }
}