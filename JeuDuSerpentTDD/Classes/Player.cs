namespace JeuDuSerpentTDD.Classes
{
    internal class Player
    {
        public string Name { get; internal set; }
        public int Position { get; internal set; }
        public int MaxPosition { get; internal set; }

        public Player(string Name)
        {
            if (Name == "")
                throw new ArgumentException("Name cannot be empty");
            
            this.Name = Name;
            this.Position = 0;
        }

        internal int Roll()
        {
            Console.WriteLine($"{this.Name} lance le dé");
            int diceNumber = Dice.Roll();
            
            handleMove(diceNumber);
            
            return diceNumber;
        }

        // public for test
        public void handleMove(int diceNumber)
        {
            int lastPosition = this.Position;
            
            ChangePosition(diceNumber);
            WriteMovementInfo(lastPosition, diceNumber);

            if (isMultipleOfTen())
                Roll();
        }

        private void WriteMovementInfo(int lastPosition,int diceNumber)
        {
            if (lastPosition + diceNumber > MaxPosition)
                Console.WriteLine($"{this.Name} était sur la case {lastPosition} et il veut avancer trop loin, il retourne à la case {this.Position}");
            else
                Console.WriteLine($"{this.Name} est sur la case {lastPosition} et avance vers la case {this.Position}");
                
            if (isMultipleOfTen())
                Console.WriteLine($"{this.Name} est sur un multiple de 10 ({this.Position}), il rejoue");
        }
        
        private bool isMultipleOfTen()
        {
            return Position % 10 == 0 && Position != MaxPosition;
        }
        
        private void ChangePosition(int number)
        {
            Position = (Position + number > MaxPosition) ? MaxPosition/2 : Position + number;
        }
    }
}