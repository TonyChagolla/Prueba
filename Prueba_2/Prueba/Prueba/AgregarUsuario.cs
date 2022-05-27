using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(checkDatos())
            {
                userController usuario = new userController();
                if (usuario.AgregarUsuario(tbxLogin.Text.Trim(), tbxNombre.Text.Trim(), tbxPaterno.Text.Trim(), tbxMaterno.Text.Trim(), float.Parse(tbxSueldo.Text)))
                {
                    MessageBox.Show("Se guardó correctamente", "Guardar");
                    this.Close();
                    return;
                }
                MessageBox.Show("Se produjo un error al guardar", "Error");
            }
        }

        private bool checkDatos()
        {
            if (tbxLogin.Text.Trim().Length < 3)
            {
                MessageBox.Show("El campo login debe ser mayor a 3", "Error");
                return false;
            }
            if (tbxNombre.Text.Trim().Length < 3)
            {
                MessageBox.Show("El campo nombre debe ser mayor a 3", "Error");
                return false;
            }
            if (tbxPaterno.Text.Trim().Length < 3)
            {
                MessageBox.Show("El campo apellido paterno debe ser mayor a 3", "Error");
                return false;
            }
            if (tbxMaterno.Text.Trim().Length < 3)
            {
                MessageBox.Show("El campo apellido materno debe ser mayor a 3", "Error");
                return false;
            }
            float inputValue;

            if (!float.TryParse(tbxSueldo.Text, out inputValue))
            {
                MessageBox.Show("El campo sueldo deber ser un numero", "Error");
                return false;
            }
            else 
            {
                if(inputValue < 0)
                {
                    MessageBox.Show("El campo sueldo deber ser un numero mayor o igual a 0", "Error");
                    return false;
                }
            }
            return true;
        }
    }
}
