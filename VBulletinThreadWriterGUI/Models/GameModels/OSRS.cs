using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;
using VBulletinThreadWriterGUI.Models.GameModels.Skills;

namespace VBulletinThreadWriterGUI.Models.GameModels
{
    public class OSRS : Game
    {
        public OSRS() : base(Games.OSRS, new List<Skill>())
        {
            this.Skills = new List<Skill>()
            {
                new Test(),
                Agility(),
                Construction(),
                Cooking(),
                Crafting(),
                //Farming(),
                //Firemaking(),
                //Fishing(),
                Fletching(),
                //Herblore(),
                //Hunter(),
                //Magic(),
                //Melee(),
                //Mining(),
                //Prayer(),
                //Ranged(),
                //Runecrafting(),
                //Slayer(),
                //Smithing(),
                //Thieving(),
                //Woodcutting()
            };
        }

        private Skill Agility()
        {
            Skill agility = new Skill(EnumValue)
            {
                Name = OSRSSkills.OSRSSkillNames.AGILITY.ToDescription(),
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/OhEiD7d.png") },
                SupportType = SupportTypes.LIMITED_SUPPORT
            };

            agility.TrainingMethods.Add(
                "Gnome Stronghold Agility Course",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Draynor Village Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Al Kharid Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Werewolf Skullball",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Varrock Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Canifis Rooftop Course",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Ape Atoll Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Falador Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Wilderness Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Werewolf Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Seers' Village Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Pollnivneach Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Prifddinas Agility Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Relleka Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Brimhaven Agility Arena",
                SupportTypes.UNSUPPORTED,
                new ScriptExampleModel()
            );

            agility.TrainingMethods.Add(
                "Ardougne Rooftop Course",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            return agility;
        }

        private Skill Construction()
        {
            Skill construction = new Skill(EnumValue)
            {
                Name = OSRSSkills.OSRSSkillNames.CONSTRUCTION.ToDescription(),
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/1tISxly.png") },
                SupportType = SupportTypes.LIMITED_SUPPORT
            };

            construction.TrainingMethods.Add(
                "Oak Larders",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Mahogany Tables",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Gnome benches",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Mounted Mythical Capes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Teak Garden Benches",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Carved Teak Magic Wardrobes",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            construction.TrainingMethods.Add(
                "Oak Dungeon Doors",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            return construction;
        }

        private Skill Cooking()
        {
            Skill cooking = new Skill(EnumValue)
            {
                Name = OSRSSkills.OSRSSkillNames.COOKING.ToDescription(),
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/4I46Lf9.png") },
                SupportType = SupportTypes.SUPPORTED
            };

            cooking.TrainingMethods.Add(
                "Jugs of Wine",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Myths' Guild",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Rogues' Den",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Cook's Guild",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Hosidius Clay Oven",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Wintertodt Bonfire",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Catherby",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            cooking.TrainingMethods.Add(
                "Lumbridge Castle",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            return cooking;
        }

        private Skill Crafting()
        {
            Skill crafting = new Skill(EnumValue)
            {
                Name = OSRSSkills.OSRSSkillNames.CRAFTING.ToDescription(),
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/FZYrvzH.png") },
                SupportType = SupportTypes.SUPPORTED
            };

            crafting.TrainingMethods.Add(
                "Cutting Gems",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "Battlestaves",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "D'hide Bodies",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "Gold Bracelets",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "Glassblowing Molten Glass",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "Casting Superglass Make",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            crafting.TrainingMethods.Add(
                "Cutting Amethyst",
                SupportTypes.UNKNOWN_SUPPORT,
                new ScriptExampleModel()
            );

            return crafting;
        }

        //private Skill Farming()
        //{
        //    //Skill farming = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};

        //    //return farming;
        //}

        //private Skill Firemaking()
        //{
        //    //Skill firemaking = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return firemaking;
        //}

        //private Skill Fishing()
        //{
        //    //Skill fishing = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return fishing;
        //}

        private Skill Fletching()
        {
            Skill fletching = new Skill(EnumValue)
            {
                Name = OSRSSkills.OSRSSkillNames.FLETCHING.ToDescription(),
                SkillCapes = new List<Uri> { new Uri("https://i.imgur.com/hKurFob.png") },
                SupportType = SupportTypes.SUPPORTED
            };

            fletching.TrainingMethods.Add(
                "Darts",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Bolts",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Tipping Bolts",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Arrows",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Javelins",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Arrow Shafts",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Unstrung Bows",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            TrainingMethodModel stringingBows = new TrainingMethodModel()
            {
                Name = "Stringing Bows",
                SupportType = SupportTypes.SUPPORTED,
            };

            stringingBows.ScriptExample = new ScriptExampleModel()
            {
                VisionSystem = VisionSystems.SHAPE,
                CaveatsAndLimitations = "Solid world item highlighting with RuneLitePlus recommended.",
                Description = "Stringing Yew Longbows at Varrock West bank using '1' key for the Make X menu selection and bank left-click withdraw X set to 14.",
                AdditionalSettingsSection =
                    new AdditionalSettingsSection(
                        new Uri("https://i.imgur.com/IzThAK9.png")
                    ),
                WorldGridSection =
                    new WorldGridSection(
                        new Uri("https://i.imgur.com/BnOpXpv.png")
                    ),
                MapSection =
                    new MapSection(
                        new Uri("https://i.imgur.com/uNIG87c.png"),
                        "No navigation necessary. Standing one tile west of the south-most bank booth in Varrock West Bank."
                    ),
                WorldItemsSection =
                    new WorldItemsSection(
                        new WorldItem(
                            new Uri("https://i.imgur.com/BnOpXpv.png"),
                            "South-most bank booth in Varrock West Bank, solid cyan overlay using RuneLitePlus."
                        )
                    ),
                InterfaceItemsSection =
                    new InterfaceItemsSection(
                        new List<InterfaceItem>
                        {
                            new InterfaceItem(
                                new Uri("https://i.imgur.com/R0xt50s.png"),
                                "Yew Longbow"
                            ),
                            new InterfaceItem(
                                new Uri("https://i.imgur.com/wxvm1F8.png"),
                                "Bow string"
                            ),
                            new InterfaceItem(
                                new Uri("https://i.imgur.com/G0Ze7Pj.png"),
                                "Yew Longbow (u)"
                            ),
                        }
                    ),
                MachineDataSection =
                    new MachineDataSection(
                        new Uri("https://i.imgur.com/PpmvGXL.png")
                    )
            };

            fletching.TrainingMethods.Add(stringingBows);

            fletching.TrainingMethods.Add(
                "Battlestaves",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            fletching.TrainingMethods.Add(
                "Redwood Shields",
                SupportTypes.SUPPORTED,
                new ScriptExampleModel()
            );

            return fletching;
        }

        //private Skill Herblore()
        //{
        //    //Skill herblore = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return herblore;
        //}

        //private Skill Hunter()
        //{
        //    //Skill hunter = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return hunter;
        //}

        //private Skill Magic()
        //{
        //    //Skill magic = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return magic;
        //}

        //private Skill Melee()
        //{
        //    //Skill melee = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return melee;
        //}

        //private Skill Mining()
        //{
        //    //Skill mining = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return mining;
        //}

        //private Skill Prayer()
        //{
        //    //Skill prayer = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return prayer;
        //}

        //private Skill Ranged()
        //{
        //    //Skill ranged = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return ranged;
        //}

        //private Skill Runecrafting()
        //{
        //    //Skill runecrafting = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return runecrafting;
        //}

        //private Skill Slayer()
        //{
        //    //Skill slayer = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return slayer;
        //}

        //private Skill Smithing()
        //{
        //    //Skill smithing = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return smithing;
        //}

        //private Skill Thieving()
        //{
        //    //Skill thieving = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return thieving;
        //}

        //private Skill Woodcutting()
        //{
        //    //Skill woodcutting = new Skill()
        //    //{
        //    //    Name = OSRSSkills.OSRSSkillNames.WOODCUTTING,
        //    //    SkillCapes = new List<Uri> { new Uri("") },
        //    //    SupportType = SupportTypes.
        //    //};



        //    //return woodcutting;
        //}
    }
}
