using Briefcase.HealthCheck.Entities;
using Briefcase.HealthCheck.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Briefcase.HealthCheck
{
    /// <summary>
    ///     The class that has all method to get the health of a method
    /// </summary>
    public class HealthExecution : HealthExecutionBase
    {
        /// <summary>
        ///     Method to execute a list of tasks and get the result as a list of health result
        /// </summary>
        /// <param name="healthTests"> Represent a list of tuple value with name and the method </param>
        /// <returns>A list of health result with same order that you pass on paramerter</returns>
        public static List<IHealthResult> ExecuteHealthly(params (string serviceName, Func<Task<object>> Process)[] healthTests)
        {
            List<IHealthResult> results = new List<IHealthResult>();

            foreach ((string serviceName, Func<Task<object>> Process) in healthTests)
            {
                IHealthResult healthTask = ExecuteTaskHealthly(Process, out object taskResult, out Exception exception);

                IHealthResult healthResult = healthTask.Success switch
                {
                    true => new HealthNamedResultResponse(serviceName, healthTask.ElapsedTime, taskResult),
                    false => new HealthNamedResultError(serviceName, healthTask.ElapsedTime, exception)
                };

                results.Add(healthResult);
            }

            return results;
        }
        /// <summary>
        ///     Method to execute a task and get the health result of it
        /// </summary>
        /// <typeparam name="T">Its a generic parameter to get the result of it</typeparam>
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        /// <returns>The health result of the task that was executed</returns>
        public static IHealthResult ExecuteHealthly<T>(string methodName, Func<Task<T>> Process)
        {
            IHealthResult healthTask = ExecuteTaskHealthly(async () => await Process(), out object taskResult, out Exception exception);

            IHealthResult healthResult = healthTask.Success switch
            {
                true => new HealthNamedResultResponse(methodName, healthTask.ElapsedTime, taskResult),
                false => new HealthNamedResultError(methodName, healthTask.ElapsedTime, exception)
            };

            return healthResult;
        }

        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly<T>(Func<Task<T>> Process)
        {
            IHealthResult healthTask = ExecuteTaskHealthly(async () => await Process(), out object taskResult, out Exception exception);

            IHealthResult healthResult = healthTask.Success switch
            {
                true => new HealthResultResponse(healthTask.ElapsedTime, taskResult),
                false => new HealthResultError(healthTask.ElapsedTime, exception)
            };

            return healthResult;
        }
        /// <param name="healthTests"> Represent a list of tuple value with name and the method </param>
        public static List<IHealthResult> ExecuteHealthly(params (string serviceName, Func<Task> Process)[] healthTests)
        {
            List<IHealthResult> results = new List<IHealthResult>();

            foreach ((string serviceName, Func<Task> Process) in healthTests)
            {
                IHealthResult healthTask = ExecuteTaskHealthly(Process, out Exception exception);

                IHealthResult healthResult = healthTask.Success switch
                {
                    true => new HealthNamedResult(serviceName, healthTask.ElapsedTime),
                    false => new HealthNamedResultError(serviceName, healthTask.ElapsedTime, exception)
                };

                results.Add(healthResult);
            }

            return results;
        }
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(string methodName, Func<Task> Process)
        {
            IHealthResult healthTask = ExecuteTaskHealthly(Process, out Exception exception);

            IHealthResult healthResult = healthTask.Success switch
            {
                true => new HealthNamedResult(methodName, healthTask.ElapsedTime),
                false => new HealthNamedResultError(methodName, healthTask.ElapsedTime, exception)
            };

            return healthResult;
        }
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(Func<Task> Process)
        {
            IHealthResult healthTask = ExecuteTaskHealthly(Process, out Exception exception);

            IHealthResult healthResult = healthTask.Success switch
            {
                true => new HealthResult(healthTask.ElapsedTime),
                false => new HealthResultError(healthTask.ElapsedTime, exception)
            };

            return healthResult;
        }
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly<T>(Func<T> Process)
        {
            return ExecuteHealthly(() => Task.FromResult<object>(Process()));
        }
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly<T>(Task<T> Process)
        {
            return ExecuteHealthly(() => Process);
        }
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly<T>(string methodName, Func<T> Process)
        {
            return ExecuteHealthly(methodName, () => Task.FromResult<object>(Process()));
        }
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly<T>(string methodName, Task<T> Process)
        {
            return ExecuteHealthly(methodName, () => Process);
        }
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(Action Process)
        {
            return ExecuteHealthly(() => { Process(); return Task.CompletedTask; });
        }
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(Task Process)
        {
            return ExecuteHealthly(() => Process);
        }
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(string methodName, Action Process)
        {
            return ExecuteHealthly(methodName, () => { Process(); return Task.CompletedTask; });
        }
        /// <param name="methodName">the name of the task that you want to execute</param>
        /// <param name="Process">the task that you want to execute</param>
        public static IHealthResult ExecuteHealthly(string methodName, Task Process)
        {
            return ExecuteHealthly(methodName, () => Process);
        }
    }
}