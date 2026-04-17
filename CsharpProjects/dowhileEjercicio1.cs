int herolife = 10;
int monsterlife = 10;

Random random = new Random();

int atack;
do
{
    atack = random.Next(1, 10);
    monsterlife -= atack;

    Console.WriteLine($"el heroe le quita {atack} pts. de vida al moustro \nvida del moustro: {(monsterlife > 0 ? monsterlife : 0)}");
    if (monsterlife <= 0) continue;

    atack = random.Next(1, 10);
    herolife -= atack;
    Console.WriteLine($"el moustro le quita {atack} pts. de vida al moustro \n vida del hero: {(herolife > 0 ? herolife : 0)}");
} while (herolife > 0 && monsterlife > 0);

Console.WriteLine($"el {(herolife <= 0 ? "moustro" : "heroe")} derroto al {(herolife <= 0 ? "heroe" : "moustro")}");
