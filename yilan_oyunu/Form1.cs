namespace yilan_oyunu
{
    public partial class Form1 : Form
    {
        private int _yilanParcasiSayisi;
        private int _yianBoyutu;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Sifirla()
        {
            _yilanParcasiSayisi = 0;
        }

        private void YilanParcasiOlustur(int locationX, int locationY)
        {
            _yilanParcasiSayisi++;
            Label lbl = new Label()
            {
                Name="yilanParca"+_yilanParcasiSayisi,
                BackColor=Color.Red,
                Width=_yianBoyutu,
                Height=_yianBoyutu,

               
            };

            this.P
        }


    }
}