using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthNamedResult : HealthResult, IHealthNamedResult
    {
        public string MethodName { get; private set; }

        public HealthNamedResult(string methodName, TimeSpan elapsedTime) : base(elapsedTime)
        {
            MethodName = methodName;
        }
    }
}
