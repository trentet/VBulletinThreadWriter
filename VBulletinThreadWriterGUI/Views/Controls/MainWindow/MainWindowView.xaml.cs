using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models.GameModels.Factories;
using VBulletinThreadWriterGUI.Views.Controls.MainWindow.Fields;

namespace VBulletinThreadWriterGUI.Views.Controls.MainWindow
{
    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : UserControl
    {
        //public static MainWindowVM MainWindowViewModel = new MainWindowVM();
        public MainWindowView()
        {
            InitializeComponent();
            this.DataContextChanged += MainWindowView_DataContextChanged;
            this.GameFieldControl.FieldComboBoxSelectionChanged += GameField_SelectionChanged;
            this.SkillFieldControl.FieldComboBoxSelectionChanged += SkillField_SelectionChanged;
            this.TrainingMethodFieldControl.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            this.ViewModel = new MainWindowVM();
        }

        /* View Model Property */

        public static readonly DependencyProperty ViewModelProperty
            = DependencyProperty.Register(
                  "ViewModel",
                  typeof(MainWindowVM),
                  typeof(MainWindowView),
                  new PropertyMetadata(new MainWindowVM())
             );

        public MainWindowVM ViewModel
        {
            get { return (MainWindowVM)GetValue(ViewModelProperty); }
            set
            {
                SetValue(ViewModelProperty, value);
                this.DataContext = this.ViewModel;
            }
        }

        public void ReloadViewModels()
        {
            //this.GameFieldControl.ViewModel = new GameFieldVM();
            //this.SkillFieldControl.ViewModel = new SkillFieldVM();
            //this.TrainingMethodFieldControl.ViewModel = new TrainingMethodFieldVM();

            this.GameFieldControl.ViewModel = this.ViewModel.GameFieldViewModel;
            this.SkillFieldControl.ViewModel = this.ViewModel.SkillFieldViewModel;
            this.TrainingMethodFieldControl.ViewModel = this.ViewModel.TrainingMethodFieldViewModel;
        }

        public void MainWindowView_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is MainWindowView) || sender == null)
            {
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                throw new ArgumentException("MainWindowView_DataContextChanged sender is not a MainWindowView. Actual: " + sender.GetType().FullName);
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
            else
            {
                ReloadViewModels();
            }
        }

        public void GameField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            this.ViewModel.GameFieldViewModel.SelectedGame =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                this.ViewModel.GameFieldViewModel.GamesItemSource.Where(o => o.Title.Equals(comboBox.SelectedItem as string)).First();

            this.GameFieldControl.ReloadViewModel();
        }

        public void SkillField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            this.ViewModel.SkillFieldViewModel.SelectedSkill =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.SkillFieldViewModel.SkillsItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();

            this.ViewModel.TrainingMethodFieldViewModel.ParentSkill = ViewModel.SkillFieldViewModel.SelectedSkill;

            this.TrainingMethodFieldControl.ReloadViewModel();
        }

        public void TrainingMethodField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ... Get the ComboBox.
            var comboBox = sender as ComboBox;

            // ... Set SelectedItem as Window Title.
            ViewModel.TrainingMethodFieldViewModel.SelectedTrainingMethod =
                #pragma warning disable CS8602 // Dereference of a possibly null reference.
                (comboBox.SelectedItem as string) == "" || (comboBox.SelectedItem as string) == null
                #pragma warning restore CS8602 // Dereference of a possibly null reference.
                ?
                null
                :
                ViewModel.TrainingMethodFieldViewModel.TrainingMethodItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();
        }
    }

    public class MainWindowVM
    {
        private GameFieldVM gameFieldViewModel;
        public GameFieldVM GameFieldViewModel 
        {
            get => gameFieldViewModel;
            private set 
            {
                gameFieldViewModel = value;
                if(value.SelectedGame == null)
                {
                    this.SkillFieldViewModel = new SkillFieldVM();
                }
                else
                {
                    this.SkillFieldViewModel = new SkillFieldVM(value.SelectedGame.EnumValue);
                }
            }
        }
        private SkillFieldVM skillFieldViewModel;
        public SkillFieldVM SkillFieldViewModel
        {
            get => skillFieldViewModel;
            private set
            {
                skillFieldViewModel = value;
                this.TrainingMethodFieldViewModel = new TrainingMethodFieldVM(this.SkillFieldViewModel.SelectedSkill);
            }
        }
        public TrainingMethodFieldVM TrainingMethodFieldViewModel { get; private set; }

        public MainWindowVM()
        {
            this.GameFieldViewModel = new GameFieldVM(GameFactory.GetGames());
        }
    }
}
