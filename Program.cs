using System.Formats.Asn1;

Random random = new();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
// your code goes here

if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
}

if (daysUntilExpiration == 0)
{
    ;Console.Write("Your subscription has expired.");
}

else if (daysUntilExpiration == 1)
{
    Console.Write($"Your subscription expires within a day! Renew now and save {discountPercentage}%.");
}
else if (daysUntilExpiration <= 5)

{
    Console.Write($"Your subscription expires in {daysUntilExpiration} days! Renew now and save {discountPercentage}%.");
}
else if (daysUntilExpiration <= 10)
{
    Console.Write("Your subscription will expire soon. Renew now!");
}