using System;

namespace Briefcase.HealthCheck.Entities.Interfaces
{
    /// <summary>
    ///     Its the interface that represent a result of a health execution
    /// </summary>
    public interface IHealthResult
    {
        /// <summary>
        ///     True value on this property represent a conclusion without exception
        /// </summary>
        bool Success { get; }
        /// <summary>
        ///     Its represent how much time it took to complete the full execution
        /// </summary>
        TimeSpan ElapsedTime { get; }
    }
}
