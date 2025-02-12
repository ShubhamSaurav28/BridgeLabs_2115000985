/* using System;

class Node
{
    public int UserID;
    public string Name;
    public int Age;
    public List<int> FriendIDs;
    public Node Next;
    public Node(int userID, string name, int age){
        UserID = userID;
        Name = name;
        Age = age;
        FriendIDs = new List<int>();
        Next = null;
    }
}

class SocialMedia{
    private Node head = null;
    public void AddUser(int userID, string name, int age){
        Node newUser = new Node(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
        Console.WriteLine($"User {name} (ID: {userID}) added successfully.");
    }
    private Node SearchUser(int userID){
        Node temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }
    public void AddFriend(int userID1, int userID2){
        Node user1 = SearchUser(userID1);
        Node user2 = SearchUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Add(userID2);
            user2.FriendIDs.Add(userID1);
            Console.WriteLine($"Friendship added between {user1.Name} and {user2.Name}.");
        }
        else
        {
            Console.WriteLine("They are already friends.");
        }
    }
    public void RemoveFriend(int userID1, int userID2){
        Node user1 = SearchUser(userID1);
        Node user2 = SearchUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (user1.FriendIDs.Contains(userID2))
        {
            user1.FriendIDs.Remove(userID2);
            user2.FriendIDs.Remove(userID1);
            Console.WriteLine($"Friendship removed between {user1.Name} and {user2.Name}.");
        }
        else
        {
            Console.WriteLine("They are not friends.");
        }
    }
    public void DisplayFriends(int userID){
        Node user = SearchUser(userID);
        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.WriteLine($"{user.Name}'s Friends:");
        foreach (int friendID in user.FriendIDs)
        {
            Node friend = SearchUser(friendID);
            if (friend != null)
            {
                Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
            }
        }
    }
    public void FindMutualFriends(int userID1, int userID2){
        Node user1 = SearchUser(userID1);
        Node user2 = SearchUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = new List<int>();

        foreach (int friendID in user1.FriendIDs)
        {
            if (user2.FriendIDs.Contains(friendID))
            {
                mutualFriends.Add(friendID);
            }
        }

        if (mutualFriends.Count == 0)
        {
            Console.WriteLine($"{user1.Name} and {user2.Name} have no mutual friends.");
        }
        else
        {
            Console.WriteLine($"Mutual friends of {user1.Name} and {user2.Name}:");
            foreach (int friendID in mutualFriends)
            {
                Node friend = SearchUser(friendID);
                if (friend != null)
                {
                    Console.WriteLine($"- {friend.Name} (ID: {friend.UserID})");
                }
            }
        }
    }
    public void SearchUser(string name){
        Node temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"User found: {temp.Name} (ID: {temp.UserID}), Age: {temp.Age}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("User not found.");
    }
    public void CountFriends(){
        Node temp = head;
        Console.WriteLine("\nFriend Count of Users:");
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} (ID: {temp.UserID}) has {temp.FriendIDs.Count} friends.");
            temp = temp.Next;
        }
    }
    public void DisplayUsers(){
        if (head == null)
        {
            Console.WriteLine("No users in the system.");
            return;
        }

        Node temp = head;
        Console.WriteLine("\nList of Users:");
        while (temp != null)
        {
            Console.WriteLine($"User ID: {temp.UserID}, Name: {temp.Name}, Age: {temp.Age}");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia socialMedia = new SocialMedia();
        socialMedia.AddUser(1, "Alice", 25);
        socialMedia.AddUser(2, "Bob", 22);
        socialMedia.AddUser(3, "Charlie", 27);
        socialMedia.AddUser(4, "David", 23);
        socialMedia.AddUser(5, "Eve", 26);
        socialMedia.DisplayUsers();
        socialMedia.AddFriend(1, 2);
        socialMedia.AddFriend(1, 3);
        socialMedia.AddFriend(2, 3);
        socialMedia.AddFriend(2, 4);
        socialMedia.AddFriend(3, 5);
        socialMedia.DisplayFriends(1);
        socialMedia.DisplayFriends(2);
        socialMedia.FindMutualFriends(1, 2);
        socialMedia.FindMutualFriends(2, 5);
        socialMedia.RemoveFriend(1, 2);
        socialMedia.DisplayFriends(1);
        socialMedia.DisplayFriends(2);
        socialMedia.CountFriends();
    }
}
 */