using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Common
{
    public class StyleSet
    {
        #region ClearErrorStyle(TextBox tbox) SetErrorStyle(TextBox tbox) 数据校验失败样式设置及清除
        public static void ClearErrorStyle(TextBox tbox)
        {
            tbox.BackColor = Color.White;
        }

        public static void SetErrorStyle(TextBox tbox)
        {
            tbox.BackColor = Color.DeepSkyBlue;
        }

        public static void ClearErrorStyle(Control tbox)
        {
            tbox.BackColor = Color.White;
        }

        public static void SetErrorStyle(Control tbox)
        {
            tbox.BackColor = Color.DeepSkyBlue;
        }
        #endregion
    }
}
