#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.ViewFields
{
    /// <summary>
    /// Interaction logic for TrainingMethodField.xaml
    /// </summary>
    /// 
    public partial class TrainingMethodField : ComboBoxFieldBaseControl
    {
        /* Start of Custom Properties */

        public static readonly DependencyProperty
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(TrainingMethodField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldComboBoxWidthProperty = DependencyProperty.Register(
            "FieldComboBoxWidth", typeof(double), typeof(TrainingMethodField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(TrainingMethodField), new PropertyMetadata(""));

        /* View Model Property */

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(TrainingMethodFieldVM), typeof(TrainingMethodField), new PropertyMetadata(new TrainingMethodFieldVM()));

        public TrainingMethodFieldVM ViewModel
        {
            get { return (TrainingMethodFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                DataContext = ViewModel;
            }
        }

        public override ComboBoxFieldVM ComboBoxFieldViewModel { get => this.ViewModel; }

        public TrainingMethodField() : base(typeof(TrainingMethodField))
        {
            InitializeComponent();
            DependencyObjectControl = this;
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
            ViewModel.SelectedTrainingMethod =
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                comboBox.SelectedItem as string == "" || comboBox.SelectedItem as string == null
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.TrainingMethodItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();
        }
    }

    public class TrainingMethodFieldVM : ComboBoxFieldVM
    {
        private Skill? parentSkill;
        public Skill? ParentSkill
        {
            get => parentSkill;
            set
            {
                parentSkill = value;
                if (ParentSkill == null)
                {
                    TrainingMethodItemSource = new List<TrainingMethodModel>();
                    SelectedTrainingMethod = null;
                }
                else
                {
                    TrainingMethodItemSource = ParentSkill.TrainingMethods;
                    SelectedTrainingMethod = TrainingMethodItemSource.First();
                }
            }
        }
        private List<TrainingMethodModel> trainingMethodItemSource = new List<TrainingMethodModel>();
        public List<TrainingMethodModel> TrainingMethodItemSource
        {
            get => trainingMethodItemSource;
            set
            {
                trainingMethodItemSource = value;
                if (TrainingMethodItemSource == null || TrainingMethodItemSource.Count == 0)
                {
                    SelectedTrainingMethod = null;
                }
                else
                {
                    SelectedTrainingMethod = TrainingMethodItemSource.Count > 0 ? TrainingMethodItemSource.First() : null;
                }
            }
        }
        public TrainingMethodModel? SelectedTrainingMethod { get; set; }

        public override string SelectedItem
        {
            get => SelectedTrainingMethod != null ? SelectedTrainingMethod.Name : "";
            set
            {
                SelectedTrainingMethod = 
                    value == null || value.Trim() == "" || TrainingMethodItemSource.Count == 0
                    ? 
                    null 
                    : 
                    TrainingMethodItemSource.Where(o => o.Name.Equals(value)).First();
            }
        }

        public override List<string> ItemsSource
        {
            get => TrainingMethodItemSource.Select(o => o.Name).ToList();
            set
            {
                throw new NotImplementedException();
            }
        }

        public TrainingMethodFieldVM()
        {
            LabelName = "Training Method";
            ParentSkill = null;
            TrainingMethodItemSource = new List<TrainingMethodModel>();
        }

        public TrainingMethodFieldVM(Skill selectedSkill)
        {
            LabelName = "Training Method";
            ParentSkill = selectedSkill;
            if (selectedSkill == null)
            {
                TrainingMethodItemSource = new List<TrainingMethodModel>();
            }
            else
            {
                TrainingMethodItemSource = selectedSkill.TrainingMethods;
            }
        }
    }
}
