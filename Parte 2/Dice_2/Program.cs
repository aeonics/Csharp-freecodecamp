Random dice = new Random();
int roll1 = dice.Next(); //Genera un número aleatorio entre 0 y Int32.MaxValue
int roll2 = dice.Next(101); //Genera un número aleatorio entre 0 y 100
int roll3 = dice.Next(30, 101); //Genera un número aleatorio entre 30 y 100

Console.WriteLine($"Tirando el dado... {roll1}");
Console.WriteLine($"Tirando el dado... {roll2}");
Console.WriteLine($"Tirando el dado... {roll3}");