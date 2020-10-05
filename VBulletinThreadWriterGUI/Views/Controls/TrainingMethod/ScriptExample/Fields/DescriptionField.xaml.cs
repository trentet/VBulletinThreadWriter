﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VBulletinThreadWriterGUI.Models.TrainingMethodModels;
using VBulletinThreadWriterGUI.Views.Controls.General;

namespace VBulletinThreadWriterGUI.Views.Controls.TrainingMethod.ScriptExample.Fields{
    /// <summary>
    /// Interaction logic for DescriptionField.xaml
    /// </summary>
    public partial class DescriptionField : UserControl
    {
        public DescriptionField()
        {
            InitializeComponent();
        }
    }

    public class DescriptionFieldVM
    {
        public ScriptExampleModel ScriptExample { get; set; }
        public string Description { get => ScriptExample.Description; set => ScriptExample.Description = value; }

        public DescriptionFieldVM(ScriptExampleModel scriptExample)
        {
            this.ScriptExample = scriptExample;
        }
    }
}