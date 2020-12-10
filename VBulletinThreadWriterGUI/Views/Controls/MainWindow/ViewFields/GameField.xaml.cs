#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Views.Controls.General.Bases;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.ViewFields
{
    /// <summary>
    /// Interaction logic for GameField.xaml
    /// </summary>
    public partial class GameField : ComboBoxFieldBaseControl
    {
        public static readonly DependencyProperty
            FieldHeightProperty = DependencyProperty.Register(
            "FieldHeight", typeof(double), typeof(GameField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldComboBoxWidthProperty = DependencyProperty.Register(
            "FieldComboBoxWidth", typeof(double), typeof(GameField), new PropertyMetadata(Double.NaN));

        public static readonly DependencyProperty
            FieldNameProperty = DependencyProperty.Register(
            "FieldName", typeof(string), typeof(GameField), new PropertyMetadata(""));

        public static readonly DependencyProperty
            ViewModelProperty = DependencyProperty.Register(
            "ViewModel", typeof(GameFieldVM), typeof(GameField), new PropertyMetadata(new GameFieldVM()));

        public GameField()
        {
            InitializeComponent();
            this.DependencyObjectControl = this;
            this.FieldLabel = this.FieldLabelControl;
            this.FieldLabel.Loaded += Label_Loaded;
            this.FieldComboBox = this.FieldComboBoxControl;
            this.FieldComboBox.Loaded += ComboBox_Loaded;
        }

        public override ComboBoxFieldVM ComboBoxFieldViewModel { get => this.ViewModel; }

        public GameFieldVM ViewModel
        {
            get { return (GameFieldVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = ViewModel;
            }
        }

        public override void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            ViewModel.SelectedGame =
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.GamesItemSource.Where(o => o.Title.Equals(comboBox.SelectedItem as string)).First();
        }
    }

    public class GameFieldVM : ComboBoxFieldVM
    {
        private List<Game> gamesItemSource = new List<Game>();
        public List<Game> GamesItemSource
        {
            get => gamesItemSource;
            set
            {
                gamesItemSource = value;
                if(this.GamesItemSource == null)
                {
                    this.SelectedGame = null;
                }
                else
                {
                    if(this.GamesItemSource.Count > 0)
                    {
                        this.SelectedGame = this.GamesItemSource.First();

                    }
                    else
                    {
                        this.SelectedGame = null;
                    }
                }
            }
        }
        public override List<string> ItemsSource 
        { 
            get => this.GamesItemSource.Select(o => o.Title).ToList(); 
            set => throw new NotImplementedException();
        }

        public Game? SelectedGame { get; set; }
        public override string SelectedItem 
        { 
            get => this.SelectedGame != null ? this.SelectedGame.Title : "";
            set 
            {
                this.SelectedGame = this.GamesItemSource.Where(o => o.Title.Equals(value)).First();
            }
        }

        public GameFieldVM()
        {
            this.LabelName = "Game";
            this.GamesItemSource = new List<Game>();
        }

        public GameFieldVM(List<Game> games)
        {
            this.LabelName = "Game";
            this.GamesItemSource = games;
        }
    }
}
