using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prueba
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userController usuario = new userController();
            DataTable dt =  usuario.ObtenerTopTen();
            dgvMain.DataSource = dt;
            sfd.Title = "Guardar CSV";
            sfd.DefaultExt = "csv";
            sfd.Filter = "csv files (*.csv)|*.csv";
        }

        private void btnCrearCSV_Click(object sender, EventArgs e)
        {
            userController usuarios = new userController();
            DataTable dt = usuarios.ObtenerParaCSV();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string file = sfd.FileName; 
                CrearCSV(dt, file);
            }
        }

        public static void CrearCSV(DataTable dt, string pathFile)
        {
            StreamWriter file = new StreamWriter(pathFile, false);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                file.Write(dt.Columns[i]);
                if (i < dt.Columns.Count - 1)
                    file.Write(",");
            }

            file.Write(file.NewLine);
            foreach (DataRow dr in dt.Rows)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    string dato = dr[i].ToString().Replace(",", "");
                    file.Write(dato);
                    if (i < dt.Columns.Count - 1)
                        file.Write(",");
                }
                file.Write(file.NewLine);
            }
            file.Close();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario nuevo = new AgregarUsuario();
            nuevo.ShowDialog();
        }

        private void btnModificarSueldo_Click(object sender, EventArgs e)
        {
            ModificaSueldo modificar = new ModificaSueldo();
            modificar.ShowDialog();
        }
    }
}
