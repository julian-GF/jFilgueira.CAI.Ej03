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

            
        }
    }
}