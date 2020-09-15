#nullable enable
using System;
using System.Collections.Generic;

namespace VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields
{
    public class InterfaceItemsSection
    {
        public List<InterfaceItem> InterfaceItems { get; set; }
        public string Description { get; set; }

        public InterfaceItemsSection()
        {
            this.InterfaceItems = new List<InterfaceItem>();
            this.Description = "";
        }

        public InterfaceItemsSection(InterfaceItem interfaceItem)
        {
            this.InterfaceItems = new List<InterfaceItem> { interfaceItem };
            this.Description = "";
        }

        public InterfaceItemsSection(List<InterfaceItem> interfaceItems)
        {
            this.InterfaceItems = interfaceItems;
            this.Description = "";
        }

        public InterfaceItemsSection(string description)
        {
            this.InterfaceItems = new List<InterfaceItem>();
            this.Description = description;
        }

        public InterfaceItemsSection(InterfaceItem interfaceItem, string description)
        {
            this.InterfaceItems = new List<InterfaceItem> { interfaceItem };
            this.Description = description;
        }

        public InterfaceItemsSection(List<InterfaceItem> interfaceItems, string description)
        {
            this.InterfaceItems = interfaceItems;
            this.Description = description;
        }
    }
}
