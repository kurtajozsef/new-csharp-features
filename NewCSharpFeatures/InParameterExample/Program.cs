//main
var foo	= new Foo();
foo.DoStuff(10);

public class Foo
{
	public void DoStuff(in int number)
	{
		// the code below will not compile because number is readonly in this context
		//number++;
		Console.WriteLine(number);
	}
}