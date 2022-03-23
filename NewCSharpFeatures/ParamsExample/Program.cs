//main
var foo = new Foo();
foo.DoStuff(1,2,3,4,5,6);

public class Foo
{
	public void DoStuff(params int[] numbers)
	{
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(numbers[i]);
		}
	}
}