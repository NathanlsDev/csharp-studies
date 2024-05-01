Stack<int> stack = new Stack<int>();

stack.Push(3);
stack.Push(5);
stack.Push(7);
stack.Push(9);

foreach(int number in stack)
{
  Console.WriteLine(number);
}

Console.WriteLine($"\nRemoved element {stack.Pop()}\n");
stack.Push(11);

foreach(int number in stack)
{
  Console.WriteLine(number);
}