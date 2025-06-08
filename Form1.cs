namespace EnigMapp_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPosiciones_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCifrar_Click(object sender, EventArgs e)
        {
            var enigma = new EnigmaMachine();
            string posiciones = txtPosiciones.Text.ToUpper().Trim();

            if (posiciones.Length != 3)
            {
                MessageBox.Show("Debes ingresar exactamente 3 letras para los rotores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enigma.SetRotorPositions(posiciones);
            string mensaje = txtEntrada.Text;
            string resultado = enigma.Process(mensaje);
            txtSalida.Text = resultado;
        }

        private void BtnDescifrar_Click(object sender, EventArgs e)
        {
            var enigma = new EnigmaMachine();
            string posiciones = txtPosiciones.Text.ToUpper().Trim();

            if (posiciones.Length != 3)
            {
                MessageBox.Show("Debes ingresar exactamente 3 letras para los rotores.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            enigma.SetRotorPositions(posiciones);
            string mensaje = txtEntrada.Text;
            string resultado = enigma.Process(mensaje);
            txtSalida.Text = resultado;
        }

        private void btnCifrar_Click_1(object sender, EventArgs e)

        {
            var enigma = new EnigmaMachine();
            string posiciones = txtPosiciones.Text.ToUpper().Trim();

            if (posiciones.Length != 3)
            {
                MessageBox.Show("Debes ingresar 3 letras como posición de rotores (Ej: ABC)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enigma.SetRotorPositions(posiciones);

            string mensaje = txtEntrada.Text;
            string resultado = enigma.Process(mensaje);

            txtSalida.Text = resultado;
        }

        private void btnDescifrar_Click_1(object sender, EventArgs e)

        {
            var enigma = new EnigmaMachine();
            string posiciones = txtPosiciones.Text.ToUpper().Trim();

            if (posiciones.Length != 3)
            {
                MessageBox.Show("Debes ingresar 3 letras como posición de rotores (Ej: ABC)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            enigma.SetRotorPositions(posiciones);

            string mensaje = txtEntrada.Text;
            string resultado = enigma.Process(mensaje);

            txtSalida.Text = resultado;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void KevinG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://github.com/KevinGzalez",
                UseShellExecute = true
            });
        }
        // private void btnDescifrar_Click(object sender, EventArgs e)
        // {
        //var enigma = new EnigmaMachine();
        //string posiciones = txtPosiciones.Text.ToUpper().Trim();

        //  if (posiciones.Length != 3)
        //{
        //MessageBox.Show("Debes ingresar 3 letras como posición de rotores (Ej: ABC)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //      return;
        //}

        //enigma.SetRotorPositions(posiciones);

        //string mensaje = txtEntrada.Text;
        //string resultado = enigma.Process(mensaje);

        //txtSalida.Text = resultado;
        //}

    }
}




