using Briefcase.HealthCheck.Entities.Interfaces;
using System;

namespace Briefcase.HealthCheck.Entities
{
    internal class HealthResultError : HealthResult, IHealthResultError
    {
        public string ErrorMessage { get; set; }
        public override bool Success => false;

        public HealthResultError(TimeSpan elapsedTime, string errorMessage) : base(elapsedTime)
        {
            ErrorMessage = errorMessage;
        }
        public HealthResultError(TimeSpan elapsedTime, Exception ex) : base(elapsedTime)
        {
            while (ex.InnerException != null)
                ex = ex.InnerException;
            ErrorMessage = ex.Message;
        }
    }
}
