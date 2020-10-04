using VBulletinThreadWriterGUI.Views.Controls.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VBulletinThreadWriterGUI.ViewModels
{
    public class ReleaseFieldVM : ComboBoxFieldVM
    {
        public ReleaseFieldVM()
        {
            this.ItemsSource = new List<string>() { "R1", "R2", "Finance" };
            this.SelectedItem = this.ItemsSource.FirstOrDefault();
        }
    }
}
