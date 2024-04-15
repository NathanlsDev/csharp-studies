Queue<int> queue = new Queue<int>();

queue.Enqueue(2);
queue.Enqueue(4);
queue.Enqueue(6);
queue.Enqueue(8);

foreach(int element in queue)
{
  Console.WriteLine(element);
}

Console.WriteLine($"\nRemoved element {queue.Dequeue()}\n");
queue.Enqueue(10);

foreach(int element in queue)
{
  Console.WriteLine(element);
}