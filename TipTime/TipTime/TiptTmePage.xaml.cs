namespace TipTime;

public partial class TiptTmePage : ContentPage
{
	public TiptTmePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }





    private void arredDown_Clicked(object sender, EventArgs e)
    {
        //arredondar o numero para o inteiro menor ao valor
        // pegar o valor da refeicao
        // pegar a procentagem que o user selecionou
        //calcuar o valor da gorjeta
        //arredondar
        //calcular o total
        //exibir

        double valorDaRefeição = Convert.ToDouble(insertVal.Text);
        double valorDoSlider = tipsPerSlider.Value;
        double valorDaGorjeta = valorDaRefeição * (valorDoSlider / 100);
        valorDaGorjeta = Math.Floor(valorDaGorjeta);// floor e celing arredondam//
        double totalRefeicao = valorDaGorjeta + valorDaRefeição;

        totalValue.Text = totalRefeicao.ToString();
        tipsValue.Text = valorDaGorjeta.ToString();
        tipsPerSlider.Value = tipsPerSlider.Value + 1;

    }


    private void arredUp_Clicked(object sender, EventArgs e)
    {
        double valorDaRefeição = Convert.ToDouble(insertVal.Text);
        double valorDoSlider = tipsPerSlider.Value;
        double valorDaGorjeta = valorDaRefeição * (valorDoSlider / 100);
        valorDaGorjeta = Math.Floor(valorDaGorjeta);// floor e celing arredondam//
        double totalRefeicao = valorDaGorjeta + valorDaRefeição;

        totalValue.Text = totalRefeicao.ToString();
        tipsValue.Text = valorDaGorjeta.ToString();
        tipsPerSlider.Value = tipsPerSlider.Value + 1;
    }

    private void Percentage15Button_Clicked(object sender, EventArgs e)
    {
        tipsPerSlider.Value = 15;
    }

    private void Percentage30Button_Clicked(object sender, EventArgs e)
    {
        tipsPerSlider.Value = 30;
    }

    private void tipsPerSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valorDoSLider = tipsPerSlider.Value;
        sliderPer.Text = valorDoSLider.ToString() + "%";
    
    
    }
}