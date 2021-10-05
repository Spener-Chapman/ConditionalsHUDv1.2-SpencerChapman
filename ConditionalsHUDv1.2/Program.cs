using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsHUDv1._2
{
    

    
    class Program
    {
        static string Name;
        static string EquipWeapon;
        static int Health;
        static int MaxHealth;
        static bool alive = true;
        static int Lives;
        static string HealthData;
        static int bandit1 = 6;
        static int bandit2 = 9;
        static int banditchief = 25;
        static int banditchiefcritical = 75;
        static int banditchiefflurry = 10;
        static int smallpotion = 25;
        static int largepotion = 50;

        static void ChangeWeapon(int weapon)
        {
            if (weapon < 0)
            {
                weapon = 0;
            }
            if (weapon > 4)
            {
                weapon = 4;
            }
            if (weapon == 0)
            {
                EquipWeapon = "Dagger";
            }
            if (weapon == 1)
            {
                EquipWeapon = "Short Sword";
            }
            if (weapon == 2)
            {
                EquipWeapon = "Battle Axe";
            }
            if (weapon == 3)
            {
                EquipWeapon = "Bow";
            }
            if (weapon == 4)
            {
                EquipWeapon = "Mace";
            }
            

        }

        static void Healthy()
        {
            if (Health >= 100)
            {
                HealthData = "Healthy";
            }
            else if (Health >= 75)
            {
                HealthData = "Hurt";
            }
            else if (Health >= 50)
            {
                HealthData = "Injured";
            }
            else if (Health >= 25)
            {
                HealthData = "Badly Injured";
            }
            else if (Health > 0)
            {
                HealthData = "Severely Injured";
            }
            else if (Health == 0)
            {
                HealthData = "Dead";
            }
        }
        static void TakeDamage(int damage)
        {
            Health = Health - damage;
            if (Health <= 0)
            {
                Health = 0;
                alive = false;
            }
        }
        static void LoseLife()
        {
            if (alive == false)
            {
                Lives = Lives - 1;
                Health = MaxHealth;
                alive = true;
            }
        }
        static void Heal(int potion)
        {
            Health = Health + potion;
            if (Health > MaxHealth)
            {
                Health = MaxHealth;
            }
        }

        static void ShowHud()
        {
            Console.WriteLine("");
            Console.WriteLine("====================");
            Console.WriteLine(Name);
            Console.WriteLine("Lives: " + Lives);
            Console.WriteLine("Status: " + HealthData);
            Console.WriteLine("Weapon: " + EquipWeapon);
            Console.WriteLine("====================");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            Name = "Musu";
            MaxHealth = 100;
            Health = MaxHealth;
            Lives = 3;
            HealthData = "Healthy";
            ChangeWeapon(0);
            
            ShowHud();

            Console.WriteLine(Name + " sneaks into the bandit's stronghold");
            Console.WriteLine("Bandit has noticed you");
            Console.WriteLine("");
            ChangeWeapon(2);
            Console.WriteLine(Name + " equips " + EquipWeapon);
            Console.WriteLine("");
            Console.WriteLine("Bandit attacks for " + bandit1 + " damage!");
            TakeDamage(bandit1);
            Healthy();
            Console.WriteLine("");
            Console.WriteLine(Name + " strikes with his " + EquipWeapon);
            Console.WriteLine("Bandit falls!");

            ShowHud();

            Console.WriteLine("The battle has caught the attention of several bandits!");
            Console.WriteLine("Bandit strikes for " + bandit1 + " damage!");
            Console.WriteLine("A large bandit strikes for " + bandit2 + " damage!");
            Console.WriteLine("Bandit strikes for " + bandit1 + " damage!");
            Console.WriteLine("A buff bandit strikes for " + bandit2 + " damage!");
            TakeDamage(bandit1);
            TakeDamage(bandit2);
            TakeDamage(bandit1);
            TakeDamage(bandit2);
            Healthy();
            Console.WriteLine(Name + " swings wildly with his " + EquipWeapon);
            Console.WriteLine(Name + " defeats two bandits");
            
            ShowHud();

            ChangeWeapon(1);
            Console.WriteLine(Name + " equips " + EquipWeapon);
            Console.WriteLine(Name + " uses a large healing potion and heals himself");
            Heal(largepotion);
            if (Health == MaxHealth)
            {
                Console.WriteLine("Health is maxxed out!");
            }
            Console.WriteLine(Name + " swiftly defeats the bandits with his " + EquipWeapon);

            Healthy();
            ShowHud();

            Console.WriteLine("The bandit chief emerges from his hut");
            Console.WriteLine("Bandit chief swings his axes");
            Console.WriteLine("Swing connects for " + banditchief + " damage!");
            TakeDamage(banditchief);
            Console.WriteLine("");
            Console.WriteLine(Name + " swings his blade");
            Console.WriteLine("It misses");

            Healthy();
            ShowHud();

            Console.WriteLine("Bandit Cheif begins flurry rush!");
            Console.WriteLine("Hits 4 times for " + banditchiefflurry * 4 + " damage!");
            TakeDamage(banditchiefflurry * 4);
            Console.WriteLine("");
            Console.WriteLine(Name + " swings his " + EquipWeapon);
            Console.WriteLine("Bandit takes damage");

            Healthy();
            ShowHud();

            Console.WriteLine("Bandit chief swings his axes");
            Console.WriteLine("Critical hit! Bandit chief deals " + banditchiefcritical + "damage");
            TakeDamage(banditchiefcritical);
            Console.WriteLine(Name + " falls");

            Healthy();
            LoseLife();
            ShowHud();

            Console.WriteLine(Name + " respawans, " + Lives + " remaining");

            Healthy();
            ShowHud();

            ChangeWeapon(3);
            Console.WriteLine(Name + " equips " + EquipWeapon);

            Healthy();
            ShowHud();

            Console.WriteLine(Name + " aims at bandit chief from afar");
            Console.WriteLine("Critical hit! Bandit chief falls");
            Console.WriteLine("");
            Console.WriteLine("The city is now safe from the thieving scum!");
            Console.ReadKey(true);
        }
    }
}
