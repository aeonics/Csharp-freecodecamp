Random dado = new Random();

int roll1 = dado.Next(1, 7); //Genera un número aleatorio entre 1 y 6
int roll2 = dado.Next(1, 7); //Genera un número aleatorio entre 1 y 6
int roll3 = dado.Next(1, 7); //Genera un número aleatorio entre 1 y 6

int suma = roll1 + roll2 + roll3;
Console.WriteLine($"Dado roll... {roll1} + {roll2} + {roll3} = {suma}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("Tiraste dobles! +2 puntos");
    suma += 2;
}
if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    suma += 6;
}

if (suma >= 15)
{
    Console.WriteLine("Ganaste");
}
if (suma < 15)
{
    Console.WriteLine("Perdiste");
}


