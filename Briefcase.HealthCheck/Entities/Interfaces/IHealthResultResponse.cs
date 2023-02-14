namespace Briefcase.HealthCheck.Entities.Interfaces
{
    /// <summary>
    ///     It is a variation of IHealthResult that has all its properties on success and has the return of the method 
    /// </summary>
    public interface IHealthResultResponse : IHealthResult
    {
        /// <summary>
        ///     The result return of the method on success
        /// </summary>
        object Result { get; }
    }
}
