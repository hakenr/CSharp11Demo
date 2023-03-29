namespace ListPatterns_SlicePattern;

public class Demo
{
	public static void Run()
	{
		Console.WriteLine(new[] { 1, 2, 3, 4, 5 } is [> 0, > 0, ..]);  // True
		Console.WriteLine(new[] { 1, 1 } is [_, _, ..]);  // True
		Console.WriteLine(new[] { 0, 1, 2, 3, 4 } is [> 0, > 0, ..]);  // False
		Console.WriteLine(new[] { 1 } is [1, 2, ..]);  // False

		Console.WriteLine(new[] { 1, 2, 3, 4 } is [.., > 0, > 0]);  // True
		Console.WriteLine(new[] { 2, 4 } is [.., > 0, 2, 4]);  // False
		Console.WriteLine(new[] { 2, 4 } is [.., 2, 4]);  // True

		Console.WriteLine(new[] { 1, 2, 3, 4 } is [>= 0, .., 2 or 4]);  // True
		Console.WriteLine(new[] { 1, 0, 0, 1 } is [1, 0, .., 0, 1]);  // True
		Console.WriteLine(new[] { 1, 0, 1 } is [1, 0, .., 0, 1]);  // False


		void MatchMessage(string message)
		{
			var result = message is ['a' or 'A', .. var s, 'a' or 'A']
				? $"Message {message} matches; inner part is {s}."
				: $"Message {message} doesn't match.";
			Console.WriteLine(result);
		}

		MatchMessage("aBBA");  // output: Message aBBA matches; inner part is BB.
		MatchMessage("apron");  // output: Message apron doesn't match.



		void Validate(int[] numbers)
		{
			var result = numbers is [< 0, .. { Length: 2 or 4 }, > 0] ? "valid" : "not valid";
			Console.WriteLine(result);
		}

		Validate(new[] { -1, 0, 1 });  // output: not valid
		Validate(new[] { -1, 0, 0, 1 });  // output: valid
	}
}


// SLICE pattern (..) - matches any sequence of elements (incl. empty sequence)
// DISCARD pattern (_) - matches any element (single)