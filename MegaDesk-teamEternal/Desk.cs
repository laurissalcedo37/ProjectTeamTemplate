using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_JimDeMordaunt
{
    public class Desk
    {
        public int width { get; set; }
        public int depth { get; set; }
        public int numDrawers { get; set; }
        public DesktopMaterial desktop { get; set; }

    public Desk(int inWidth, int inDepth, int inNumDrawers, string DesktopMatInput) {
            width = inWidth;
            depth = inDepth;
            numDrawers = inNumDrawers;
            desktop = (DesktopMaterial)Enum.Parse(typeof(DesktopMaterial), DesktopMatInput);
        }
        const int deskWidthMax = 96;
        const int deskWidthMin = 24;
        const int deskDepthMin = 12;
        const int deskDepthMax = 48;
       // int width 

    }
    public enum DesktopMaterial
    {
        Pine = 50, Laminate = 100, Oak = 200, Rosewood = 300, Veneer = 125
    };
}
