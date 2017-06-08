using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    /// <summary>
    /// 快捷键使用类
    /// </summary>
    public class Metrix
    {
        public int row { get; set; }
        public int col { get; set; }
        public System.Windows.Forms.Control ctrl { get; set; }
        public List<Metrix> list { get; set; }
        public Metrix()
        {

        }
        public Metrix(System.Windows.Forms.Control[,] TextBoxs)
        {
            list = new List<Metrix>();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    list.Add(new Metrix
                    {
                        row = i,
                        col = j,
                        ctrl = TextBoxs[i, j]
                    });
                }
            }
        }
    }
}
