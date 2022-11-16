string[] snacks = { "shushi", "pizza", "burger", "chicken wings", "Asian trakeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");