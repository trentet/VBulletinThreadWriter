#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Models.GameModels.Factories;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.Fields
{
    /// <summary>
    /// Interaction logic for SkillField.xaml
    /// </summary>
    public partial class SkillField : UserControl, IComboBoxField
    {
        public SkillField()
        {
            InitializeComponent();
            this.FieldDataContextChanged += SkillField_DataContextChanged;
        }

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(SkillField),
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
                  typeof(SkillField),
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
                  typeof(SkillField),
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
                  typeof(SkillFieldVM),
                  typeof(SkillField),
                  new PropertyMetadata(new SkillFieldVM())
             );

        public SkillFieldVM ViewModel
        {
            get { return (SkillFieldVM)GetValue(ViewModelProperty); }
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
                  typeof(SkillField),
                  new PropertyMetadata(null)
             );

        public SelectionChangedEventHandler FieldComboBoxSelectionChanged
        {
            get { return (SelectionChangedEventHandler)GetValue(FieldComboBoxSelectionChangedProperty); }
            set
            {
                SetValue(FieldComboBoxSelectionChangedProperty, value);
                this.SkillFieldControl.FieldComboBoxSelectionChanged += FieldComboBoxSelectionChanged;
            }
        }

        /* DataContextChanged Property */

        public static readonly DependencyProperty FieldDataContextChangedProperty
            = DependencyProperty.Register(
                  "FieldDataContextChanged",
                  typeof(DependencyPropertyChangedEventHandler),
                  typeof(SkillField),
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

            if(ViewModel.SkillsItemSource == null)
            {
                ViewModel.SelectedSkill = null;
            }
            else
            {
                // ... Set SelectedItem as Window Title.
                ViewModel.SelectedSkill =
                    #pragma warning disable CS8602 // Dereference of a possibly null reference.
                    (comboBox.SelectedItem as string) == ""
                    #pragma warning restore CS8602 // Dereference of a possibly null reference.
                    ?
                    null
                    :
                    ViewModel.SkillsItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();

            }
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

        public void SkillField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is SkillField) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("SkillField_DataContextChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                this.SkillFieldControl.ViewModel =
                    new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
            }
        }

        public void ReloadViewModel()
        {
            this.SkillFieldControl.ViewModel =
                new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
        }
    }

    public class SkillFieldVM : IComboBoxFieldVM
    {
        private Games? parentGame;
        public Games? ParentGame 
        { 
            get => parentGame;
            set
            {
                parentGame = value;
                if(this.ParentGame == null)
                {
                    this.SkillsItemSource = null;
                    this.SelectedSkill = null;
                }
                else
                {
                    this.SkillsItemSource = GameFactory.GetGame((Games)this.ParentGame).Skills;
                    this.SelectedSkill = this.SkillsItemSource.First();
                }
            }
        }
        public List<Skill>? SkillsItemSource { get; set; }
        public Skill? SelectedSkill { get; set; }
        public string LabelName { get; set; }
        public string SelectedItem
        {
            get => this.SelectedSkill != null ? this.SelectedSkill.Name : "";
            set
            {
                if(this.SkillsItemSource == null)
                {
                    this.SelectedSkill = null;
                }
                else
                {
                    this.SelectedSkill = this.SkillsItemSource.Where(o => o.Name.Equals(value)).First();
                }   
            }
        }

        public List<string> ItemsSource
        {
            get
            {
                if(this.SkillsItemSource == null)
                {
                    return new List<string>();
                }
                else
                {
                    return this.SkillsItemSource.Select(o => o.Name).ToList();
                }
            }
            set => throw new NotImplementedException();
        }

        public SkillFieldVM()
        {
            this.LabelName = "Skill";
            this.ParentGame = null;
        }

        public SkillFieldVM(Games parentGame)
        {
            this.LabelName = "Skill";
            this.ParentGame = parentGame;
        }
    }
}
