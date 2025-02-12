/* using System;

class Node
{
    public int ProcessID;
    public int BurstTime;
    public int RemainingTime;
    public int Priority;
    public Node Next;
    public Node(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        RemainingTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    private Node head = null;
    private Node tail = null;
    public void AddProcess(int processID, int burstTime, int priority)
    {
        Node newProcess = new Node(processID, burstTime, priority);
        if (head == null)
        {
            head = tail = newProcess;
            tail.Next = head; // Circular link
        }
        else
        {
            tail.Next = newProcess;
            tail = newProcess;
            tail.Next = head;
        }
        Console.WriteLine($"Process {processID} added.");
    }
    private void RemoveProcess(int processID)
    {
        if (head == null)
        {
            return;
        }

        Node temp = head, prev = null;
        do
        {
            if (temp.ProcessID == processID)
            {
                if (temp == head && temp == tail)
                {
                    head = tail = null;
                }
                else if (temp == head)
                {
                    head = head.Next;
                    tail.Next = head;
                }
                else if (temp == tail)
                {
                    prev.Next = head;
                    tail = prev;
                }
                else
                {
                    prev.Next = temp.Next;
                }
                Console.WriteLine($"Process {processID} completed and removed.");
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }
    public void SimulateRoundRobin(int timeQuantum)
    {
        if (head == null)
        {
            Console.WriteLine("No processes to schedule.");
            return;
        }

        int totalTime = 0, totalProcesses = 0, waitingTime = 0, turnaroundTime = 0;
        Node current = head;

        Console.WriteLine("\nStarting Round Robin Scheduling...");
        while (head != null)
        {
            do
            {
                if (current.RemainingTime > 0)
                {
                    int executedTime = Math.Min(current.RemainingTime, timeQuantum);
                    current.RemainingTime -= executedTime;
                    totalTime += executedTime;

                    if (current.RemainingTime == 0)
                    {
                        waitingTime += totalTime - current.BurstTime;
                        turnaroundTime += totalTime;
                        RemoveProcess(current.ProcessID);
                    }
                }
                current = current.Next;
            } while (head != null && current != head);

            if (head != null)
            {
                Console.WriteLine("\nProcesses after this round:");
                DisplayProcesses();
            }
        }

        totalProcesses = turnaroundTime / totalTime;
        Console.WriteLine($"\nAverage Waiting Time: {(double)waitingTime / totalProcesses}");
        Console.WriteLine($"Average Turnaround Time: {(double)turnaroundTime / totalProcesses}");
    }
    public void DisplayProcesses()
    {
        if (head == null)
        {
            Console.WriteLine("No processes in queue.");
            return;
        }

        Node temp = head;
        Console.WriteLine("Process List: ");
        do
        {
            Console.WriteLine($"Process ID: {temp.ProcessID}, Remaining Time: {temp.RemainingTime}, Priority: {temp.Priority}");
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        scheduler.AddProcess(1, 10, 2);
        scheduler.AddProcess(2, 5, 1);
        scheduler.AddProcess(3, 8, 3);
        scheduler.AddProcess(4, 12, 2);

        scheduler.DisplayProcesses();

        int timeQuantum = 4;
        scheduler.SimulateRoundRobin(timeQuantum);
    }
}
 */