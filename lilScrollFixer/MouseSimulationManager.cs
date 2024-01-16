using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lilScrollFixer
{
    public class MouseSimulationManager
    {
        private bool isSimulationActive = false;

        public void StartSimulation(int sensitivity)
        {
            if (!isSimulationActive)
            {
                isSimulationActive = true;
                Thread simulationThread = new Thread(() => SimulateScroll(sensitivity));
                simulationThread.Start();
            }
        }

        public void StopSimulation()
        {
            isSimulationActive = false;
        }

        private void SimulateScroll(int sensitivity)
        {
            while (isSimulationActive)
            {
                if (GetAsyncKeyState(Keys.PageUp) < 0)
                {
                    MouseSimulator.Scroll(MouseWheelDirection.Up, sensitivity);
                }
                else if (GetAsyncKeyState(Keys.PageDown) < 0)
                {
                    MouseSimulator.Scroll(MouseWheelDirection.Down, sensitivity);
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKey);

        public bool GetSimulationStatus()
        {
            return isSimulationActive;
        }
    }
}
