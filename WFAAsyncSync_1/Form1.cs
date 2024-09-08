namespace WFAAsyncSync_1
{
    public partial class Form1 : Form
    {

        //Bir metodun asenkron calısabilmesini istiyorsanız o metot geriye deger döndürse de döndürmese de Task tipi ile yaratılmalıdır... Task tipi yaratıldıktan sonra geriye deger döndürmeyecekse Task'e baska bir şey yazılmaz....Eger geriye deger döndürecekse o deger tipi Task'e generic olarak verilir...


        public Form1()
        {
            InitializeComponent();



        }


        Task<int> SelamlaAsync()
        {
            
            return Task.Run(
                //Selamla => metodumuzu bu sekilde parantezsiz de verebiliriz

                //Veya anonim bir metot verebiliriz
                () =>
                {
                    Thread.Sleep(15000);
                    //MessageBox.Show("Async olarak cagrıldıgım icin kimseyi engellemedim");
                    return 100;
                });
        }


        public void Selamla()
        {
            Thread.Sleep(5000);
            MessageBox.Show("Hello World");
        }


        public int KareAl(int sayi)
        {
            Thread.Sleep(10000);
            return sayi * sayi;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void BtnCalistir_Click(object sender, EventArgs e)
        {
           Task<int> a =   SelamlaAsync(); //Eger Asenkron bir metot await ile cagrılmazsa ve tek basına cagrılırsa program o metodu beklemeden ilerlemeye devam edecektir...Bu da metodun ilgili görevinin yapılmasını bypass ederek baska kodları calıstırabilir ve o kodlar da eger önceki metodun görevine baglıysa problem yasanır...Dolayısıyla asenkron metotların await keyword'u ile cagrılıp görevlerinin tamamlanması beklenmelidir...await keyword'unun cagrılması icin ise icerisinde kod yazdıgınız metodun async keyword'u ile işaretlenmesi gerekir...
            int b = a.Result;
            MessageBox.Show(b.ToString());






        }

        private void BtnSayi_Click(object sender, EventArgs e)
        {
            MessageBox.Show(2.ToString());
        }






    }
}
