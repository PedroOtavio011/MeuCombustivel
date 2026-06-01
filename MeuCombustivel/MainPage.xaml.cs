namespace MeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try

            {
                double etanol = double.Parse(txt_etanol.Text);
                double gasolina = double.Parse(txt_gasolina.Text);

                if (gasolina * 0.7 < etanol)
                {
                    DisplayAlertAsync("Resultado", "A gasolina é mais vantajosa.", "OK");
                }
                else
                {
                    DisplayAlertAsync("Resultado", "O etanol é mais vantajoso.", "OK");
                }
            }
            catch (Exception ex)
            {
                DisplayAlertAsync("Error", ex.Message, "OK");
            }
        }
    }
}