using EvorodApp.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEvolutiaWorker.Infraestructure.Entities;

namespace PlayerUI
{
    public partial class Form1 : Form
    {
        private readonly Group _form2;
        private readonly Client _client;
        private readonly Cups _cups;
        private readonly Contract _contract;
        private readonly Sim _sim;
        private readonly Device _device;
        private readonly Urm _urm;
        private readonly Um _um;

        public Form1(Group form, Client client, Cups cups, Contract contract, Sim sim, Device device, Urm urm, Um um)
        {
            _form2 = form;
            _client = client;
            _cups = cups;
            _contract = contract;
            _sim = sim;
            _device = device;
            _urm = urm;
            _um = um;

            Application.EnableVisualStyles();
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            //panelMediaSubMenu.Visible = false;
            //panelPlaylistSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region MediaSubMenu
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(_form2);
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelPlaylistSubMenu);
        }

        #region PlayListManagemetSubMenu
        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnTools_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        #endregion

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //..
            //your codes
            //..
            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            openChildForm(_form2);
            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(_client);
            hideSubMenu();
        }

        private void btnCups_Click(object sender, EventArgs e)
        {
            openChildForm(_cups);
            hideSubMenu();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            openChildForm(_contract);
            hideSubMenu();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            openChildForm(_sim);
            hideSubMenu();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            openChildForm(_device);
            hideSubMenu();
        }

        private void btnUrm_Click(object sender, EventArgs e)
        {
            openChildForm(_urm);
            hideSubMenu();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            openChildForm(_um);
            hideSubMenu();
        }
    }
}
