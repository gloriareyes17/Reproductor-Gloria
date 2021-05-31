using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproductorMusicaGloria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            personalisarDiseno();
        }

        private void personalisarDiseno()
        {
            PanelMediosSubMenu.Visible = false;
            panelListaReproduccion.Visible = false;
            panelEcualizador.Visible = false;
        }

        private void ocultarSubMenu()
        {

            if (PanelMediosSubMenu.Visible == true)
            {
                PanelMediosSubMenu.Visible = false;
            }

            if (panelListaReproduccion.Visible == true)
            {
                panelListaReproduccion.Visible = false;
            }

            if (panelEcualizador.Visible == true)
            {
                panelEcualizador.Visible = false;
            }
        }

        private void mostrarsubmenu(Panel algunSubMenu){

            if (algunSubMenu.Visible == false)
            {

                ocultarSubMenu();
                algunSubMenu.Visible = true;
            }
            else {
                algunSubMenu.Visible = false;
            }
        }
        #region SubMenuMedios
        private void btnMedios_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(PanelMediosSubMenu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form2());
            ocultarSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #endregion SubMenuMedios

        #region SubMenuReproduccion
        private void btnListaReproduccion_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelListaReproduccion);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirChildForm(new Form3());
            ocultarSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #endregion SubMenuReproduccion

        #region SubMenuEcualizador
        private void btnEcualizador_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelEcualizador);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ocultarSubMenu();
        }
        #endregion SubMenuEcualizador


        private Form formularioActivo = null;
        private void abrirChildForm(Form childForm)
        {
            if (formularioActivo != null)
            {

                formularioActivo.Close();
            }
            formularioActivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

            
        
        }
    }
   
} 