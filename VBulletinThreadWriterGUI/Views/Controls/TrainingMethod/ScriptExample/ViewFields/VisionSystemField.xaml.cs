#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.ViewFields
{
    /// <summary>
    /// Interaction logic for VisionSystemField.xaml
    /// </summary>
    /// 
    public partial class VisionSystemField : ComboBoxFieldBaseControl
    {
        /* Start of Custom Properties */

        public static readonly DependencyProperty
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(VisionSystemField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldComboBoxWidthProperty = DependencyProperty.Register(
            "FieldComboBoxWidth", typeof(double), typeof(VisionSystemField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(VisionSystemField), new PropertyMetadata(""));

        /* View Model Property */

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(VisionSystemFieldVM), typeof(VisionSystemField), new PropertyMetadata(new VisionSystemFieldVM()));

        public override ComboBoxFieldVM ComboBoxFieldViewModel { get => this.ViewModel; }

        public VisionSystemFieldVM ViewModel
        {
            get { return (VisionSystemFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }

        public VisionSystemField() : base(typeof(VisionSystemField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldComboBox = this.FieldComboBoxControl;
            this.FieldComboBox.Loaded += ComboBox_Loaded;
        }

        public override void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            ViewModel.SelectedVisionSystem =
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                (VisionSystems?)null
                :
                ViewModel.VisionSystemsItemSource.Where(o => o.ToDescription().Equals(comboBox.SelectedItem as string)).First();
        }

        public override void LoadComboBox(ComboBox comboBox)
        {
            if(comboBox != null)
            {
                comboBox.ItemsSource = ViewModel.ItemsSource;
                comboBox.SelectedIndex = ViewModel.ItemsSource.IndexOf(ViewModel.SelectedItem);
            }
        }

        public void ReloadViewModel()
        {
            //this.ViewModel =
            //    new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
        }
    }

    public class VisionSystemFieldVM : ComboBoxFieldVM
    {
        private List<VisionSystems> visionSystemsItemSource;
        public List<VisionSystems> VisionSystemsItemSource
        {
            get => visionSystemsItemSource;
            set
            {
                visionSystemsItemSource = value;
                if (this.VisionSystemsItemSource == null)
                {
                    this.SelectedVisionSystem = null;
                }
                else
                {
                    if (this.VisionSystemsItemSource.Count > 0)
                    {
                        this.SelectedVisionSystem = null;
                    }
                    else
                    {
                        this.SelectedVisionSystem = null;
                    }
                }
            }
        }
        public VisionSystems? SelectedVisionSystem { get; set; }

        public override List<string> ItemsSource
        {
            get => this.VisionSystemsItemSource.Select(o => o.ToDescription()).ToList();
            set => throw new NotImplementedException();
        }

        public override string SelectedItem
        {
            get => this.SelectedVisionSystem != null ? this.SelectedVisionSystem.ToDescription() : "";
            set
            {
                this.SelectedVisionSystem = this.VisionSystemsItemSource.Where(o => o.ToDescription().Equals(value)).First();
            }
        }

        public VisionSystemFieldVM()
        {
            this.LabelName = "Vision System";
            this.SelectedVisionSystem = null;
            visionSystemsItemSource = Enum.GetValues(typeof(VisionSystems)).Cast<VisionSystems>().ToList();
        }

        public VisionSystemFieldVM(VisionSystems? selectedVisionSystem)
        {
            this.LabelName = "Vision System";
            this.SelectedVisionSystem = selectedVisionSystem;
            visionSystemsItemSource = Enum.GetValues(typeof(VisionSystems)).Cast<VisionSystems>().ToList();
        }
    }
}
