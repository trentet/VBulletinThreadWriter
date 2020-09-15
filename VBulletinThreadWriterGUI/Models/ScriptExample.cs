using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI
{
    public class ScriptExample
    {
        public string VisionSystem { get; set; }
        public string CaveatsAndLimitations { get; set; }
        public string Description { get; set; }
        public AdditionalSettingsSection AdditionalSettingsSection { get; set; }
        public WorldGridSection WorldGridSection { get; set; }
        public MapSection MapSection { get; set; }
        public WorldItemsSection WorldItemsSection { get; set; }
        public InterfaceItemsSection InterfaceItemsSection { get; set; }
        public MachineDataSection MachineDataSection { get; set; }

        public ScriptExample()
        {

        }

        public ScriptExample(
            string visionSystem,
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
