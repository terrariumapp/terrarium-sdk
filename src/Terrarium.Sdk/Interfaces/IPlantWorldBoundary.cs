using Terrarium.Sdk.Classes.State;

namespace Terrarium.Sdk.Interfaces
{
    /// <summary>
    ///  Represents a plant's view of the world.
    /// </summary>
    public interface IPlantWorldBoundary
    {
        /// <summary>
        ///  Retrieves the most up to date plant state for the current
        ///  plant.
        /// </summary>
        PlantState CurrentPlantState
        {
            get;
        }         
    }
}