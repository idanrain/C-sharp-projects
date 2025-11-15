Random dice = new(); 

int roll = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll} + {roll2} + {roll3} = Total: {total}");

if ((roll == roll2) || (roll == roll3) || (roll2 == roll3))
{
    if ((roll == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}
