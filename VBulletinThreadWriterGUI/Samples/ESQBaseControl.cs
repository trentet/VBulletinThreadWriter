using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace VBulletinThreadWriterGUI.Samples
{
    public class ESQBaseControl : UserControl
    {
        #region Constructor

        protected ESQBaseControl()
        {
            // protected constructor is required so that derived controls can have default parameterless constructor which is needed for xaml 
            // also protected constructor will ensure that new control creation always use constructor by passing parameters (e.g. in this example passing of string parameter is must in order to construct control)
        }

        public ESQBaseControl(string info)
        {

        }

        #endregion

        #region base implementation

        public virtual void SomeOperation()
        {

        }

        #endregion
    }
}
