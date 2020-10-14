#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.Fields
{
    /// <summary>
    /// Interaction logic for TrainingMethodField.xaml
    /// </summary>
    public partial class TrainingMethodField : UserControl, IComboBoxField
    {
        public TrainingMethodField()
        {
            InitializeComponent();
            this.FieldDataContextChanged += TrainingMethodField_DataContextChanged;
            this.TrainingMethodFieldControl.FieldComboBoxSelectionChanged += ComboBox_SelectionChanged;
            this.TrainingMethodFieldControl.FieldDataContextChanged += ComboBox_DataContextChanged;
        }

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(TrainingMethodField),
                  new PropertyMetadata(0)
              );

        public int FieldHeight
        {
            get { return (int)GetValue(FieldHeightProperty); }
            set { SetValue(FieldHeightProperty, value); }
        }

        /* Field ComboBox Width Property */

        public static readonly DependencyProperty FieldComboBoxWidthProperty
            = DependencyProperty.Register(
                  "FieldComboBoxWidth",
                  typeof(int),
                  typeof(TrainingMethodField),
                  new PropertyMetadata(0)
             );

        public int FieldComboBoxWidth
        {
            get { return (int)GetValue(FieldComboBoxWidthProperty); }
            set { SetValue(FieldComboBoxWidthProperty, value); }
        }

        /* Field Name Property */

        public static readonly DependencyProperty FieldNameProperty
            = DependencyProperty.Register(
                  "FieldName",
                  typeof(string),
                  typeof(TrainingMethodField),
                  new PropertyMetadata("")
             );

        public string FieldName
        {
            get { return (string)GetValue(FieldNameProperty); }
            set { SetValue(FieldNameProperty, value); }
        }

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(TrainingMethodFieldVM),
                  typeof(TrainingMethodField),
                  new PropertyMetadata(new TrainingMethodFieldVM())
             );

        public TrainingMethodFieldVM ViewModel
        {
            get { return (TrainingMethodFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }

        /* SelectionChanged Property */

        public static readonly DependencyProperty FieldComboBoxSelectionChangedProperty
            = DependencyProperty.Register(
                  "FieldComboBoxSelectionChanged",
                  typeof(SelectionChangedEventHandler),
                  typeof(TrainingMethodField),
                  new PropertyMetadata(null)
             );

        public SelectionChangedEventHandler FieldComboBoxSelectionChanged
        {
            get { return (SelectionChangedEventHandler)GetValue(FieldComboBoxSelectionChangedProperty); }
            set
            {
                SetValue(FieldComboBoxSelectionChangedProperty, value);
                this.TrainingMethodFieldControl.FieldComboBoxSelectionChanged += FieldComboBoxSelectionChanged;
            }
        }

        /* DataContextChanged Property */

        public static readonly DependencyProperty FieldDataContextChangedProperty
            = DependencyProperty.Register(
                  "FieldDataContextChanged",
                  typeof(DependencyPropertyChangedEventHandler),
                  typeof(TrainingMethodField),
                  new PropertyMetadata(null)
             );

        public DependencyPropertyChangedEventHandler FieldDataContextChanged
        {
            get { return (DependencyPropertyChangedEventHandler)GetValue(FieldDataContextChangedProperty); }
            set 
            { 
                SetValue(FieldDataContextChangedProperty, value); 
                this.DataContextChanged += FieldDataContextChanged; 
            }
        }

        IComboBoxFieldVM IComboBoxField.ViewModel
        {
            get => ViewModel;
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ComboBox_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is ComboBox) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("ComboBox_DataContextChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                ComboBox? comboBox = sender as ComboBox;
                #pragma warning disable CS8604 // Possible null reference argument.
                LoadComboBox(comboBox);
                #pragma warning restore CS8604 // Possible null reference argument.
            }
        }

        public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            LoadComboBox(sender as ComboBox);
            #pragma warning restore CS8604 // Possible null reference argument.
        }

        public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            ViewModel.SelectedTrainingMethod =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.TrainingMethodItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();
        }

        public void Label_Loaded(object sender, RoutedEventArgs e)
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            LoadLabel(sender as Label);
            #pragma warning restore CS8604 // Possible null reference argument.
        }

        public void LoadComboBox(ComboBox comboBox)
        {
            comboBox.ItemsSource = ViewModel.ItemsSource;

            // ... Make the first item selected.
            comboBox.SelectedIndex = 0;
        }

        public void LoadLabel(Label label)
        {
            label.Content = ViewModel.LabelName;
        }

        public void TrainingMethodField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is TrainingMethodField) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("TrainingMethodField_DataContextChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                ReloadViewModel();
            }
        }

        public void ReloadViewModel()
        {
            this.TrainingMethodFieldControl.ViewModel =
                   new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
        }
    }

    public class TrainingMethodFieldVM : IComboBoxFieldVM
    {
        private Skill? parentSkill;
        public Skill? ParentSkill 
        { 
            get => parentSkill;
            set
            {
                parentSkill = value;
                if (this.ParentSkill == null)
                {
                    this.TrainingMethodItemSource = new List<TrainingMethodModel>();
                    this.SelectedTrainingMethod = null;
                }
                else
                {
                    this.TrainingMethodItemSource = this.ParentSkill.TrainingMethods;
                    this.SelectedTrainingMethod = this.TrainingMethodItemSource.First();
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
                if(this.TrainingMethodItemSource == null)
                {
                    this.SelectedTrainingMethod = null;
                }
                else
                {
                    this.SelectedTrainingMethod = this.TrainingMethodItemSource.Count > 0 ? this.TrainingMethodItemSource.First() : null;
                }
            }
        }
        public TrainingMethodModel? SelectedTrainingMethod { get; set; }

        public string LabelName { get; set; }
        public string SelectedItem
        {
            get => this.SelectedTrainingMethod != null ? this.SelectedTrainingMethod.Name : "";
            set
            {
                this.SelectedTrainingMethod = this.TrainingMethodItemSource.Where(o => o.Name.Equals(value)).First();
            }
        }

        public List<string> ItemsSource
        {
            get => this.TrainingMethodItemSource.Select(o => o.Name).ToList();
            set 
            {
                throw new NotImplementedException();
            }
        }

        public TrainingMethodFieldVM()
        {
            this.LabelName = "Training Method";
            this.ParentSkill = null;
            this.TrainingMethodItemSource = new List<TrainingMethodModel>();
        }

        public TrainingMethodFieldVM(Skill selectedSkill)
        {
            this.LabelName = "Training Method";
            this.ParentSkill = selectedSkill;
            if(selectedSkill == null)
            {
                this.TrainingMethodItemSource = new List<TrainingMethodModel>();
            }
            else
            {
                this.TrainingMethodItemSource = selectedSkill.TrainingMethods;
            }
        }
    }
}
