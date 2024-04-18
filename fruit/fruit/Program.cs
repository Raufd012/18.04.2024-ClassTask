

using fruit.Models;
using System.Reflection;

Apple apple = new Apple(5, "QizilEhmedi", 1, 2);
PineApple pineapple = new PineApple(20, "Mode in America", 25,66);
Orange orange = new Orange(15, "Lenkaran Mehsulu", 5);


Fruit[] basket = { apple, pineapple, orange };


foreach (Fruit fruit in basket)
{
    if (fruit is Apple app)
    {
        Console.WriteLine(app.VitaminA + " " + app.VitaminB);
    }
    else if (fruit is PineApple pine)
    {
        Console.WriteLine(pine.VitaminD + " " + pine.VitaminE);
    }
    else if (fruit is Orange org)
    {
        Console.WriteLine(org.VitaminC);
    }
}
foreach (var fruit in basket)
{

    Type fruitType = fruit.GetType();


    Console.WriteLine($"Type name: {fruitType.Name}");


    FieldInfo[] fields = fruitType.GetFields();


    foreach (var field in fields)
    {
        object value = field.GetValue(fruit);
        Console.WriteLine($"  Field name: {field.Name}, Value: {value}");
    }
}