/* using System;

class Node{
    public string Text;
    public Node Prev;
    public Node Next;
    public Node(string text){
        Text = text;
        Prev = null;
        Next = null;
    }
}

class TextEditor{
    private Node head = null;
    private Node current = null;
    private int maxHistory = 10;
    private int historyCount = 0;
    public void AddState(string newText){
        Node newNode = new Node(newText);
        if (head==null){
            head = newNode;
            current = newNode;
        }
        else{
            current.Next = null;
            newNode.Prev = current;
            current.Next = newNode;
            current = newNode;
            if (historyCount==maxHistory){
                head = head.Next;
                head.Prev = null;
            }
            else{
                historyCount++;
            }
        }
        Console.WriteLine($"Added new state: \"{current.Text}\"");
    }
    public void Undo(){
        if(current==null || current.Prev==null){
            Console.WriteLine("Undo not possible. No previous state.");
            return;
        }
        current = current.Prev;
        Console.WriteLine($"Undo performed. Current text: \"{current.Text}\"");
    }
    public void Redo(){
        if(current==null || current.Next==null){
            Console.WriteLine("Redo not possible. No next state.");
            return;
        }
        current = current.Next;
        Console.WriteLine($"Redo performed. Current text: \"{current.Text}\"");
    }
    public void DisplayCurrentText(){
        if(current==null){
            Console.WriteLine("No text history available.");
            return;
        }
        Console.WriteLine($"Current Text: \"{current.Text}\"");
    }
}

class Program{
    public static void Main(){
        TextEditor editor = new TextEditor();
        editor.AddState("Hello");
        editor.AddState("Hello, World!");
        editor.AddState("Hello, World! This is a text editor.");
        editor.DisplayCurrentText();
        editor.Undo();
        editor.Undo();
        editor.DisplayCurrentText();
        editor.Redo();
        editor.DisplayCurrentText();
        editor.AddState("New edited text after undo.");
        editor.DisplayCurrentText();
        editor.Redo();
    }
}
 */