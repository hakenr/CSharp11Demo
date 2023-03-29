using System.Numerics;

namespace GenericMath;

public class Demo
{
	public int Add(int a, int b) => a + b;
	public decimal Add(decimal a, decimal b) => a + b;
	public double Add(double a, double b) => a + b;

	public T Add<T>(T a, T b)
		where T : INumber<T>
	{
		return a + b;
	}

	public T Divide<T>(T a, T b)
		where T : INumber<T>
	{
		if (b == T.Zero)
		{
			throw new DivideByZeroException();
		}
		return a / b;
	}
}
