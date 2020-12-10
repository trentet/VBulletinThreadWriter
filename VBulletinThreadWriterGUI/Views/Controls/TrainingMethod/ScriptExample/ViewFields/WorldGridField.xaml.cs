using System;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for WorldGridField.xaml
    /// </summary>
    public partial class WorldGridField : UserControl
    {
        /* Start of DescriptionTextBoxField */
        public static readonly DependencyProperty DescriptionTextBoxFieldNameProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldName",
                  typeof(string),
                  typeof(WorldGridField),
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
                  typeof(double),
                  typeof(WorldGridField),
                  new PropertyMetadata(Double.NaN)
              );

        public double DescriptionTextBoxFieldHeight
        {
            get { return (double)GetValue(DescriptionTextBoxFieldHeightProperty); }
            set { SetValue(DescriptionTextBoxFieldHeightProperty, value); }
        }

        public static readonly DependencyProperty DescriptionTextBoxFieldWidthProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldWidth",
                  typeof(double),
                  typeof(WorldGridField),
                  new PropertyMetadata(Double.NaN)
             );

        public double DescriptionTextBoxFieldWidth
        {
            get { return (double)GetValue(DescriptionTextBoxFieldWidthProperty); }
            set { SetValue(DescriptionTextBoxFieldWidthProperty, value); }
        }

        public static readonly DependencyProperty FieldTextBoxTextProperty
            = DependencyProperty.Register(
                  "FieldTextBoxText",
                  typeof(string),
                  typeof(WorldGridField),
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
                  typeof(WorldGridField),
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
                  typeof(WorldGridField),
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
                  typeof(WorldGridField),
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
                  typeof(double),
                  typeof(WorldGridField),
                  new PropertyMetadata(Double.NaN)
              );

        public double ImagesFileSelectionFieldButtonWidth
        {
            get { return (double)GetValue(ImagesFileSelectionFieldButtonWidthProperty); }
            set { SetValue(ImagesFileSelectionFieldButtonWidthProperty, value); }
        }

        /* Field Height Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldHeightProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldHeight",
                  typeof(double),
                  typeof(WorldGridField),
                  new PropertyMetadata(Double.NaN)
              );

        public double ImagesFileSelectionFieldHeight
        {
            get { return (double)GetValue(DescriptionTextBoxFieldHeightProperty); }
            set { SetValue(DescriptionTextBoxFieldHeightProperty, value); }
        }

        /* Field TextBox Width Property */

        public static readonly DependencyProperty ImagesFileSelectionFieldWidthProperty
            = DependencyProperty.Register(
                  "ImagesFileSelectionFieldWidth",
                  typeof(double),
                  typeof(WorldGridField),
                  new PropertyMetadata(Double.NaN)
             );

        public double ImagesFileSelectionFieldWidth
        {
            get { return (double)GetValue(DescriptionTextBoxFieldWidthProperty); }
            set { SetValue(DescriptionTextBoxFieldWidthProperty, value); }
        }

        /* End of WorldGridField */

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(WorldGridFieldVM),
                  typeof(WorldGridField),
                  new PropertyMetadata(new WorldGridFieldVM())
             );

        public WorldGridFieldVM ViewModel
        {
            get { return (WorldGridFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                //this.DescriptionTextBoxField.DataContext = ViewModel;
                //this.ImagesFileSelectionField.DataContext = ViewModel;
            }
        }

        public WorldGridField()
        {
            InitializeComponent();
        }
    }

    public class WorldGridFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description 
        { 
            get => ScriptExample.WorldGridSection.Description; 
            set => ScriptExample.WorldGridSection.Description = value; 
        }
        
        public string Image 
        { 
            get => ScriptExample.WorldGridSection.Image != null ? ScriptExample.WorldGridSection.Image.LocalPath : ""; 
            set => ScriptExample.WorldGridSection.Image = new Uri(value); 
        }

        public WorldGridFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }

        public WorldGridFieldVM()
        {
            this.ScriptExample = new ScriptExampleModel();
        }
    }
}
