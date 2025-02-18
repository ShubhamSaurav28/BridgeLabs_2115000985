/* using System;
using System.Collections.Generic;

abstract class WarehouseItem{
    public string Name{get;set;}
    public WarehouseItem(string name) => Name = name;
}

class Electronics:WarehouseItem{
	public Electronics(string name):base(name){}
}

class Groceries:WarehouseItem{
	public Groceries(string name):base(name){}
}

class Furniture:WarehouseItem{
	public Furniture(string name):base(name){}
}

class Storage<T> where T:WarehouseItem{
    private List<T> items = new List<T>();
    public void AddItem(T item) => items.Add(item);
    public void DisplayItems(){
        foreach(var item in items){
            Console.WriteLine(item.Name);
		}
    }
}

class Program{
    public static void Main(){
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop"));
        electronicsStorage.DisplayItems();
    }
} */