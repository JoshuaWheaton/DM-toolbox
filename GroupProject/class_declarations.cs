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
        private byte AC;    // Armor Class
                            // Used for a switch case to determine hitpoints during creature creation
        private string? Description; // Misc descriptions
        private string? Name;        // Creature name
        private byte Initiative;     // Place in initiative

        //Set up list of status effect objects so that status effects can be added
        public List<StatusEffect> StatusEffects = new List<StatusEffect>();

        public int abilityScoreModifier(byte statScore)
        {
            int statInt = (int)statScore;
            int modifier = 0;
            if (statInt < 10)
            {
                modifier = (statInt - 11) / 2;
            }
            else if (statInt > 11)
            {
                modifier = (statInt - 10) / 2;
            }
            else
            {
                modifier = 0;
            }
            return modifier;
        }

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
            return $"{Name}|{Description}|{Str}|{Dex}|{Con}|{Int}|{Wis}|{Cha}|{MaxHP}|{AC}|{Initiative}";
        }

        //Reading a creature from a file
        public static Creature Deserialize(string serializedString)
        {
            string[] parts = serializedString.Split('|');
            if (parts.Length == 11)
            {
                string name = parts[0];
                string description = parts[1];
                byte strength = 10;
                byte dexterity = 10;
                byte constitution = 10;
                byte intelligence = 10;
                byte wisdom = 10;
                byte charisma = 10;
                int maximumHP = 0;
                byte armorClass = 0;
                byte init = 0;
                byte.TryParse(parts[2], out strength);
                byte.TryParse(parts[3], out dexterity);
                byte.TryParse(parts[4], out constitution);
                byte.TryParse(parts[5], out intelligence);
                byte.TryParse(parts[6], out wisdom);
                byte.TryParse(parts[7], out charisma);
                int.TryParse(parts[8], out maximumHP);
                byte.TryParse(parts[9], out armorClass);
                byte.TryParse(parts[10], out init);
                return new Creature(name, description, strength, dexterity, constitution, intelligence, wisdom, charisma, maximumHP, armorClass, init);
            }
            else
            {
                return null;
            }
        }

        // Constructor
        public Creature(string name, string description, byte strength, byte dexterity, byte constitution, byte intelligence, byte wisdom, byte charisma, int maximumHP, byte armorClass, byte initative)
        {
            Name = name;
            Description = description;
            Str = strength;
            Dex = dexterity;
            Con = constitution;
            Int = intelligence;
            Wis = wisdom;
            Cha = charisma;
            MaxHP = maximumHP;
            CurrentHP = maximumHP;
            AC = armorClass;
            Initiative = initative;

            TempHP = 0;

        }

        public void updateVals()
        {
            //Removed because the add creature box now has section for HP and AC
            int tempDex = Dex;
            int tempCon = Con;
            //AC = (byte)(10 + ((tempDex - 10) / 2));
            //MaxHP = (tempCon - 10) / 2;
            //CurrentHP = MaxHP;
        }

        public override string? ToString()
        {
            return Name;
        }

        //Copy creature
        public Creature make_copy()
        {
            return new Creature(this.Name, this.Description, this.Str, this.Dex, this.Con, this.Int, this.Wis, this.Cha, this.CurrentHP, this.AC, this.Initiative);
        }
    }

    //Status Effect class declaration
    public class StatusEffect
    {
        //Name of the status effect
        public string Name = "";

        //Additional details about what the status effect does
        private string OtherEffects = "";

        //Duration in rounds
        private byte Duration = 0;

        //Type of Saving throw
        public string saveType = "";

        //Saving Throw DC
        public byte saveDC = 0;

        //Checkboxes for when the afflicted creaature gets a saving throw to end the effect
        //Made public to implement search functions
        public bool StartOfTurn
        { get; set; }
        public bool EndOfTurn
        { get; set; }
        public bool WhenDamaged
        { get; set; }

        //Status Conditions
        private bool Blinded
        { get; set; }
        private bool Charmed
        { get; set; }
        private bool Deafened
        { get; set; }
        private bool Frightened
        { get; set; }
        private bool Grappled
        { get; set; }
        private bool Incapacitated
        { get; set; }
        private bool Invisible
        { get; set; }
        private bool Paralyzed
        { get; set; }
        private bool Petrified
        { get; set; }
        private bool Poisoned
        { get; set; }
        private bool Prone
        { get; set; }
        private bool Restrained
        { get; set; }
        private bool Stunned
        { get; set; }
        private bool Unconscious
        { get; set; }

        public StatusEffect(string name, byte duration, bool SoT, bool EoT, bool onDmg, string svType, byte svDC, string otherFx,
                            bool blinded, bool charmed, bool deafened, bool frightened, bool grappled,
                            bool incapacitated, bool invisible, bool paralyzed, bool petrified, bool poisoned,
                            bool prone, bool restrained, bool stunned, bool unconscious)
        {
            Name = name;
            Duration = duration;
            StartOfTurn = SoT;
            EndOfTurn = EoT;
            WhenDamaged = onDmg;
            saveType = svType;
            saveDC = svDC;
            OtherEffects = otherFx;
            Blinded = blinded;
            Charmed = charmed;
            Deafened = deafened;
            Frightened = frightened;
            Grappled = grappled;
            Incapacitated = incapacitated;
            Invisible = invisible;
            Paralyzed = paralyzed;
            Petrified = petrified;
            Poisoned = poisoned;
            Prone = prone;
            Restrained = restrained;
            Stunned = stunned;
            Unconscious = unconscious;
        }

        public void DisplayStatusInfo()
        {
            //Test Name Box
            string displayStrn = Name + '\n';

            //Test Duration
            displayStrn += $"\nDuration: {Duration} rounds\n";

            //Test Saving Throw DC
            displayStrn += $"\nDC {saveDC} {saveType} Save";

            //Test Saving Throw Checkboxes
            displayStrn += "\nSaving Throw Conditions:\n";
            if (StartOfTurn)
            { displayStrn += "Save at start of turn\n"; }
            if (EndOfTurn)
            { displayStrn += "Save at end of turn\n"; }
            if (WhenDamaged)
            { displayStrn += "Save on damage\n"; }

            //Test OtherEffects Box
            displayStrn += $"\nOther Effects:\n{OtherEffects}\n";

            //Test Condition Checkboxes
            displayStrn += "\nStatus Conditions:\n";
            if (Blinded)
            { displayStrn += "Blinded\n"; }
            if (Charmed)
            { displayStrn += "Charmed\n"; }
            if (Deafened)
            { displayStrn += "Deafened\n"; }
            if (Frightened)
            { displayStrn += "Frightened\n"; }
            if (Grappled)
            { displayStrn += "Grappled\n"; }
            if (Incapacitated)
            { displayStrn += "Incapacitated\n"; }
            if (Invisible)
            { displayStrn += "Invisible\n"; }
            if (Paralyzed)
            { displayStrn += "Paralyzed\n"; }
            if (Petrified)
            { displayStrn += "Petrified\n"; }
            if (Poisoned)
            { displayStrn += "Poisoned\n"; }
            if (Prone)
            { displayStrn += "Prone\n"; }
            if (Restrained)
            { displayStrn += "Restrained\n"; }
            if (Stunned)
            { displayStrn += "Stunned\n"; }
            if (Unconscious)
            { displayStrn += "Unconscious\n"; }

            MessageBox.Show($"{displayStrn}");
        }

        public override string ToString()
        {
            return Name;
        }
    }

}