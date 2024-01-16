using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilScrollFixer
{
    public static class MouseSimulator
    {
        public static void Scroll(MouseWheelDirection direction, int delta)
        {
            int deltaValue = (direction == MouseWheelDirection.Up) ? delta : -delta;
            mouse_event(MOUSEEVENTF_WHEEL, 0, 0, deltaValue, 0);
        }

        private const int MOUSEEVENTF_WHEEL = 0x800;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo); 
    }

    public enum MouseWheelDirection
    {
        Up,
        Down
    }
}
