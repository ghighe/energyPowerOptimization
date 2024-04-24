using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace energyPowerOptimization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeFirstControl();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //metoda initializare, aplicatia porneste default cu panoul UC_adauga_consumatori
        //se va schimba in initializeFirstControl() cu alt UC
        private void initializeFirstControl()
        {
            userControls.UC_panou_control pc = new userControls.UC_panou_control();
            addUserControl(pc);

        }
        //iesire din aplicatie
        private void iesire_app_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adauga_consumatori_btn_Click(object sender, EventArgs e)
        {
            userControls.UC_adauga_consumatori ac = new userControls.UC_adauga_consumatori();
            addUserControl(ac);
           // initializeFirstControl();
        }
        //initialize panou optimizare_consum
        private void optimizare_consum_btn_Click(object sender, EventArgs e)
        {
            userControls.UC_optimizareConsum oc = new userControls.UC_optimizareConsum();
            addUserControl(oc);
            //initializeFirstControl();
        }
        //initialize panou UC_panou_control
        private void panou_control_btn_Click(object sender, EventArgs e)
        {
            /*userControls.UC_panou_control pc = new userControls.UC_panou_control();
            addUserControl(pc);*/
            initializeFirstControl();
        }
    }
}
