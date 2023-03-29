namespace ListPatterns;

public class Demo
{
	public static void Run()
	{
		var seq1 = new[] { 1, 2, 3 };
		if (seq1 is [1, 2, 3])
		{
			Console.WriteLine("seq1 is [1, 2, 3]");
		}

		var list = new List<string>() { "a", "b", "c" };
		if (list is [var first, "b", var last])
		{
			Console.WriteLine($"First: {first}, Last: {last}");
		}
	}
}