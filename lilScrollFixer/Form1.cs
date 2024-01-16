using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace lilScrollFixer
{
    public partial class Form1 : Form
    {
        private MouseSimulationManager simulationManager;

        public Form1()
        {
            InitializeComponent();
            simulationManager = new MouseSimulationManager();
        }

        private void Mode_Click(object sender, EventArgs e)
        {
            if (simulationManager.GetSimulationStatus())
            {
                simulationManager.StopSimulation();
                Mode.Text = "Activate";
            }
            else
            {
                simulationManager.StartSimulation((int)SensitivityControl.Value);
                Mode.Text = "Deactivate";
            }
        }
    }
}
