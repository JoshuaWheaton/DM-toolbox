using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupProject
{
    //class for non-player entities
    class Creature
    {
        //Variable declaration for hitpoints, max hitpooints, and true max hitpoints
        private int CurrentHP; // current hitpoints
        private int TempHP;   // temporary hitpoints
        private int MaxHP;     // current maximum hitpoints, used for effects that reduce Max HP

        //Property declaration for ability scores: Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma
        private byte Str; // Strength Score, value from 1-30
        private byte Dex; // Dexterity Score, value from 1-30
        private byte Con; // Constitution Score, value from 1-30
        private byte Int; // Intelligence Score, value from 1-30
        private byte Wis; // Wisdom Score, value from 1-30
        private byte Cha; // Charisma Score, value from 1-30

        //Miscellaneous combat attributes: Movement Speed, Armor Class, Size, Description, Name, Initiative
        private int Move;   // Movement Speed
        private byte AC;    // Armor Class
        private byte Size;  // Creature Size. 1 = Tiny, 2 = Small, 3 = Medium, 4 = Large, 5 = Huge, 6 = Gargantuan
                            // Used for a switch case to determine hitpoints during creature creation
        private string? Description; // Misc descriptions
        private string? Name;        // Creature name
        private byte Initiative;     // Place in initiative

        //Set and get for strength score
        public void SetStr(byte strVal)
        { Str = strVal; }
        public int GetStr()
        { return Str; }

        //Set and get for dexterity score
        public void SetDex(byte dexVal)
        { Dex = dexVal; }
        public int GetDex()
        { return Dex; }

        //Set and get for constitution score
        public void SetCon(byte conVal)
        { Con = conVal; }
        public int GetCon()
        { return Con; }

        //Set and get for intelligence score
        public void SetInt(byte intVal)
        { Int = intVal; }
        public int GetInt()
        { return Int; }

        //Set and get for wisdom score
        public void SetWis(byte wisVal)
        { Wis = wisVal; }
        public int GetWis()
        { return Wis; }

        //Set and get for charisma score
        public void SetCha(byte chaVal)
        { Cha = chaVal; }
        public int GetCha()
        { return Cha; }

        //Set and get for name
        public void SetName(string nameVal)
        { Name = nameVal; }
        public string? GetName()
        { return Name; }

        //Set and get for description
        public void SetDescription(string descVal)
        { Description = descVal; }
        public string? GetDescription()
        { return Description; }

        //Set and get for Initiative
        public void SetInitiative(byte initVal)
        { Initiative = initVal; }
        public byte GetInitiative()
        { return Initiative; }

        //Set and get for Armor Class
        public void SetAC(byte acVal)
        { AC = acVal; }
        public byte GetAC()
        { return AC; }

        //Set and get for Temp HP
        public void SetTempHP(int tempHPVal)
        { TempHP = tempHPVal; }
        public int GetTempHP()
        { return TempHP; }

        //Set and get for Max HP
        public void SetMaxHP(int maxHPVal)
        { MaxHP = maxHPVal; }
        public int GetMaxHP()
        { return MaxHP; }

        //Set and get for HP
        public void SetHP(int currentHPVal)
        { CurrentHP = currentHPVal; }
        public int GetCurrentHP()
        { return CurrentHP; }

        //Writing a creature to a file
        public string Serialize()
        {
            return $"{Name}|{Description}|{Str}|{Dex}|{Con}|{Int}|{Wis}|{Cha}";
        }

        //Reading a creature from a file
        public static Creature Deserialize(string serializedString)
        {
            string[] parts = serializedString.Split('|');
            if (parts.Length == 8)
            {
                string name = parts[0];
                string description = parts[1];
                byte strength = 10;
                byte dexterity = 10;
                byte constitution = 10;
                byte intelligence = 10;
                byte wisdom = 10;
                byte charisma = 10;
                byte.TryParse(parts[2], out strength);
                byte.TryParse(parts[3], out dexterity);
                byte.TryParse(parts[4], out constitution);
                byte.TryParse(parts[5], out intelligence);
                byte.TryParse(parts[6], out wisdom);
                byte.TryParse(parts[7], out charisma);
                return new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma);
            }
            else
            {
                return null;
            }
        }

        // Constructor
        public Creature(string name, string description, byte strength, byte dexterity, byte constitution, byte intelligence, byte wisdom, byte charisma)
        {
            Name = name;
            Description = description;
            Str = strength;
            Dex = dexterity;
            Con = constitution;
            Int = intelligence;
            Wis = wisdom;
            Cha = charisma;

            int tempDex = Dex;
            int tempCon = Con;
            AC = (byte)(10 + ((tempDex - 10) / 2));
            MaxHP = (tempCon - 10) / 2;
            CurrentHP = MaxHP;
            TempHP = 0;

        }

        public void updateVals()
        {
            int tempDex = Dex;
            int tempCon = Con;
            AC = (byte)(10 + ((tempDex - 10) / 2));
            MaxHP = (tempCon - 10) / 2;
            CurrentHP = MaxHP;
        }

        public override string? ToString()
        {
            return Name;
        }

        //Copy creature
        public Creature make_copy()
        {
            return new Creature(this.Name, this.Description, this.Str, this.Dex, this.Con, this.Int, this.Wis, this.Cha);
        }
    }

}