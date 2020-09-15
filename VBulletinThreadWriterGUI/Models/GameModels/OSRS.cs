using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Models;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public class OSRS : Game
    {
        public OSRS() : base("OSRS", new List<Skill>())
        {
            this.Skills = new List<Skill>()
            {
                Agility(),
                new Skills.Construction(),
                new Skills.Cooking(),
                new Skills.Crafting(),
                new Skills.Farming(),
                new Skills.Firemaking(),
                new Skills.Fishing(),
                new Skills.Fletching(),
                new Skills.Herblore(),
                new Skills.Hunter(),
                new Skills.Magic(),
                new Skills.Melee(),
                new Skills.Mining(),
                new Skills.Prayer(),
                new Skills.Ranged(),
                new Skills.Runecrafting(),
                new Skills.Slayer(),
                new Skills.Smithing(),
                new Skills.Thieving(),
                new Skills.Woodcutting()
            };
        }

        private Skill Agility()
        {
            Skill agility = new Skill()
            {
                Name = OSRSSkills.AGILITY,
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/OhEiD7d.png") },
                SupportType = SupportTypes.LIMITED_SUPPORT
            };

            agility.TrainingMethods.Add(
                "Gnome Stronghold Agility Course",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Draynor Village Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Al Kharid Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Werewolf Skullball",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Varrock Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Canifis Rooftop Course",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Ape Atoll Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Falador Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Wilderness Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Werewolf Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Seers' Village Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Pollnivneach Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Prifddinas Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Relleka Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Brimhaven Agility Arena",
                SupportTypes.UNSUPPORTED,
                new ScriptExample()
            );

            agility.TrainingMethods.Add(
                "Ardougne Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            return agility;
        }

        private Skill Construction()
        {
            Skill construction = new Skill()
            {
                Name = OSRSSkills.CONSTRUCTION,
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/1tISxly.png") },
                SupportType = SupportTypes.LIMITED_SUPPORT
            };

            construction.TrainingMethods.Add(
                "Oak Larders",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Mahogany Tables",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Gnome benches",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Mounted Mythical Capes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Teak Garden Benches",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Carved Teak Magic Wardrobes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            construction.TrainingMethods.Add(
                "Oak Dungeon Doors",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            return construction;
        }

        private Skill Cooking()
        {
            Skill cooking = new Skill()
            {
                Name = OSRSSkills.COOKING,
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/4I46Lf9.png") },
                SupportType = SupportTypes.SUPPORTED
            };

            cooking.TrainingMethods.Add(
                "Jugs of Wine",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Myths' Guild",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Rogues' Den",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Cook's Guild",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Hosidius Clay Oven",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Wintertodt Bonfire",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Catherby",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            cooking.TrainingMethods.Add(
                "Lumbridge Castle",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            return cooking;
        }

        private Skill Crafting()
        {
            Skill crafting = new Skill()
            {
                Name = OSRSSkills.CRAFTING,
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/FZYrvzH.png") },
                SupportType = SupportTypes.SUPPORTED
            };

            crafting.TrainingMethods.Add(
                "Cutting Gems",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "Battlestaves",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "D'hide Bodies",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "Gold Bracelets",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "Glassblowing Molten Glass",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "Casting Superglass Make",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            crafting.TrainingMethods.Add(
                "Cutting Amethyst",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExample()
            );

            return crafting;
        }

        //private Skill Farming()
        //{
        //    //Skill farming = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return farming;
        //}

        //private Skill Firemaking()
        //{
        //    //Skill firemaking = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return firemaking;
        //}

        //private Skill Fishing()
        //{
        //    //Skill fishing = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return fishing;
        //}

        //private Skill Fletching()
        //{
        //    //Skill fletching = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return fletching;
        //}

        //private Skill Herblore()
        //{
        //    //Skill herblore = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return herblore;
        //}

        //private Skill Hunter()
        //{
        //    //Skill hunter = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return hunter;
        //}

        //private Skill Magic()
        //{
        //    //Skill magic = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return magic;
        //}

        //private Skill Melee()
        //{
        //    //Skill melee = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return melee;
        //}

        //private Skill Mining()
        //{
        //    //Skill mining = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return mining;
        //}

        //private Skill Prayer()
        //{
        //    //Skill prayer = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return prayer;
        //}

        //private Skill Ranged()
        //{
        //    //Skill ranged = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return ranged;
        //}

        //private Skill Runecrafting()
        //{
        //    //Skill runecrafting = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return runecrafting;
        //}

        //private Skill Slayer()
        //{
        //    //Skill slayer = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return slayer;
        //}

        //private Skill Smithing()
        //{
        //    //Skill smithing = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return smithing;
        //}

        //private Skill Thieving()
        //{
        //    //Skill thieving = new Skill()
        //    //{
        //    //    Name = OSRSSkills.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return thieving;
        //}

        //private Skill Woodcutting()
        //{
        //    //Skill woodcutting = new Skill()
        //    //{
        //    //    Name = OSRSSkills.WOODCUTTING,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return woodcutting;
        //}
    }
}
