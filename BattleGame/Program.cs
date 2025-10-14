class Program
{
    static void Main()
    {

        // prolog
        Console.Clear();
        Console.WriteLine("0=={=================- X -=================}==O");
        Console.WriteLine("");
        Console.WriteLine("You're about to witness BLOOD! Welcome to Battle Game!");
        Console.ReadLine();

        // variables
        Random random = new Random();
        int heroAttack;
        int monsterAttack;
        string[] monsterSet = { "Voldik", "Sheikou", "Zaghan", "Baba Yaru" };

        // Hero
        Console.WriteLine("Tell me your name, you lousy doomed one..");
        Hero hero = new Hero(Console.ReadLine(), 10);

        // Monster
        Monster monster = new Monster(monsterSet[random.Next(monsterSet.Length)], 10);

        // Gamestart
        Console.Clear();
        Console.WriteLine($"{hero.Name} will face {monster.Name} in this combat!");
        Console.WriteLine("");

        while (hero.HP > 0 && monster.HP > 0)
        {
            heroAttack = random.Next(1, 11);
            monster.HP -= heroAttack;
            int monsterHpShown = Math.Max(monster.HP, 0); // clamp, so that negatives don't diplay
            Console.WriteLine($"{hero.Name} attacked with a sword swipe! {monster.Name} was damaged and lost {heroAttack} health points and now has {monsterHpShown} health.");
            if (monster.HP <= 0) break;

            monsterAttack = random.Next(1, 11);
            hero.HP -= monsterAttack;
            int heroHpShown = Math.Max(hero.HP, 0); // clamp
            Console.WriteLine($"Monster attacked with its huge claws! {hero.Name} was damaged and lost {monsterAttack} health points and now has {heroHpShown} health.");
            if (hero.HP <= 0) break;
        }
        
        Console.WriteLine("");
        if (hero.HP <= 0) Console.WriteLine($"{monster.Name}, the nasty monster, wins...");
        if (monster.HP <= 0) Console.WriteLine($"{hero.Name}, our Hero, wins!");

        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}