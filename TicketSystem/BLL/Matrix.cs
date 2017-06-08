using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Matrix
    {
        //根据行查找到本行最大的列数
        public static System.Windows.Forms.Control FindControlMaxCol(int row, List<Metrix> mlist)
        {
            int colMax = 0;
            foreach (Metrix item in mlist)
            {
                if (item.row == row)
                {
                    if (item.col > colMax)
                        colMax = item.col;
                }
            }
            return FindControl(row, colMax, mlist);
        }

        //根据坐标查找到对应的控件
        public static System.Windows.Forms.Control FindControl(int row, int col, List<Metrix> mtrix)
        {
            System.Windows.Forms.Control SetFocusTextBox = null;
            foreach (Metrix item in mtrix)
            {
                if (item.col == col && item.row == row)
                {
                    SetFocusTextBox = item.ctrl;
                }
            }

            return SetFocusTextBox;

        }

    }
}
