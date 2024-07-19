namespace character
{
    class Personagem
    {
        private string name;
        private int hp;
        private int mana;
        private int strength;
        private int agility;
        private int vitality;
        private int dexterity;
        private int wisdom;

        public Personagem(string name)
        {
            this.name = name;
        }



        /*Getters and setters*/
        public string Name { get => name; set => name = value; }
        public int Hp { get => hp; set => hp = value; }
        public int Mana { get => mana; set => mana = value; }
        public int Strength { get => strength; set => strength = value; }
        public int Agility { get => agility; set => agility = value; }
        public int Vitality { get => vitality; set => vitality = value; }
        public int Dexterity { get => dexterity; set => dexterity = value; }
        public int Wisdom { get => wisdom; set => wisdom = value; }
    }
}