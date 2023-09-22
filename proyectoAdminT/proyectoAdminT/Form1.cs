using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoAdminT
     //Karla Sofia  Gómez Tobar 9959-21-1896
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            UpdateProcessList();
 
        }
       //Karla Sofia  Gómez Tobar 9959-21-1896
        private void UpdateProcessList()
        {
            dgvAdministrador.Rows.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                int n = dgvAdministrador.Rows.Add();
                dgvAdministrador.Rows[n].Cells[0].Value = p.ProcessName;
                dgvAdministrador.Rows[n].Cells[1].Value = p.Id;
                dgvAdministrador.Rows[n].Cells[2].Value = p.WorkingSet64;
                dgvAdministrador.Rows[n].Cells[3].Value = p.VirtualMemorySize64;
                dgvAdministrador.Rows[n].Cells[4].Value = p.SessionId;
            }

            txtContador.Text  = "Procesos Actuales: " + dgvAdministrador.Rows.Count.ToString();
        }
        //Alyson vannesa Rodriguez Quezada 9959-21-829

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == txtProceso.Text)
                    {
                        p.Kill(); //elimina el proceso seleccionado
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("AUN NO SELECCIONAS EL PROCESO :( " + x, "TENEMOS UN ERROR XoX", MessageBoxButtons.OK);
            }
        }
        //Carlos Emanuel Hernández García 9959-21-363
        private void dvgAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();
        }
        //Carlos Emanuel Hernández García 9959-21-363
        private void txtContador_Click(object sender, EventArgs e)
        {

        }
        //Carlos Emanuel Hernández García 9959-21-363
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Alyson vannesa Rodriguez Quezada 9959-21-829
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            UpdateProcessList();
        }
        //Alyson vannesa Rodriguez Quezada 9959-21-829
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Carlos Emanuel Hernández García 9959-21-363
        private void txtProceso_Click(object sender, EventArgs e)
        {

        }
    }
}
