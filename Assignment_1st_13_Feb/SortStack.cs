/* using System;

class SortStack{
    public static void Sort(Stack<int> stack){
        if(stack.Count>0){
            int temp = stack.Pop();
            Sort(stack);
            Insert(stack,temp);
        }
    }
    private static void Insert(Stack<int> stack,int element){
        if(stack.Count==0 || stack.Peek()<=element){
            stack.Push(element);
            return;
        }
        int temp = stack.Pop();
        Insert(stack,element);
        stack.Push(temp);
    }
    public static void Main(){
        Stack<int> stack = new Stack<int>();
        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        Sort(stack);
        while(stack.Count>0){
            Console.WriteLine(stack.Pop());
        }
    }
}
 */