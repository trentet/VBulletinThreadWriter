using System;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for InterfaceItemsField.xaml
    /// </summary>
    public partial class InterfaceItemField : UserControl
    {
        public InterfaceItemField()
        {
            InitializeComponent();
        }
    }

    public class InterfaceItemFieldVM
    {
        public InterfaceItem InterfaceItem { get; set; }
        public string Description
        {
            get => InterfaceItem.Description;
            set => InterfaceItem.Description = value;
        }

        public string Image
        {
            get => InterfaceItem.Image != null ? InterfaceItem.Image.LocalPath : "";
            set => InterfaceItem.Image = new Uri(value);
        }
    }
}