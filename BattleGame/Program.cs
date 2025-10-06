class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("You're about to witness BLOOD! Welcome to Battle Game!");
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();

        Random random = new Random();
        int heroAttack;
        int monsterAttack;

        // Hero
        Hero hero = new Hero("Gon", 10);

        // Monster
        Monster monster = new Monster("Voldik", 10);

        // Open
        Console.WriteLine($"{hero.Name} will face {monster.Name} in this combat!");

        while (hero.HP > 0 && monster.HP > 0)
        {
            heroAttack = random.Next(1, 11);
            monster.HP -= heroAttack;
            int monsterHpShown = Math.Max(monster.HP, 0); // clamp, so that negatives don't diplay
            Console.WriteLine($"Hero attacked with a sword swipe! {monster.Name} was damaged and lost {heroAttack} health points and now has {monsterHpShown} health.");
            if (monster.HP <= 0) break;

            monsterAttack = random.Next(1, 11);
            hero.HP -= monsterAttack;
            int heroHpShown = Math.Max(hero.HP, 0); // clamp
            Console.WriteLine($"Monster attacked with its huge claws! {hero.Name} was damaged and lost {monsterAttack} health points and now has {heroHpShown} health.");
            if (hero.HP <= 0) break;
        }

        if (hero.HP <= 0) Console.WriteLine($"{monster.Name} wins!");
        if (monster.HP <= 0) Console.WriteLine($"{hero.Name} wins!");

        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}