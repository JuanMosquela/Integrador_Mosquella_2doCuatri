using Entidades;

namespace Integrador
{
    public partial class FrmCalculadora : Form
    {
        private Operacion calculadora;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private ESistema sistema;


        public FrmCalculadora()
        {
            InitializeComponent();
        }

        public void SetResultado(Numeracion resultado)
        {
            if (resultado is null) return;          

            string res = resultado.ConvertirA(this.sistema);
            
            textBoxResultado.Text = resultado.Valor;
        }


        private void buttonOperar_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(textPrimerOperador.Text, out double primerValor) && double.TryParse(textSegundoOperador.Text, out double segundoValor))
            {
                this.primerOperando = new Numeracion(this.sistema, primerValor);
                this.segundoOperando = new Numeracion(this.sistema, segundoValor);

                char simbol;
                try
                {
                    simbol = comboBoxOperator.Text.Single();
                }
                catch
                {
                    simbol = '+';
                }

                this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);

                this.resultado = calculadora.Operar(simbol);
                Numeracion aux = new Numeracion(this.sistema, this.resultado.ConvertirA(this.sistema));
                SetResultado(aux);            
            }
            else
            {
                if (textPrimerOperador.Text.Length > 0)
                {
                    MessageBox.Show("Los valores ingresados deben ser numeros", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debes ingresar ambos valores para operar", "Aceptar", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                }
            }
        }

        private void FmrCalculadora_Load(object sender, EventArgs e)
        {
            rdbDecimalChecked.Select();

            string[] options = new string[] { "+", "-", "*", "/" };

            foreach (var item in options)
            {
                comboBoxOperator.Items.Add(item);
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textPrimerOperador.Clear();
            textSegundoOperador.Clear();
            textBoxResultado.Clear();
            this.resultado = null;
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = MessageBox.Show("Deseda cerrar la calculadora?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbDecimalChecked_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Decimal;

            if(this.resultado is not null)
            {
                Numeracion aux = new Numeracion(this.sistema, this.resultado.ConvertirA(this.sistema));
                SetResultado(aux);
            }

        }

        private void radioBinarioChecked_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;

            if (this.resultado is not null)
            {
               
                

                Numeracion aux = new Numeracion(this.sistema, this.resultado.ConvertirA(this.sistema));
                SetResultado(aux);
            }
        }
    }
}