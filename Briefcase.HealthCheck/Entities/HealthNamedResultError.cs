using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthNamedResultError : HealthNamedResult, IHealthNamedResult, IHealthResultError
    {
        public string ErrorMessage { get; set; }
        public override bool Success => false;

        public HealthNamedResultError(string methodName, TimeSpan elapsedTime, string errorMessage) : base(methodName, elapsedTime)
        {
            ErrorMessage = errorMessage;
        }
        public HealthNamedResultError(string methodName, TimeSpan elapsedTime, Exception ex) : base(methodName, elapsedTime)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;
            ErrorMessage = ex.Message;
        }
    }
}
