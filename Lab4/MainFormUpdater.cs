using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Main
{
    public class MainFormUpdater
    {
        public void UpdateTextBox(MainForm form)
        {
            form.keyTextBox.Text = form.key;
        }
    }
}
