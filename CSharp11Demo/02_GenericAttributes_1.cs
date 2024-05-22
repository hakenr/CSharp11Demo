namespace GenericAtributes;

public class ServiceAttribute : Attribute
{
	public Lifestyle Lifestyle { get; set; }
	public Type ServiceType { get; set; }

}

public class ServiceAttribute<TService> : Attribute
{
	public Lifestyle Lifestyle { get; set; }
}



[Service(ServiceType = typeof(IOtherService), Lifestyle = Lifestyle.Singleton)]
[Service<IOtherService>(Lifestyle = Lifestyle.Singleton)]
public class MyService : IMyService, IOtherService
{ }



public interface IMyService { }
public interface IOtherService { }
public enum Lifestyle
{
	Transient,
	Scoped,
	Singleton,
}