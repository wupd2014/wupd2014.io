using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class TextBoxEvent
    {
        #region TextBoxx获取焦点  全选文本框值
        public void textBox_MouseUp(object sender, MouseEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
                tb.SelectAll();
        }

        public void textBox_GotFocus(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
                tb.SelectAll();
        }
        #endregion
    }
}
