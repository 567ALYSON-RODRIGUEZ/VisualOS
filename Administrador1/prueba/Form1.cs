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

namespace prueba
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            updateprocessList();
            //timer1.Enabled = true;

        }

        //llamda de los procesos a nuestra tabla Carlos.H
        private void updateprocessList()
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

            txtContador.Text = "Procesos Actuales: " + dgvAdministrador.Rows.Count.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //boton de actualizar alyson
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            updateprocessList();
        }

        //boton detener alyson
        private void btnDetener_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == txtProceso.Text)
                    {
                        p.Kill();
                    }


                }

            }

               catch (Exception x)
               {
                MessageBox.Show("No Selecciono Ningun Proceso" + x, "error al eliminar", MessageBoxButtons.OK); 
               }
            
        }
        //boton de salir Alyson1

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvAdministrador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProceso.Text = dgvAdministrador.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
