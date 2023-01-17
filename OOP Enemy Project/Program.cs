#nullable disable

class Char
{
    // Properties
    public string Name { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }

    public Char(string name, int attack, int defense)
    {
        Name = name;
        Attack = attack;
        Defense = defense;
    }

    public string getName()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        return name;
    }

    public void intro()
    {
        Console.WriteLine($"Get ready {Name}");
    }

    public void showStats()
    {
        Console.WriteLine("\nName: " + Name);
        Console.WriteLine("Attack: " + Attack);
        Console.WriteLine("Defense: " + Defense);
    }

    public void attacked(string name)
    {
        Console.WriteLine($"\n{Name} attacked by {name}");
        Defense--;
    }

    public void winLine()
    {
        Console.WriteLine($"\n{Name} Wins!");

    }

    public void deathLine()
    {
        Console.WriteLine($"Oh no! You defeated the great {Name}!");
    }

    public bool promptRestart()
    {
        Console.WriteLine($"Good job {Name}! Do you want to play again (1) or quit (*any other key*)?");
        string playInput = Console.ReadLine();
        if (playInput == "1")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        // "Game" Loop
        while (true)
        {
            // Get player name
            Console.WriteLine("What's your name?");
            string nameInput = Console.ReadLine();

            // Enemy character
            Char enemy = new Char("Jack", 1, 3);

            // Player character
            Char player = new Char(nameInput, 1, 3);

            // Scripted fight
            player.intro();
            player.showStats();
            enemy.showStats();
            enemy.attacked(player.Name);
            player.attacked(enemy.Name);
            enemy.attacked(player.Name);
            player.attacked(enemy.Name);
            enemy.attacked(player.Name);

            // Game Over
            Console.WriteLine("\nMatch Over!");
            enemy.showStats();
            player.showStats();

            // Win line
            player.winLine();

            // Get death line
            enemy.deathLine();

            // Win, play again?
            if (player.promptRestart())
            {
                Console.WriteLine("\nGood Choice!");
            }
            else
            {
                break;
            }
        }

    }
}
