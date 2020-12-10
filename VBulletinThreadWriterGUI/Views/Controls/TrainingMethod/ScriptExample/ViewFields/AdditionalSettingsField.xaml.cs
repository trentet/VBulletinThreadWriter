using System;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels.Fields;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for AdditionalSettingsField.xaml
    /// </summary>
    public partial class AdditionalSettingsField : UserControl
    {
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
                this.DescriptionTextBoxField.DataContext = this.ViewModel.DescriptionFieldViewModel;
                //this.ImagesFileSelectionField.DataContext = ViewModel;
            }
        }

        public AdditionalSettingsField()
        {
            InitializeComponent();
            this.DescriptionTextBoxField.FieldName = "Description";
        }
    }

    public class AdditionalSettingsFieldVM
    {
        private AdditionalSettingsSection additionalSettings;
        //private TextBoxFieldVM descriptionFieldViewModel;
        public TextBoxFieldVM DescriptionFieldViewModel { get; set; }
        //private FileSelectionTextBoxField

        public AdditionalSettingsSection AdditionalSettings 
        {
            get => additionalSettings;
            set 
            {
                if(additionalSettings == null)
                {
                    additionalSettings = new AdditionalSettingsSection();
                }
                else
                {
                    additionalSettings = value;
                }
                
                AdditionalSettings_OnChanged();
            } 
        }
        
        private void AdditionalSettings_OnChanged()
        {
            this.DescriptionFieldViewModel.Text = this.Description;
            //Needs Images view model code
        }

        public string Description 
        {
            get => AdditionalSettings.Description; 
            set => AdditionalSettings.Description = value; 
        }

        public string Image 
        { 
            get => AdditionalSettings.Image != null ? AdditionalSettings.Image.LocalPath : ""; 
            set => AdditionalSettings.Image = new Uri(value); 
        }

        public AdditionalSettingsFieldVM()
        {
            this.DescriptionFieldViewModel = new DescriptionFieldVM();
            this.AdditionalSettings = new AdditionalSettingsSection();
        }

        public AdditionalSettingsFieldVM(AdditionalSettingsSection additionalSettings)
        {
            this.DescriptionFieldViewModel = new DescriptionFieldVM();
            this.AdditionalSettings = additionalSettings;
        }
    }
}
