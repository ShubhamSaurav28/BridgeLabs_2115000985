/* using System;

class Node{
    public int ItemID;
    public string ItemName;
    public int Quantity;
    public double Price;
    public Node Next;
    public Node(int itemId,string itemName,int quantity,double price){
        ItemID = itemId;
        ItemName = itemName;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class InventoryManager{
    private Node head;
    public void AddItemAtBeginning(int itemId,string itemName,int quantity,double price){
        Node newItem = new Node(itemId,itemName,quantity,price);
        newItem.Next = head;
        head = newItem;
        Console.WriteLine("Item added at the beginning.");
    }
    public void AddItemAtEnd(int itemId,string itemName,int quantity,double price){
        Node newItem = new Node(itemId,itemName,quantity,price);
        if (head == null){
            head = newItem;
        }
        else{
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newItem;
        }
        Console.WriteLine("Item added at the end.");
    }
    public void AddItemAtPosition(int position, int itemId, string itemName, int quantity, double price){
        if (position <= 0){
            Console.WriteLine("Invalid position.");
            return;
        }

        Node newItem = new Node(itemId, itemName, quantity, price);

        if (position == 1){
            newItem.Next = head;
            head = newItem;
            Console.WriteLine("Item added at position 1.");
            return;
        }

        Node temp = head;
        for (int i = 1; temp != null && i < position - 1; i++){
            temp = temp.Next;
        }

        if (temp == null){
            Console.WriteLine("Position out of range.");
            return;
        }

        newItem.Next = temp.Next;
        temp.Next = newItem;
        Console.WriteLine($"Item added at position {position}.");
    }
    public void RemoveItem(int itemId){
        if (head == null){
            Console.WriteLine("Inventory is empty.");
            return;
        }

        Node temp = head, prev = null;

        if (head.ItemID == itemId){
            head = head.Next;
            Console.WriteLine($"Item {itemId} removed.");
            return;
        }

        while (temp != null && temp.ItemID != itemId){
            prev = temp;
            temp = temp.Next;
        }

        if (temp == null){
            Console.WriteLine("Item not found.");
            return;
        }

        prev.Next = temp.Next;
        Console.WriteLine($"Item {itemId} removed.");
    }
    public void UpdateQuantity(int itemId, int newQuantity){
        Node temp = head;
        while (temp != null){
            if (temp.ItemID == itemId)
            {
                temp.Quantity = newQuantity;
                Console.WriteLine($"Quantity updated for Item {itemId}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }
    public void SearchByID(int itemId){
        Node temp = head;
        while (temp != null){
            if (temp.ItemID == itemId)
            {
                Console.WriteLine($"Item Found: ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }
    public void SearchByName(string itemName){
        Node temp = head;
        while (temp != null){
            if (temp.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Item Found: ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Item not found.");
    }
    public void CalculateTotalValue(){
        double totalValue = 0;
        Node temp = head;
        while (temp != null){
            totalValue += temp.Quantity * temp.Price;
            temp = temp.Next;
        }
        Console.WriteLine($"Total Inventory Value: {totalValue}");
    }
    public void SortByName(bool ascending = true){
        if (head == null) return;
        for (Node i = head; i != null; i = i.Next){
            for (Node j=i.Next;j!=null;j=j.Next){
                if((ascending && string.Compare(i.ItemName,j.ItemName,StringComparison.OrdinalIgnoreCase) >0) || (!ascending && string.Compare(i.ItemName,j.ItemName,StringComparison.OrdinalIgnoreCase)<0)){
                    SwapItems(i, j);
                }
            }
        }
        Console.WriteLine($"Inventory sorted by Name ({(ascending ? "Ascending" : "Descending")}).");
    }
    public void SortByPrice(bool ascending = true){
        if (head == null) return;
        for(Node i=head;i!= null;i=i.Next){
            for(Node j=i.Next;j!=null;j=j.Next){
                if((ascending && i.Price>j.Price) || (!ascending && i.Price<j.Price)){
                    SwapItems(i,j);
                }
            }
        }
        Console.WriteLine($"Inventory sorted by Price ({(ascending ? "Ascending" : "Descending")}).");
    }
    private void SwapItems(Node a, Node b){
        (a.ItemID, b.ItemID) = (b.ItemID, a.ItemID);
        (a.ItemName, b.ItemName) = (b.ItemName, a.ItemName);
        (a.Quantity, b.Quantity) = (b.Quantity, a.Quantity);
        (a.Price, b.Price) = (b.Price, a.Price);
    }
    public void DisplayInventory(){
        if(head==null){
            Console.WriteLine("Inventory is empty.");
            return;
        }
        Node temp = head;
        Console.WriteLine("Inventory Items:");
        while(temp!=null){
            Console.WriteLine($"ID: {temp.ItemID}, Name: {temp.ItemName}, Quantity: {temp.Quantity}, Price: {temp.Price}");
            temp = temp.Next;
        }
    }
}

class Program{
    public static void Main(){
        InventoryManager inventory = new InventoryManager();
        inventory.AddItemAtBeginning(101,"Laptop",5,800);
        inventory.AddItemAtEnd(102,"Mouse",10,20);
        inventory.AddItemAtPosition(2,103,"Keyboard",7,50);
        inventory.DisplayInventory();
        inventory.UpdateQuantity(102,15);
        inventory.SearchByID(103);
        inventory.SortByName();
        inventory.SortByPrice(false);
        inventory.CalculateTotalValue();
        inventory.RemoveItem(101);
        inventory.DisplayInventory();
    }
}
 */