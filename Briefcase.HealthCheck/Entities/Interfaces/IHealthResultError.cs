namespace Briefcase.HealthCheck.Entities.Interfaces
{
    /// <summary>
    ///     It is a variation of IHealthResult that represent a error and has its message 
    /// </summary>
    public interface IHealthResultError : IHealthResult
    {
        /// <summary>
        ///     The exception message
        /// </summary>
        string ErrorMessage { get; }
    }
}
