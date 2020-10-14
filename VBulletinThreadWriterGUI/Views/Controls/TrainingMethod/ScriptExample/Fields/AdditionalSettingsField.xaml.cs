using System;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields
{
    /// <summary>
    /// Interaction logic for AdditionalSettingsField.xaml
    /// </summary>
    public partial class AdditionalSettingsField : UserControl
    {
        /* Start of DescriptionTextBoxField */
        public static readonly DependencyProperty DescriptionTextBoxFieldNameProperty
            = DependencyProperty.Register(
                  "DescriptionTextBoxFieldName",
                  typeof(string),
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
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
                  typeof(AdditionalSettingsField),
                  new PropertyMetadata(0)
             );

        public int ImagesFileSelectionFieldWidth
        {
            get { return (int)GetValue(DescriptionTextBoxFieldWidthProperty); }
            set { SetValue(DescriptionTextBoxFieldWidthProperty, value); }
        }
        
        /* End of AdditionalSettingsField */

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(AdditionalSettingsFieldVM),
                  typeof(AdditionalSettingsField),
                  new PropertyMetadata(new AdditionalSettingsFieldVM())
             );
        
        public AdditionalSettingsFieldVM ViewModel
        {
            get { return (AdditionalSettingsFieldVM)GetValue(ViewModelProperty); }
            set 
            { 
                SetValue(ViewModelProperty, value); 
                this.DescriptionTextBoxField.DataContext = ViewModel;
                this.ImagesFileSelectionField.DataContext = ViewModel;
            }
        }

        public AdditionalSettingsField()
        {
            InitializeComponent();
        }
    }

    public class AdditionalSettingsFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description 
        { 
            get => ScriptExample.AdditionalSettingsSection.Description; 
            set => ScriptExample.AdditionalSettingsSection.Description = value; 
        }
        public string Image 
        { 
            get => ScriptExample.AdditionalSettingsSection.Image != null ? ScriptExample.AdditionalSettingsSection.Image.LocalPath : ""; 
            set => ScriptExample.AdditionalSettingsSection.Image = new Uri(value); }

        public AdditionalSettingsFieldVM()
        {
            this.ScriptExample = new ScriptExampleModel();
        }

        public AdditionalSettingsFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}
