Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if ((daysUntilExpiration <= 10) && (daysUntilExpiration > 5))
{
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if ((daysUntilExpiration <= 5) && (daysUntilExpiration > 1))
{
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription will expire in " + daysUntilExpiration + " days");
    Console.WriteLine("Renew now and save 10%!");
}
if (daysUntilExpiration == 1)
{
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
}
if (daysUntilExpiration == 0)
{
    Console.WriteLine(daysUntilExpiration);
    Console.WriteLine("Your subscription has expired!");
    
}