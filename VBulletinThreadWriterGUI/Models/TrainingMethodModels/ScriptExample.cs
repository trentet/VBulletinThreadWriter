using System.ComponentModel;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels
{
    public enum VisionSystems
    {
        [Description("Color (Manual)")]
        COLOR,
        [Description("Shape (Automatic)")]
        SHAPE
    }

    public class ScriptExampleModel
    {
        public VisionSystems? VisionSystem { get; set; }
        public string CaveatsAndLimitations { get; set; }
        public string Description { get; set; }
        public AdditionalSettingsSection AdditionalSettingsSection { get; set; }
        public WorldGridSection WorldGridSection { get; set; }
        public MapSection MapSection { get; set; }
        public WorldItemsSection WorldItemsSection { get; set; }
        public InterfaceItemsSection InterfaceItemsSection { get; set; }
        public MachineDataSection MachineDataSection { get; set; }

        public ScriptExampleModel()
        {

        }

        public ScriptExampleModel(
            VisionSystems visionSystem,
            string caveatsAndLimitations,
            string description,
            AdditionalSettingsSection additionalSettings,
            WorldGridSection worldGrid,
            MapSection map,
            WorldItemsSection worldItems,
            InterfaceItemsSection interfaceItems,
            MachineDataSection machineData
        )
        {
            this.VisionSystem = visionSystem;
            this.CaveatsAndLimitations = caveatsAndLimitations;
            this.Description = description;
            this.AdditionalSettingsSection = additionalSettings;
            this.WorldGridSection = worldGrid;
            this.MapSection = map;
            this.WorldItemsSection = worldItems;
            this.InterfaceItemsSection = interfaceItems;
            this.MachineDataSection = machineData;
        }
    }
}
