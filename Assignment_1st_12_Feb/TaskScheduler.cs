/* using System;

class Node{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Node Next;
    public Node(int taskId,string taskName,int priority, DateTime dueDate){
        TaskID = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler{
    private Node head;
    private Node currentTask;
    public void AddTaskAtBeginning(int taskId,string taskName,int priority,DateTime dueDate){
        Node newTask = new Node(taskId,taskName,priority,dueDate);
        if(head==null){
            head = newTask;
            newTask.Next = head;
        }
        else{
            Node temp = head;
            while(temp.Next!=head){
                temp = temp.Next;
            }
            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }
        Console.WriteLine("Task added at the beginning.");
    }
    public void AddTaskAtEnd(int taskId,string taskName,int priority,DateTime dueDate){
        Node newTask = new Node(taskId,taskName,priority,dueDate);
        if(head==null){
            head = newTask;
            newTask.Next = head;
        }
        else{
            Node temp = head;
            while(temp.Next!=head){
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
        Console.WriteLine("Task added at the end.");
    }
    public void AddTaskAtPosition(int position,int taskId,string taskName,int priority,DateTime dueDate){
        if(position<=0){
            Console.WriteLine("Invalid position.");
            return;
        }
        Node newTask = new Node(taskId, taskName, priority, dueDate);
        if(position==1){
            AddTaskAtBeginning(taskId, taskName, priority, dueDate);
            return;
        }
        Node temp = head;
        for(int i=1;temp.Next!=head && i<position-1;i++){
            temp = temp.Next;
        }
        newTask.Next = temp.Next;
        temp.Next = newTask;
        Console.WriteLine($"Task added at position {position}.");
    }
    public void RemoveTask(int taskId){
        if(head==null){
            Console.WriteLine("No tasks available.");
            return;
        }
        Node temp = head, prev = null;
        if(head.TaskID==taskId){
            if(head.Next==head){
                head = null;
            }
            else{
                Node last = head;
                while(last.Next!=head){
                    last = last.Next;
                }
                head = head.Next;
                last.Next = head;
            }
            Console.WriteLine($"Task {taskId} removed.");
            return;
        }
        do{
            prev = temp;
            temp = temp.Next;
        }while(temp!=head && temp.TaskID!=taskId);
        if(temp.TaskID==taskId){
            prev.Next = temp.Next;
            Console.WriteLine($"Task {taskId} removed.");
        }
        else{
            Console.WriteLine("Task not found.");
        }
    }
    public void ViewCurrentTask(){
        if (head == null){
            Console.WriteLine("No tasks available.");
            return;
        }
        if (currentTask == null){
            currentTask = head;
        }

        Console.WriteLine($"Current Task: ID: {currentTask.TaskID}, Name: {currentTask.TaskName}, Priority: {currentTask.Priority}, Due Date: {currentTask.DueDate.ToShortDateString()}");
        currentTask = currentTask.Next;
    }
    public void DisplayTasks(){
        if (head == null)
        {
            Console.WriteLine("No tasks in the list.");
            return;
        }

        Node temp = head;
        Console.WriteLine("Task List:");
        do
        {
            Console.WriteLine($"ID: {temp.TaskID}, Name: {temp.TaskName}, Priority: {temp.Priority}, Due Date: {temp.DueDate.ToShortDateString()}");
            temp = temp.Next;
        } while (temp != head);
    }
    public void SearchTaskByPriority(int priority){
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        Node temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task Found: ID: {temp.TaskID}, Name: {temp.TaskName}, Due Date: {temp.DueDate.ToShortDateString()}");
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tasks found with this priority.");
        }
    }
}

class Program{
    public static void Main(){
        TaskScheduler scheduler = new TaskScheduler();
        scheduler.AddTaskAtBeginning(1,"Task A",1,new DateTime(2025,3,10));
        scheduler.AddTaskAtEnd(2,"Task B",2,new DateTime(2025,3,12));
        scheduler.AddTaskAtPosition(2,3,"Task C",1,new DateTime(2025,3,15));
        Console.WriteLine("\nAll Tasks:");
        scheduler.DisplayTasks();
        Console.WriteLine("\nSearching for tasks with priority 1:");
        scheduler.SearchTaskByPriority(1);
        Console.WriteLine("\nViewing tasks in circular order:");
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        Console.WriteLine("\nRemoving Task 2:");
        scheduler.RemoveTask(2);
        scheduler.DisplayTasks();
    }
}
  */