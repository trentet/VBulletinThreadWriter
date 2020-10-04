#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using VBulletinThreadWriterGUI.Models;
using VBulletinThreadWriterGUI.Models.GameModels;
using VBulletinThreadWriterGUI.Models.GameModels.Factories;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static GameFieldVM GameFieldViewModel = new GameFieldVM(GameFactory.GetGames());
        public static SkillFieldVM SkillFieldViewModel = new SkillFieldVM();
        public static TrainingMethodFieldVM TrainingMethodFieldViewModel = new TrainingMethodFieldVM();
        public MainWindow()
        {
            InitializeComponent();
            this.GameField.FieldComboBoxSelectionChanged += GameField_SelectionChanged;
            this.SkillField.FieldComboBoxSelectionChanged += SkillField_SelectionChanged;
            this.TrainingMethodField.FieldComboBoxSelectionChanged += TrainingMethodField_SelectionChanged;
            ReloadViewModels();
        }

        private void ReloadViewModels()
        {
            this.GameField.ViewModel = GameFieldViewModel;
            this.SkillField.ViewModel = SkillFieldViewModel;
            this.TrainingMethodField.ViewModel = TrainingMethodFieldViewModel;
        }

        private void GameField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(sender is ComboBox comboBox))
            {
                throw new ArgumentException("GameField_SelectionChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
            }

            GameFieldViewModel.SelectedGame = 
                (comboBox.SelectedItem as string) == "" 
                ? 
                null 
                : 
                GameFieldViewModel.GamesItemSource.Where(o => o.Title.Equals(comboBox.SelectedItem as string)).First();

            SkillFieldViewModel.SkillsItemSource =
                GameFieldViewModel.SelectedGame == null
                ?
                new List<Skill>()
                :
                GameFieldViewModel.SelectedGame.Skills;

            ReloadViewModels();
        }

        private void SkillField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(sender is ComboBox comboBox))
            {
                throw new ArgumentException("SkillField_SelectionChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
            }

            SkillFieldViewModel.SelectedSkill =
                (comboBox.SelectedItem as string) == ""
                ?
                null
                :
                SkillFieldViewModel.SkillsItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();

            TrainingMethodFieldViewModel.TrainingMethodItemSource =
                SkillFieldViewModel.SelectedSkill == null
                ?
                new List<TrainingMethodModel>()
                :
                SkillFieldViewModel.SelectedSkill.TrainingMethods;

            ReloadViewModels();
        }

        private void TrainingMethodField_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(sender is ComboBox comboBox))
            {
                throw new ArgumentException("TrainingMethodField_SelectionChanged sender is not a ComboBox. Actual: " + sender.GetType().FullName);
            }

            TrainingMethodFieldViewModel.SelectedTrainingMethod =
                (comboBox.SelectedItem as string) == ""
                ?
                null
                :
                TrainingMethodFieldViewModel.TrainingMethodItemSource.Where(o => o.Name.Equals(comboBox.SelectedItem as string)).First();

            ReloadViewModels();
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
                this.GamesItemSource_OnPropertyChanged();
            }
        }
        public Game? SelectedGame { get; set; }
        public GameFieldVM(List<Game> games)
        {
            this.LabelName = "Game";
            this.GamesItemSource = games;
        }

        private void GamesItemSource_OnPropertyChanged()
        {
            this.ItemsSource = this.GamesItemSource.Select(o => o.Title).ToList();
            this.SelectedItem = this.SelectedGame != null ? this.SelectedGame.Title : "";
        }
    }

    public class SkillFieldVM : ComboBoxFieldVM
    {
        private List<Skill> skillsItemSource = new List<Skill>();
        public List<Skill> SkillsItemSource
        {
            get => skillsItemSource;
            set
            {
                skillsItemSource = value;
                SkillsItemSource_OnPropertyChanged();
            }
        }
        public Skill? SelectedSkill { get; set; }
        public SkillFieldVM()
        {
            this.LabelName = "Skill";
            this.SkillsItemSource = new List<Skill>();
        }

        private void SkillsItemSource_OnPropertyChanged()
        {
            this.ItemsSource = this.SkillsItemSource.Select(o => o.Name).ToList();
            this.SelectedItem = this.SelectedSkill != null ? this.SelectedSkill.Name : "";
        }
    }

    public class TrainingMethodFieldVM : ComboBoxFieldVM
    {
        private List<TrainingMethodModel> trainingMethodItemSource = new List<TrainingMethodModel>();
        public List<TrainingMethodModel> TrainingMethodItemSource
        {
            get => trainingMethodItemSource;
            set
            {
                trainingMethodItemSource = value;
                TrainingMethodItemSourceItemSource_OnPropertyChanged();
            }
        }
        public TrainingMethodModel? SelectedTrainingMethod { get; set; }
        public TrainingMethodFieldVM()
        {
            this.LabelName = "Training Method";
            this.TrainingMethodItemSource = new List<TrainingMethodModel>();
        }

        private void TrainingMethodItemSourceItemSource_OnPropertyChanged()
        {
            this.ItemsSource = this.TrainingMethodItemSource.Select(o => o.Name).ToList();
            this.SelectedItem = this.SelectedTrainingMethod != null ? this.SelectedTrainingMethod.Name : "";
        }
    }
}
