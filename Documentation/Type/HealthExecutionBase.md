<h4 style='color: gray;margin:0; padding:0;'> [Briefcase.HealthCheck, Version=0.1.0.0, Culture=neutral, PublicKeyToken=null]</h4>

#### <small>namespace [Briefcase.HealthCheck](../Namespace/Briefcase.HealthCheck.md);</small>

#### <small>HealthExecutionBase</small>

<i>

```csharp
public abstract class HealthExecutionBase
{

	///<summary>
	///	Method to execute a task and get the health result of it
	///</summary>
	public static IHealthResult ExecuteTaskHealthly(Func<Task<Object>> task, out Object result, out Exception exception); +1 overloads
}
```

</i>


---

#### ExecuteTaskHealthly

<small><b>Return:</b> IHealthResult</small>

<small><b>Summary</b></small>

<small>Method to execute a task and get the health result of it
</small>

<i>

```csharp
public abstract class HealthExecutionBase
{

	///<summary>
	///	Method to execute a task and get the health result of it
	///</summary>
	///<returns>The health result of the task that was executed</returns>
	///<param name='task'>the task that you want to execute</param>
	///<param name='exception'>its a out parameter is not null if has a exception</param>
	public static IHealthResult ExecuteTaskHealthly(Func<Task> task, out Exception exception);

	///<summary>
	///	Method to execute a task and get the health result of it
	///</summary>
	///<param name='task'>the task that you want to execute</param>
	///<param name='result'>its a out parameter that is not null if complete successfully</param>
	///<param name='exception'>its a out parameter is not null if has a exception</param>
	public static IHealthResult ExecuteTaskHealthly(Func<Task<Object>> task, out Object result, out Exception exception);
}
```

</i>