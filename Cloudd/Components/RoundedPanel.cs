using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cloudd
{
    public partial class RoundedPanel : Panel
    {
        public RoundedPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(Program.CreateRoundRectRgn(2, 3, Width, Height, 15, 15));
        }
    }
}
