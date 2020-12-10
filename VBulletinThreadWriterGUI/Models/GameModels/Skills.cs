using System.Collections.Generic;
using System.ComponentModel;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public static class OSRSSkills
    {
        public enum OSRSSkillNames
        {
            [Description("Test")]
            TEST,
            [Description("Agility")]
            AGILITY,
            [Description("Melee")]
            MELEE,
            [Description("Construction")]
            CONSTRUCTION,
            [Description("Cooking")]
            COOKING,
            [Description("Crafting")]
            CRAFTING,
            [Description("Farming")]
            FARMING,
            [Description("Firemaking")]
            FIREMAKING,
            [Description("Fishing")]
            FISHING,
            [Description("Fletching")]
            FLETCHING,
            [Description("Herblore")]
            HERBLORE,
            [Description("Hunter")]
            HUNTER,
            [Description("Magic")]
            MAGIC,
            [Description("Mining")]
            MINING,
            [Description("Prayer")]
            PRAYER,
            [Description("Ranged")]
            RANGED,
            [Description("Runecrafting")]
            RUNECRAFTING,
            [Description("Slayer")]
            SLAYER,
            [Description("Smithing")]
            SMITHING,
            [Description("Thieving")]
            THIEVING,
            [Description("Woodcutting")]
            WOODCUTTING
        }

        public static List<string> SkillList =
            new List<string>
            {
                OSRSSkillNames.TEST.ToDescription(),
                OSRSSkillNames.AGILITY.ToDescription(),
                OSRSSkillNames.MELEE.ToDescription(),
                OSRSSkillNames.CONSTRUCTION.ToDescription(),
                OSRSSkillNames.COOKING.ToDescription(),
                OSRSSkillNames.CRAFTING.ToDescription(),
                OSRSSkillNames.FARMING.ToDescription(),
                OSRSSkillNames.FIREMAKING.ToDescription(),
                OSRSSkillNames.FISHING.ToDescription(),
                OSRSSkillNames.FLETCHING.ToDescription(),
                OSRSSkillNames.HERBLORE.ToDescription(),
                OSRSSkillNames.HUNTER.ToDescription(),
                OSRSSkillNames.MAGIC.ToDescription(),
                OSRSSkillNames.MINING.ToDescription(),
                OSRSSkillNames.PRAYER.ToDescription(),
                OSRSSkillNames.RANGED.ToDescription(),
                OSRSSkillNames.RUNECRAFTING.ToDescription(),
                OSRSSkillNames.SLAYER.ToDescription(),
                OSRSSkillNames.SMITHING.ToDescription(),
                OSRSSkillNames.THIEVING.ToDescription(),
                OSRSSkillNames.WOODCUTTING.ToDescription()
            };

        public static OSRSSkillNames? GetSkillEnumFromString(string skillName)
        {
            for(int x = 0; x < SkillList.Count; x++)
            {
                var skillEnum = (OSRSSkillNames)x;
                if(skillEnum.ToDescription().Equals(skillName, System.StringComparison.OrdinalIgnoreCase))
                {
                    return skillEnum;
                }
            }

            return null;
        }
    }

    public static class RS3Skills
    {
        public enum RS3SkillNames
        {
            [Description("Agility")]
            AGILITY,
            [Description("Melee")]
            MELEE,
            [Description("Construction")]
            CONSTRUCTION,
            [Description("Cooking")]
            COOKING,
            [Description("Crafting")]
            CRAFTING,
            [Description("Divination")]
            DIVINATION,
            [Description("Dungeoneering")]
            DUNGEONEERING,
            [Description("Farming")]
            FARMING,
            [Description("Firemaking")]
            FIREMAKING,
            [Description("Fishing")]
            FISHING,
            [Description("Fletching")]
            FLETCHING,
            [Description("Herblore")]
            HERBLORE,
            [Description("Hunter")]
            HUNTER,
            [Description("Invention")]
            INVENTION,
            [Description("Magic")]
            MAGIC,
            [Description("Mining")]
            MINING,
            [Description("Prayer")]
            PRAYER,
            [Description("Ranged")]
            RANGED,
            [Description("Runecrafting")]
            RUNECRAFTING,
            [Description("Slayer")]
            SLAYER,
            [Description("Smithing")]
            SMITHING,
            [Description("Summoning")]
            SUMMONING,
            [Description("Thieving")]
            THIEVING,
            [Description("Woodcutting")]
            WOODCUTTING
        }
        
        public static List<string> SkillList = 
            new List<string>
            {
                RS3SkillNames.AGILITY.ToDescription(),
                RS3SkillNames.MELEE.ToDescription(),
                RS3SkillNames.CONSTRUCTION.ToDescription(),
                RS3SkillNames.COOKING.ToDescription(),
                RS3SkillNames.CRAFTING.ToDescription(),
                RS3SkillNames.DIVINATION.ToDescription(),
                RS3SkillNames.DUNGEONEERING.ToDescription(),
                RS3SkillNames.FARMING.ToDescription(),
                RS3SkillNames.FIREMAKING.ToDescription(),
                RS3SkillNames.FISHING.ToDescription(),
                RS3SkillNames.FLETCHING.ToDescription(),
                RS3SkillNames.HERBLORE.ToDescription(),
                RS3SkillNames.HUNTER.ToDescription(),
                RS3SkillNames.INVENTION.ToDescription(),
                RS3SkillNames.MAGIC.ToDescription(),
                RS3SkillNames.MINING.ToDescription(),
                RS3SkillNames.PRAYER.ToDescription(),
                RS3SkillNames.RANGED.ToDescription(),
                RS3SkillNames.RUNECRAFTING.ToDescription(),
                RS3SkillNames.SLAYER.ToDescription(),
                RS3SkillNames.SMITHING.ToDescription(),
                RS3SkillNames.SUMMONING.ToDescription(),
                RS3SkillNames.THIEVING.ToDescription(),
                RS3SkillNames.WOODCUTTING.ToDescription()
            };

        public static RS3SkillNames? GetSkillEnumFromString(string skillName)
        {
            for (int x = 0; x < SkillList.Count; x++)
            {
                var skillEnum = (RS3SkillNames)x;
                if (skillEnum.ToDescription().Equals(skillName, System.StringComparison.OrdinalIgnoreCase))
                {
                    return skillEnum;
                }
            }

            return null;
        }
    }
}
