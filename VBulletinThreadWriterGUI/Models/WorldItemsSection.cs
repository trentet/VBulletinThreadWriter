#nullable enable
using System;
using System.Collections.Generic;

namespace VBulletinThreadWriterGUI
{
    public class WorldItemsSection
    {
        public List<WorldItem> WorldItems { get; set; }
        public string Description { get; set; }

        public WorldItemsSection()
        {
            this.WorldItems = new List<WorldItem>();
            this.Description = "";
        }

        public WorldItemsSection(WorldItem worldItem)
        {
            this.WorldItems = new List<WorldItem> { worldItem };
            this.Description = "";
        }

        public WorldItemsSection(List<WorldItem> worldItems)
        {
            this.WorldItems = worldItems;
            this.Description = "";
        }

        public WorldItemsSection(string description)
        {
            this.WorldItems = new List<WorldItem>();
            this.Description = description;
        }

        public WorldItemsSection(WorldItem worldItem, string description)
        {
            this.WorldItems = new List<WorldItem> { worldItem };
            this.Description = description;
        }

        public WorldItemsSection(List<WorldItem> worldItems, string description)
        {
            this.WorldItems = worldItems;
            this.Description = description;
        }
    }
}
