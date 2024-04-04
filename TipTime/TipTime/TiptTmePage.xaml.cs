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
        tipsPerSlider.Value = tipsPerSlider.Value - 1;
    }


    private void arredUp_Clicked(object sender, EventArgs e)
    {
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