using System.Diagnostics;
using System.Threading.Tasks;
using System;
using Briefcase.HealthCheck.Entities;
using Briefcase.HealthCheck.Entities.Interfaces;

namespace Briefcase.HealthCheck
{
    /// <summary>
    ///     The class that has the base of all methods of HealthExecution class
    /// </summary>
    public abstract class HealthExecutionBase
    {
        /// <summary>
        ///     Method to execute a task and get the health result of it
        /// </summary>
        /// <param name="task">the task that you want to execute</param>
        /// <param name="result">its a out parameter that is not null if complete successfully</param>
        /// <param name="exception">its a out parameter is not null if has a exception</param>
        /// <returns></returns>
        public static IHealthResult ExecuteTaskHealthly(Func<Task<object>> task, out object result, out Exception exception)
        {
            object value = null;

            var healthResult = ExecuteTaskHealthly(() =>
            {
                value = task().Result;
                return Task.CompletedTask;
            }, out exception);
            result = value;

            return healthResult;
        }
        /// <summary>
        ///     Method to execute a task and get the health result of it
        /// </summary>
        /// <param name="task">the task that you want to execute</param>
        /// <param name="exception">its a out parameter is not null if has a exception</param>
        /// <returns>The health result of the task that was executed</returns>
        public static IHealthResult ExecuteTaskHealthly(Func<Task> task, out Exception exception)
        {
            bool success = true;
            var watch = new Stopwatch();
            exception = null;
            try
            {
                watch.Start();
                task();
            }
            catch (Exception ex)
            {
                success = false;
                exception = ex;
            }
            finally
            {
                watch.Stop();
            }

            return new HealthResult(success, watch.Elapsed);
        }
    }
}