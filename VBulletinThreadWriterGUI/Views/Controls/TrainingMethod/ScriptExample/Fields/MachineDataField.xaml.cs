using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields{
    /// <summary>
    /// Interaction logic for MachineDataField.xaml
    /// </summary>
    public partial class MachineDataField : UserControl
    {
        /* Start of DescriptionTextBoxField */
        public static readonly DependencyProperty DescriptionTextBoxFieldNameProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldName",
                  typeof(string),
                  typeof(MachineDataField),
                  new PropertyMetadata("")
              );

        public string DescriptionTextBoxFieldName
        {
            get { return (string)GetValue(DescriptionTextBoxFieldNameProperty); }
            set { SetValue(DescriptionTextBoxFieldNameProperty, value); }
        }

        public static readonly DependencyProperty DescriptionTextBoxFieldHeightProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldHeight",
                  typeof(int),
                  typeof(MachineDataField),
                  new PropertyMetadata(0)
              );

        public int DescriptionTextBoxFieldHeight
        {
            get { return (int)GetValue(DescriptionTextBoxFieldHeightProperty); }
            set { SetValue(DescriptionTextBoxFieldHeightProperty, value); }
        }

        public static readonly DependencyProperty DescriptionTextBoxFieldWidthProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldWidth",
                  typeof(int),
                  typeof(MachineDataField),
                  new PropertyMetadata(0)
             );

        public int DescriptionTextBoxFieldWidth
        {
            get { return (int)GetValue(DescriptionTextBoxFieldWidthProperty); }
            set { SetValue(DescriptionTextBoxFieldWidthProperty, value); }
        }

        public static readonly DependencyProperty FieldTextBoxTextProperty
            = DependencyProperty.Register(
                  "FieldTextBoxText",
                  typeof(string),
                  typeof(MachineDataField),
                  new PropertyMetadata("")
             );

        public string FieldTextBoxText
        {
            get { return (string)GetValue(FieldTextBoxTextProperty); }
            set { SetValue(FieldTextBoxTextProperty, value); }
        }

        /* End of DescriptionTextBoxField */

        /* Start of ImagesFileSelectionField */
        public static readonly DependencyProperty ImagesFileSelectionFieldNameProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldName",
                  typeof(string),
                  typeof(MachineDataField),
                  new PropertyMetadata("")
             );

        public string ImagesFileSelectionFieldName
        {
            get { return (string)GetValue(DescriptionTextBoxFieldNameProperty); }
            set { SetValue(DescriptionTextBoxFieldNameProperty, value); }
        }

        /* Field TextBox Text Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldTextProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldText",
                  typeof(string),
                  typeof(MachineDataField),
                  new PropertyMetadata("")
              );

        public string ImagesFileSelectionFieldText
        {
            get { return (string)GetValue(ImagesFileSelectionFieldTextProperty); }
            set { SetValue(ImagesFileSelectionFieldTextProperty, value); }
        }

        /* Field Button Text Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldButtonTextProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldButtonText",
                  typeof(string),
                  typeof(MachineDataField),
                  new PropertyMetadata("")
              );

        public string ImagesFileSelectionFieldButtonText
        {
            get { return (string)GetValue(ImagesFileSelectionFieldButtonTextProperty); }
            set { SetValue(ImagesFileSelectionFieldButtonTextProperty, value); }
        }

        /* Field Button Width Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldButtonWidthProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldButtonWidth",
                  typeof(int),
                  typeof(MachineDataField),
                  new PropertyMetadata(0)
              );

        public int ImagesFileSelectionFieldButtonWidth
        {
            get { return (int)GetValue(ImagesFileSelectionFieldButtonWidthProperty); }
            set { SetValue(ImagesFileSelectionFieldButtonWidthProperty, value); }
        }

        /* Field Height Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldHeightProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldHeight",
                  typeof(int),
                  typeof(MachineDataField),
                  new PropertyMetadata(0)
              );

        public int ImagesFileSelectionFieldHeight
        {
            get { return (int)GetValue(DescriptionTextBoxFieldHeightProperty); }
            set { SetValue(DescriptionTextBoxFieldHeightProperty, value); }
        }

        /* Field TextBox Width Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldWidthProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldWidth",
                  typeof(int),
                  typeof(MachineDataField),
                  new PropertyMetadata(0)
             );

        public int ImagesFileSelectionFieldWidth
        {
            get { return (int)GetValue(DescriptionTextBoxFieldWidthProperty); }
            set { SetValue(DescriptionTextBoxFieldWidthProperty, value); }
        }

        /* End of MachineDataField */

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(MachineDataFieldVM),
                  typeof(MachineDataField),
                  new PropertyMetadata(new MachineDataFieldVM())
             );

        public MachineDataFieldVM ViewModel
        {
            get { return (MachineDataFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DescriptionTextBoxField.DataContext = ViewModel;
                this.ImagesFileSelectionField.DataContext = ViewModel;
            }
        }

        public MachineDataField()
        {
            InitializeComponent();
        }
    }

    public class MachineDataFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description
        {
            get => ScriptExample.MachineDataSection.Description;
            set => ScriptExample.MachineDataSection.Description = value;
        }
        public string Image
        {
            get => ScriptExample.MachineDataSection.Image != null ? ScriptExample.MachineDataSection.Image.LocalPath : "";
            set => ScriptExample.MachineDataSection.Image = new Uri(value);
        }

        public MachineDataFieldVM()
        {
            this.ScriptExample = new ScriptExampleModel();
        }

        public MachineDataFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
