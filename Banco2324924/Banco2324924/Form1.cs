using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Banco2324924
{
    public partial class Form1 : Form
    {
        Titular objTitular = new Titular();
        Cuenta objCuenta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearTitular();
        }
        private void crearTitular()
        {
            objTitular.setDocumento(txtDocumento.Text);
            objTitular.setNombres(txtNombre.Text);
            objTitular.setApellidos(txtApellidos.Text);
            objTitular.setCelular(txtCelular.Text);
            objTitular.setCorreo(txtCorreo.Text);
            objTitular.setDireccion(txtDireccion.Text);
            MessageBox.Show("El Titular ha sido creado");
            limpiar();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            consultarTitular();
        }
        private void consultarTitular()
        {
            txtDocumento.Text = objTitular.getDocumento();
            txtNombre.Text = objTitular.getNombres();
            txtApellidos.Text = objTitular.getApellidos();
            txtCelular.Text = objTitular.getCelular();
            txtCorreo.Text = objTitular.getCorreo();
            txtDireccion.Text = objTitular.getDireccion();
        }
        private void limpiar()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }
        private void limpiarCta()
        {
            txtNumero.Clear();
            txtSaldo.Clear();
            txtClave.Clear();
            cbxEstado.SelectedIndex = -1;
        }
        private void crearCuenta()
        {
            bool estado = true;
            if (cbxEstado.Text == "Activa")
            {
                estado = true;
            }
            else if (cbxEstado.Text == "Inactiva")
            {
                estado = false;
            }
            if (objTitular.getDocumento() == null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                objCuenta = new Cuenta(txtNumero.Text, double.Parse(txtSaldo.Text), txtClave.Text, dtpApertura.Value, dtpMovimiento.Value, estado, objTitular);
                MessageBox.Show("La cuenta ha sido creada");
                limpiarCta();
                
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            consultarTitular();
        }

        private void btnCrear2_Click(object sender, EventArgs e)
        {
            crearCuenta();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            recuperar();
        }
        private void recuperar()
        {
            txtNumero.Text = objCuenta.getNumero();
            txtSaldo.Text = objCuenta.getSaldo().ToString();
            txtClave.Text = objCuenta.getClave();
            dtpApertura.Value = objCuenta.getFechaApertura();
            dtpMovimiento.Value = objCuenta.getUltimoMovimiento();
            bool est = objCuenta.getEstado();
            if (est)
            {
                cbxEstado.SelectedItem = "Activa";
            }else
            {
                cbxEstado.SelectedItem = "Inactiva";
            }
            txtDocumento.Text = objTitular.getDocumento();
            txtNombre.Text = objTitular.getNombres();
            txtApellidos.Text = objTitular.getApellidos();
            txtCelular.Text = objTitular.getCelular();
            txtCorreo.Text = objTitular.getCorreo();
            txtDireccion.Text = objTitular.getDireccion();

        }
    }
}
