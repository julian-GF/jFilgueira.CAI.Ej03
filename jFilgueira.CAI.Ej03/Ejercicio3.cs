namespace jFilgueira.CAI.Ej03
{
    public partial class Ejercicio3 : Form
    {
        Ejercicio3Modelo modelo;
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio3Modelo();
            PaiseCmb.Items.AddRange(modelo.Paises);



        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            modelo.Pais = PaiseCmb.Text;
            modelo.Provincia =provinciaCMB.Text;
            modelo.Localidad = LocalidadCMB.Text;
            modelo.calle = CalleTxt.Text;
            modelo.Numero= NumeroTxt.Text;
            modelo.Dpto = DeptoTxt.Text;    
            modelo.Piso = PisoTxt.Text; 

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void provinciaCMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocalidadCMB.Items.Clear();
            LocalidadCMB.Text = "";

            if (provinciaCMB.Text == "Buenos aires")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesBuenosAires);
            }

            if (provinciaCMB.Text == "Tucumán")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesTucuman);
            }

            if (provinciaCMB.Text == "Milan")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesMilan);
            }

            if (provinciaCMB.Text == "Bolonia")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesBolonia);
            }

            if (provinciaCMB.Text == "Barcelona")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesBarcelona);
            }

            if (provinciaCMB.Text == "Madrid")
            {
                LocalidadCMB.Items.AddRange(modelo.LocalidadesMadrid);
            }
        }

        private void PaiseCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            provinciaCMB.Items.Clear();
            provinciaCMB.Text="";

            LocalidadCMB.Items.Clear();
            LocalidadCMB.Text = "";

            if (PaiseCmb.Text == "Argentina")
            {
                provinciaCMB.Items.AddRange(modelo.ProvinciasArgnetinas);
            }

            if (PaiseCmb.Text == "España")
            {
                provinciaCMB.Items.AddRange(modelo.ProvinciasEspañolas);
            }

            if (PaiseCmb.Text == "Italia")
            {
                provinciaCMB.Items.AddRange(modelo.ProvinciasItalianas);
            }
        }
    }
}