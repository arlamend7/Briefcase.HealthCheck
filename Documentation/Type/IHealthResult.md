<h4 style='color: gray;margin:0; padding:0;'> [Briefcase.HealthCheck, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]</h4>

#### <small>namespace [Briefcase.HealthCheck.Entities.Interfaces](../Namespace/Briefcase.HealthCheck.Entities.Interfaces.md);</small>

#### <small>IHealthResult</small>

<i>

```csharp
public interface IHealthResult
{

	///<summary>True value on this property represent a conclusion without exception</summary>
	Boolean Success { get; }

	///<summary>Its represent how much time it took to complete the full execution</summary>
	TimeSpan ElapsedTime { get; }
}
```

</i>
