Random dice = new Random();

int heroHealth = 100;
int monsterHealth = 100;


do
{
    int damage = dice.Next(1, 10);
    monsterHealth -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monsterHealth} health.");

    if (monsterHealth < 1) continue;

    damage = dice.Next(1, 10);
    heroHealth -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {heroHealth} health.");
   
} while (heroHealth > 0 & monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");

