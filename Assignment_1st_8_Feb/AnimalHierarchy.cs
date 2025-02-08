/* using System;

class Animal{
    protected string name;
    protected int age;
    public Animal(string name,int age){
        this.name = name;
        this.age = age;
    }
    public virtual void MakeSound(){
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog:Animal{
    public Dog(string name,int age):base(name,age){ }
    public override void MakeSound(){
        Console.WriteLine("Dog barks");
    }
}

class Cat:Animal{
    public Cat(string name,int age):base(name,age){ }
    public override void MakeSound(){
        Console.WriteLine("Cat meows");
    }
}

class Bird:Animal{
    public Bird(string name,int age):base(name,age){ }
    public override void MakeSound(){
        Console.WriteLine("Bird chirps");
    }
}

class Program{
    public static void Main(){
        Animal dog = new Dog("Buddy",3);
        Animal cat = new Cat("Whiskers",2);
        Animal bird = new Bird("Tweety",1);
        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();
    }
}
 */