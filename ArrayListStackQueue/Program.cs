namespace ArrayListStackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            Console.WriteLine(numbers.Pop());
            Console.WriteLine(numbers.Peek());
            numbers.Pop();
            Console.WriteLine(numbers.Peek());
        }
    }
}
