<h4 style='color: gray;margin:0; padding:0;'> [Briefcase.HealthCheck, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null]</h4>

#### <small>namespace [Briefcase.HealthCheck](../Namespace/Briefcase.HealthCheck.md);</small>

#### <small>HealthExecution</small>

<i>

```csharp
public class HealthExecution : HealthExecutionBase
{

	///<summary>
	///	Method to execute a list of tasks and get the result as a list of health result
	///</summary>
	///<returns>A list of health result with same order that you pass on paramerter</returns>
	public static List<IHealthResult> ExecuteHealthly(ValueTuple<String, Func<Task<Object>>>[] healthTests); +1 overloads

	///<summary>
	///	Method to execute a task and get the health result of it
	///</summary>
	///<returns>The health result of the task that was executed</returns>
	public static IHealthResult ExecuteHealthly(String methodName, Func<Task<T>> Process); +11 overloads
}
```

</i>


---

#### ExecuteHealthly

<small><b>Return:</b> List\<IHealthResult></small>

<small>A list of health result with same order that you pass on paramerter</small>

<small><b>Summary</b></small>

<small>Method to execute a list of tasks and get the result as a list of health result
</small>

<i>

```csharp
public class HealthExecution : HealthExecutionBase
{

	///<summary>
	///	Method to execute a list of tasks and get the result as a list of health result
	///</summary>
	///<returns>A list of health result with same order that you pass on paramerter</returns>
	///<param name='healthTests'> Represent a list of tuple value with name and the method </param>
	public static List<IHealthResult> ExecuteHealthly(ValueTuple<String, Func<Task<Object>>>[] healthTests);

	///<param name='healthTests'> Represent a list of tuple value with name and the method </param>
	public static List<IHealthResult> ExecuteHealthly(ValueTuple<String, Func<Task>>[] healthTests);
}
```

</i>

---

#### ExecuteHealthly

<small><b>Return:</b> IHealthResult</small>

<small>The health result of the task that was executed</small>

<small><b>Summary</b></small>

<small>Method to execute a task and get the health result of it
</small>

<i>

```csharp
public class HealthExecution : HealthExecutionBase
{

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Func<Task<T>> Process);

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Func<Task> Process);

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Func<T> Process);

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Task<T> Process);

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Action Process);

	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(Task Process);

	///<summary>
	///	Method to execute a task and get the health result of it
	///</summary>
	///<returns>The health result of the task that was executed</returns>
	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Func<Task<T>> Process);

	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Func<Task> Process);

	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Func<T> Process);

	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Task<T> Process);

	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Action Process);

	///<param name='methodName'>the name of the task that you want to execute</param>
	///<param name='Process'>the task that you want to execute</param>
	public static IHealthResult ExecuteHealthly(String methodName, Task Process);
}
```

</i>

#### <small>Related items</small>

[HealthExecutionBase](HealthExecutionBase.md)