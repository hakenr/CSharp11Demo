namespace Required;

public class Employee
{
	public required int Id { get; init; }
	public string Name { get; init; }
	public DateOnly? BirthDate { get; set; }
}


public class Demo
{
	public static void Run()
	{
		var employee = new Employee()
		{
			Id = 1,
		};

		Console.WriteLine(employee);
	}
}




// 1. Set Name to required
// OPTIONAL: record class, init accessor
// NOTE: properties and fields can be required