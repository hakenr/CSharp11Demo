namespace RawStringLiterals;

public class Demo
{
	public static void Run()
	{
		var text = """
			<html>
				<head>
					<title>Demo</title>
				</head>
				<body>
					<h1>My Page</h1>
					<p class="intro">This is my page describing string interpolation.</p>
					<code>var demo = $"Show me the number {i}."</p>
				</body>
			</html>
			""";

		Console.WriteLine(text);
	}
}

// NOTE: Indentation trimming (closing """)
// OPTIONAL: String interpolation - parametrize the <title> tag
// OPTIONAL: More quotes
// OPTIONAL: More $$$