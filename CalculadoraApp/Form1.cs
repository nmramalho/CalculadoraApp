using System;
using System.Windows.Forms;
using CalculosMatematicos;

namespace CalculadoraApp
{
    public partial class Form1 : Form
    {
        private bool teclaOperador;
        private char tecla;
        private decimal resultado;
        private char ultimoOperador;

        public Form1()
        {
            //System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Size;
            

            InitializeComponent();
            String msg = "Exemplo de Calculadora. \n " +
             " Apenas estão programadas as  teclas: '1','2','=','C' e '+'.";
            MessageBox.Show(msg);

            this.userControlTeclado1.addOnButtonClickHandler(new EventHandler(OnUserControlButtonClickHandler));
            resultado = 0;
            ultimoOperador = ' ';
        }

        private void OnUserControlButtonClickHandler(object sender, EventArgs e)
        {
            //labelVisor.Text += userControlTeclado1.UltimaTeclaPremida;
            Calcular calc = new Calcular();

            tecla = userControlTeclado1.UltimaTeclaPremida;

            switch (tecla)
            {
                case 'c':
                    labelVisor.ResetText();
                    teclaOperador = false;
                    ultimoOperador = ' ';
                    resultado = 0;
                    break;

                case '+':
                    if (!String.IsNullOrEmpty(labelVisor.Text))
                    {
                        resultado = calc.Soma(resultado, decimal.Parse(labelVisor.Text));
                        teclaOperador = true;
                        ultimoOperador = tecla;
                        labelVisor.Text = resultado.ToString();

                    }

                    break;

                case '=':
                    switch (ultimoOperador)
                    {
                        case '+':
                            if (!String.IsNullOrEmpty(labelVisor.Text))
                            {
                                    resultado = calc.Soma(resultado, decimal.Parse(labelVisor.Text));
                                    teclaOperador = false;
                                    labelVisor.Text = resultado.ToString();
                            }
                            break;

                        default:
                            break;
                    }
                    break;


                case '1':
                    if (teclaOperador) labelVisor.ResetText();
                    labelVisor.Text += userControlTeclado1.UltimaTeclaPremida;
                    teclaOperador = false;
                    break;

                case '2':
                    if (teclaOperador) labelVisor.ResetText();
                    labelVisor.Text += userControlTeclado1.UltimaTeclaPremida;
                    teclaOperador = false;
                    break;



                default:
                    break;
            }


            
            

        }

        private void userControlTeclado1_Load(object sender, EventArgs e)
        {

        }

    }
}
