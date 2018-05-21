using System;
namespace BattleGame
{
    public class Battle
    {
        public Battle()
        {
			
        }

		// StartFight
        // Receives Warrior1 Warrior2

		public static void StartFight(Warrior warrior1, Warrior warrior2)
        {

			// Loop giving each warrior a chance to attack 
			// and block each turn until one dies

			while(true)
			{
				if(GetAttackResult(warrior1, warrior2) == "Game Over")
				{
					Console.WriteLine("Game Over");
					break;
				}

				if (GetAttackResult(warrior2, warrior1) == "Game Over")
				{
					Console.WriteLine("Game Over");
					break;
				}
			}


        }

		// GetAttackResult
        // Receives WarriorA, WarriorB

		public static string GetAttackResult(Warrior warriorA, Warrior warriorB) 
		{
			// Calculate 1 warrior's attack and the 
			// others block
			double attack = warriorA.Attack() - warriorB.Block();

			if(attack > 0 && warriorB.Health - attack < 0) 
			{
				warriorB.Health = 0;
			} else if (attack > 0 && warriorB.Health - attack > 0)
			{
				warriorB.Health -= attack;
			} else attack = 0;

			// Print out info on who attacked who and for how much damage
			Console.WriteLine($"{warriorA.Name} attacked {warriorB.Name} with a damage of {attack}");


			// Provide output on the change in health
			Console.WriteLine($"{warriorB.Name}'s health has been reduced to {warriorB.Health} \n");


            // Check if the warriors health fell below 0 and if so
            // print a message and then send a response that will end the loop
			if(warriorB.Health <= 0) 
			{
				Console.WriteLine($"{warriorB.Name} has died and {warriorA.Name} is victorious \n");
				return "Game Over";
			} 

			return "";
          

		}
        

    }
}
