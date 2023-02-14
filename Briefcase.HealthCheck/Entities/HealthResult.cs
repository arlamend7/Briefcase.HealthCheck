using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthResult : IHealthResult
    {
        public virtual bool Success { get; }
        public TimeSpan ElapsedTime { get; }

        public HealthResult(bool success, TimeSpan elapsedTime)
        {
            Success = success;
            ElapsedTime = elapsedTime;
        }
        public HealthResult(TimeSpan elapsedTime)
        {
            ElapsedTime = elapsedTime;
        }
    }
}
