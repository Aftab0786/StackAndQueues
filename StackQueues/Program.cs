using StackQueues;
class program
{
    static void Main(string[] args)
    {
        //Stack stack = new Stack();
        //stack.Push(70);
        //stack.Push(30);
        //stack.Push(56);
        //stack.Display();
        //stack.peek();
        //stack.pop();
        //stack.isEmpty();
        //stack.Display();

        Queue queue = new Queue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        queue.Display();
    }
}