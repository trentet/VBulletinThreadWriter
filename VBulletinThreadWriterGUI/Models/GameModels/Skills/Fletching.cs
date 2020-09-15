using System;
using System.Collections.Generic;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Fletching : Skill
    {
        public Fletching() :
            base(
                OSRSSkills.FLETCHING,
                new Uri("https://i.imgur.com/hKurFob.png"),
                SupportTypes.SUPPORTED
            )
        {
            this.TrainingMethods.Add(
                "Darts",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Bolts",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Tipping Bolts",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Arrows",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Javelins",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Arrow Shafts",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Unstrung Bows",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            TrainingMethod stringingBows = new TrainingMethod()
            {
                Name = "Stringing Bows",
                SupportType = SupportTypes.SUPPORTED,
            };

            stringingBows.ScriptExample = new ScriptExample()
            {
                VisionSystem = "Automatic, Shape-based recommended",
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

            this.TrainingMethods.Add(stringingBows);

            this.TrainingMethods.Add(
                "Battlestaves",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );

            this.TrainingMethods.Add(
                "Redwood Shields",
                SupportTypes.SUPPORTED,
                new ScriptExample()
            );
        }
    }
}
