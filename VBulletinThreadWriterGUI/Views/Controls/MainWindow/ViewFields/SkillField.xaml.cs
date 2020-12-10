#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Models.GameModels.Factories;
using VBulletinThreadWriterGUI.Views.Controls.General;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.ViewFields
{
    /// <summary>
    /// Interaction logic for SkillField.xaml
    /// </summary>
    public partial class SkillField : ComboBoxFieldBaseControl
    {
        public SkillField() : base(typeof(SkillField))
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldComboBox = this.FieldComboBoxControl;
            this.FieldComboBox.Loaded += ComboBox_Loaded;
        }

        public static readonly DependencyProperty
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(ComboBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldComboBoxWidthProperty = DependencyProperty.Register(
            "FieldComboBoxWidth", typeof(double), typeof(ComboBoxField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(ComboBoxField), new PropertyMetadata(""));

        /* View Model Property */

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(SkillFieldVM), typeof(SkillField), new PropertyMetadata(new SkillFieldVM()));

        public SkillFieldVM ViewModel
        {
            get { return (SkillFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }

        public override ComboBoxFieldVM ComboBoxFieldViewModel { get => this.ViewModel; }

        public override void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
    }

    public class SkillFieldVM : ComboBoxFieldVM
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
        public override string SelectedItem
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

        public override List<string> ItemsSource
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
