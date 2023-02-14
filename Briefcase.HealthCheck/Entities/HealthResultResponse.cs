using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthResultResponse : HealthResult, IHealthResultResponse
    {
        public object Result { get; }
        public override bool Success => true;

        public HealthResultResponse(TimeSpan elapsedTime, object result) : base(elapsedTime)
        {
            Result = result;
        }
    }
}
