using System;
namespace BattleGame
{
    public class Warrior
    {
		public string Name { get; set; } = "Warrior";
		public double Health { get; set; } = 0;
		public double AttackMax { get; set; } = 0;
		public double BlockMax { get; set; } = 0;

		// Instantiate Name, Health, Attack Max, Block Max
        
        public Warrior(string name, double health, double attackMax, double blockMax)
        {
			Name = name;
			Health = health;
			AttackMax = attackMax;
			BlockMax = blockMax;
        }

		// Random numbers
		Random random = new Random();

        // Attack method
		// Generate random attack from 1 to max attack
		public double Attack() 
		{
			return random.Next(1, (int)AttackMax);
		}

        // Block method
        // Generate random block from 1 to max block
        public double Block()
		{
			return random.Next(1, (int)BlockMax);
		}
    }
}
