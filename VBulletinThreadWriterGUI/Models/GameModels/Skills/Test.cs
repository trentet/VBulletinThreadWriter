using System;
using System.Collections.Generic;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;

namespace VBulletinThreadWriterGUI.Models.GameModels.Skills
{
    public class Test : Skill
    {
        public Test() :
            base(
                Games.OSRS,
                OSRSSkills.OSRSSkillNames.TEST.ToDescription(),
                new Uri("https://i.imgur.com/hKurFob.png"),
                SupportTypes.SUPPORTED
            )
        {
            TrainingMethodModel testTrainingMethod = new TrainingMethodModel()
            {
                Name = "Test Training Method",
                SupportType = SupportTypes.SUPPORTED,
            };

            testTrainingMethod.ScriptExample = new ScriptExampleModel()
            {
                VisionSystem = VisionSystems.SHAPE,
                CaveatsAndLimitations = "Example of caveats and limitations. ",
                Description = "Example of description. ",
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
                        "Example of Map description. "
                    ),
                WorldItemsSection =
                    new WorldItemsSection(
                        new WorldItem(
                            new Uri("https://i.imgur.com/BnOpXpv.png"),
                            "Example of World Item description. "
                        )
                    ),
                InterfaceItemsSection =
                    new InterfaceItemsSection(
                        new List<InterfaceItem>
                        {
                            new InterfaceItem(
                                new Uri("https://i.imgur.com/R0xt50s.png"),
                                "Example Interface Item 1. "
                            ),
                            new InterfaceItem(
                                new Uri("https://i.imgur.com/wxvm1F8.png"),
                                "Example Interface Item 2. "
                            )
                        }
                    ),
                MachineDataSection =
                    new MachineDataSection(
                        new Uri("https://i.imgur.com/PpmvGXL.png"),
                        "Example Machine Data Description. "
                    )
            };

            this.TrainingMethods.Add(testTrainingMethod);
        }
    }
}
