using System;
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

namespace VBulletinThreadWriterGUI.Samples
{
    /// <summary>
    /// Interaction logic for ESQConcreteControl.xaml
    /// </summary>
    public partial class ESQConcreteControl : ESQBaseControl
    {
        #region Constructor

        public ESQConcreteControl(string info) : base(info)
        {
            InitializeComponent();
        }

        #endregion

        #region Control implementation

        public override void SomeOperation()
        {
            this.MyTextBox.Text = "Hello World!!";
        }

        #endregion

    }
}
