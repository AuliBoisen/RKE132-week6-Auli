string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaway" }; 

random rnd = new Random();

int randomindex =rnd.Next(0, snacks.Length);

Console.WriteLine($"tonight we are going to eat {snacks[randomindex]}.");