
//string[] fruit = { "apples", "bananas", "oranges", 3, true };
string[] fruit = new string[3];

fruit[0] = "apples";
fruit[1] = "bananas";
fruit[2] = "oranges";

Console.WriteLine($"{fruit[0]}, {fruit[1]}, {fruit[2]}");

int fruitarraylenght = fruit.Length;
Console.WriteLine($"there are{fruitarraylenght} in your array.");

for (int i = 0;i < fruitarraylenght;i++)
{
    fruit[i] = fruit[i].Replace(fruit[i][0], char.ToUpper(fruit[i][0]));
}

foreach(string element in fruit)
{
    Console.WriteLine(element);
}