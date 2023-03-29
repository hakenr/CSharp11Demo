namespace GenericAtributes;

public class Service<TService> : Attribute
{
	public Lifestyle Lifestyle { get; set; }
}



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