namespace Terrarium.Sdk.Enumerations
{
    /// <summary>
    /// This enumeration contains return codes identifying
    /// the results of an creature insertion into the Terrarium.
    /// </summary>
    public enum SpeciesServiceStatus
    {
        /// <summary>
        /// Success identifies an inserted creature.
        /// </summary>
        Success,
        /// <summary>
        /// AlreadyExists means the creatures name has already been taken and a new name must be given.
        /// </summary>
        AlreadyExists,
        /// <summary>
        /// ServerDown means that a database error occured and the creature was not submitted.
        /// </summary>
        ServerDown,
        /// <summary>
        /// VersionIncompatible is used when the required parameters aren't sent to the function.
        /// </summary>
        VersionIncompatible,
        /// <summary>
        /// FiveMinuteThrottle is returned whenever a user tries to submit more than one animal per 5 minutes.
        /// </summary>
        FiveMinuteThrottle,
        /// <summary>
        /// TwentyFourHourThrottle occurs whenever a user tries to submit more than 30 creatures in a 24 hour period.
        /// </summary>
        TwentyFourHourThrottle,
        /// <summary>
        /// The submission failed a check and has a questionable name
        /// </summary>
        PoliCheckSpeciesNameFailure,
        /// <summary>
        /// The submission failed a check and has a questionable author name
        /// </summary>
        PoliCheckAuthorNameFailure,
        /// <summary>
        /// The submission failed a check and has a questionable email
        /// </summary>
        PoliCheckEmailFailure        
    }
}