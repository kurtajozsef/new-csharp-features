//main
var foo = new Foo() { num = 1 };
Console.WriteLine(foo.num);
ref int foo2 = ref foo.GetFoo();
// changing foo2 changes foo.num as its reference is taken from GetFoo()
foo2 = 5;
Console.WriteLine(foo.num);

public class Foo
{
	public int num;
	public ref int GetFoo()
	{
		return ref num;
	}
}