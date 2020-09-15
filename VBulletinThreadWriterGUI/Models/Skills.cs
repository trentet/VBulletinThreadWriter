using System.Collections.Generic;

namespace VBulletinThreadWriterGUI
{
    //public static class Skills
    //{
    public static class OSRSSkills
        {
            public const string AGILITY = "Agility";
            public const string MELEE = "Melee";
            public const string CONSTRUCTION = "Construction";
            public const string COOKING = "Cooking";
            public const string CRAFTING = "Crafting";
            public const string FARMING = "Farming";
            public const string FIREMAKING = "Firemaking";
            public const string FISHING = "Fishing";
            public const string FLETCHING = "Fletching";
            public const string HERBLORE = "Herblore";
            public const string HUNTER = "Hunter";
            public const string MAGIC = "Magic";
            public const string MINING = "Mining";
            public const string PRAYER = "Prayer";
            public const string RANGED = "Ranged";
            public const string RUNECRAFTING = "Runecrafting";
            public const string SLAYER = "Slayer";
            public const string SMITHING = "Smithing";
            public const string THIEVING = "Thieving";
            public const string WOODCUTTING = "Woodcutting";

            public static List<string> ToList()
            {
                return 
                    new List<string> 
                    {
                        AGILITY,
                        MELEE,
                        CONSTRUCTION,
                        COOKING,
                        CRAFTING,
                        FARMING,
                        FIREMAKING,
                        FISHING,
                        FLETCHING,
                        HERBLORE,
                        HUNTER,
                        MAGIC,
                        MINING,
                        PRAYER,
                        RANGED,
                        RUNECRAFTING,
                        SLAYER,
                        SMITHING,
                        THIEVING,
                        WOODCUTTING
                    };
            }
        }

        public static class RS3Skills
        {

        }
    //}
}
