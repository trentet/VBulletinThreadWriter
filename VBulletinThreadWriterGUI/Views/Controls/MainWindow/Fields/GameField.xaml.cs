#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow.Fields
{
    /// <summary>
    /// Interaction logic for GameField.xaml
    /// </summary>
    public partial class GameField : UserControl, IComboBoxField
    {
        public GameField()
        {
            InitializeComponent();
            this.FieldDataContextChanged += GameField_DataContextChanged;
        }

        /* Field Height Property */

        public static readonly DependencyProperty FieldHeightProperty
            = DependencyProperty.Register(
                  "FieldHeight",
                  typeof(int),
                  typeof(GameField),
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
                  typeof(GameField),
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
                  typeof(GameField),
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
                  typeof(GameFieldVM),
                  typeof(GameField),
                  new PropertyMetadata(new GameFieldVM())
             );

        public GameFieldVM ViewModel
        {
            get { return (GameFieldVM)GetValue(ViewModelProperty); }
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
                  typeof(GameField),
                  new PropertyMetadata(null)
             );

        public SelectionChangedEventHandler FieldComboBoxSelectionChanged
        {
            get { return (SelectionChangedEventHandler)GetValue(FieldComboBoxSelectionChangedProperty); }
            set 
            { 
                SetValue(FieldComboBoxSelectionChangedProperty, value); 
                this.GameFieldControl.FieldComboBoxSelectionChanged += FieldComboBoxSelectionChanged; 
            }
        }

        /* DataContextChanged Property */

        public static readonly DependencyProperty FieldDataContextChangedProperty
            = DependencyProperty.Register(
                  "FieldDataContextChanged",
                  typeof(DependencyPropertyChangedEventHandler),
                  typeof(GameField),
                  new PropertyMetadata(null)
             );

        public DependencyPropertyChangedEventHandler FieldDataContextChanged
        {
            get { return (DependencyPropertyChangedEventHandler)GetValue(FieldDataContextChangedProperty); }
            set { SetValue(FieldDataContextChangedProperty, value); this.DataContextChanged += FieldDataContextChanged; }
        }

        IComboBoxFieldVM IComboBoxField.ViewModel 
        { 
            get => ViewModel;
            set
            {
                throw new NotImplementedException();
            } 
        }

        public void GameField_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is GameField) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("GameField_DataContextChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                this.GameFieldControl.ViewModel =
                    new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
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
            ViewModel.SelectedGame =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.GamesItemSource.Where(o => o.Title.Equals(comboBox.SelectedItem as string)).First();
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

        public void ReloadViewModel()
        {
            this.GameFieldControl.ViewModel =
                new ComboBoxFieldVM(ViewModel.LabelName, ViewModel.SelectedItem, ViewModel.ItemsSource);
        }
    }

    public class GameFieldVM : IComboBoxFieldVM
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
        public List<string> ItemsSource 
        { 
            get => this.GamesItemSource.Select(o => o.Title).ToList(); 
            set => throw new NotImplementedException();
        }

        public Game? SelectedGame { get; set; }
        public string SelectedItem 
        { 
            get => this.SelectedGame != null ? this.SelectedGame.Title : "";
            set 
            {
                this.SelectedGame = this.GamesItemSource.Where(o => o.Title.Equals(value)).First();
            }
        }

        public string LabelName { get; set; }

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
