namespace JeuDuSerpentTDD.Classes
{
    internal class Player
    {
        public string Name { get; internal set; }
        public int Position { get; internal set; }

        public Player(string Name)
        {
            if (Name == "")
                throw new System.ArgumentException("Name cannot be empty");
            this.Name = Name;
            this.Position = 0;
        }

        internal int Roll()
        {
            Console.WriteLine($"{this.Name} lance le dé");
            int number = Dice.Roll();
            handleMove(number);
            return number;
        }

        private void handleMove(int number)
        {
            WriteMovementInfo(number);
            ChangePosition(number);
        }

        private void WriteMovementInfo(int number)
        {
            string endSentence = (this.Position + number > 50) ? 
                "retourne à la case 25" : 
                $"avance vers la case {this.Position + number} ";
            Console.WriteLine($"{this.Name} est sur la case {this.Position} et ${endSentence}");
        }
        
        private void ChangePosition(int number)
        {
            Position = (Position + number > 50) ? 25 : Position + number;
        }
    }
}