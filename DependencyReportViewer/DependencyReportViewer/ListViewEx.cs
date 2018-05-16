using System;
using System.Windows.Forms;

namespace DependencyReportViewer
{
    public class ListViewEx : ListView
    {
        public ListViewEx() : base()
        {
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true
            );
        }
    }
}
