namespace DM_Toolkit
{
    //class for non-player entities
    class Creature
    {
        //Variable declaration for hitpoints, max hitpooints, and true max hitpoints
        private int CurrentHP { get; set; } // current hitpoints
        private byte tempHP { get; set; }   // temporary hitpoints
        private int MaxHP { get; set; }     // current maximum hitpoints, used for effects that reduce Max HP

        //Property declaration for ability scores: Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma
        private byte Str { get; set; } // Strength Score, value from 1-30
        private byte Dex { get; set; } // Dexterity Score, value from 1-30
        private byte Con { get; set; } // Constitution Score, value from 1-30
        private byte Int { get; set; } // Intelligence Score, value from 1-30
        private byte Wis { get; set; } // Wisdom Score, value from 1-30
        private byte Cha { get; set; } // Charisma Score, value from 1-30

        //Miscellaneous combat attributes: Movement Speed, Armor Class, Size
        private int Move { get; set; }   // Movement Speed
        private byte AC { get; set; }    // Armor Class
        private byte Size { get; set; }  // Creature Size. 1 = Tiny, 2 = Small, 3 = Medium, 4 = Large, 5 = Huge, 6 = Gargantuan
                                         // Used for a switch case to determine hitpoints during creature creation

    }

    class Player
    {
        //Variable declaration player hitpoints, max hitpooints, and true max hitpoints
        private int CurrentHP { get; set; } // current hitpoints
        private byte tempHP { get; set; }   // temporary hitpoints
        private int MaxHP { get; set; }     // current maximum hitpoints, used for effects that reduce Max HP
        private int TrueMaxHP { get; set; } // true maximum hitpoints, used for storing the value to return to after reduction

        //Property declaration for ability scores: Strength, Dexterity, Constitution, Intelligence, Wisdom, Charisma
        private byte Str { get; set; } // Strength Score, value from 1-30
        private byte Dex { get; set; } // Dexterity Score, value from 1-30
        private byte Con { get; set; } // Constitution Score, value from 1-30
        private byte Int { get; set; } // Intelligence Score, value from 1-30
        private byte Wis { get; set; } // Wisdom Score, value from 1-30
        private byte Cha { get; set; } // Charisma Score, value from 1-30

        //Miscellaneous combat attributes: Movement Speed, Armor Class, Size
        private int Move { get; set; }   // Movement Speed
        private byte AC { get; set; }    // Armor Class
        private byte Size { get; set; }  // Player Size. 1 = Tiny, 2 = Small, 3 = Medium, 4 = Large, 5 = Huge, 6 = Gargantuan
        private byte Class { get; set; } // Player class. Variable for a switch case to determine HP during Character Creation

    }
}