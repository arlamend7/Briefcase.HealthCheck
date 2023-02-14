using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthNamedResultResponse : HealthNamedResult, IHealthNamedResult, IHealthResultResponse
    {
        public object Result { get; }
        public override bool Success => true;

        public HealthNamedResultResponse(string methodName, TimeSpan elapsedTime, object result) : base(methodName, elapsedTime)
        {
            Result = result;
        }
    }
}
