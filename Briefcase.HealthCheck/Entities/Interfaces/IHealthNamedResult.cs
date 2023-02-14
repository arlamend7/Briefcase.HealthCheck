namespace Briefcase.HealthCheck.Entities.Interfaces
{
    /// <summary>
    ///     It is a variation of IHealthResult that has all its properties and the name of the Method that was executed
    /// </summary>
    public interface IHealthNamedResult : IHealthResult
    {
        /// <summary>
        ///     The name of method that was executed
        /// </summary>
        string MethodName { get; }
    }
}
