/* using System;

interface IMealPlan{ 
	string GetMealType(); 
}

class VegetarianMeal:IMealPlan{ 
	public string GetMealType() => "Vegetarian Meal";
}
class VeganMeal:IMealPlan{
	public string GetMealType() => "Vegan Meal";
}

class Meal<T> where T:IMealPlan{
    private T meal;
    public Meal(T meal) => this.meal = meal;
    public void ShowMeal() => Console.WriteLine(meal.GetMealType());
}

class Program{
    public static void Main(){
        var vegMeal = new Meal<VegetarianMeal>(new VegetarianMeal());
        vegMeal.ShowMeal();
    }
} */