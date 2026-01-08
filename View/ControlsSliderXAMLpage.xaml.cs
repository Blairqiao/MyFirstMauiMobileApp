using MyFirstMauiMobileApp.ViewModel;

namespace MyFirstMauiMobileApp.View;

public partial class ControlsSliderXAMLpage : ContentPage
{
	public ControlsSliderXAMLpage()
	{
		InitializeComponent();
		BindingContext = new ControlsSliderXAMLViewModel();

		UpdateVisuals(MySlider.Value);

	}

    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e) => UpdateVisuals(e.NewValue);

    private void UpdateVisuals(double Value)
	{
		MyBox.Opacity = Value;
		ValueLabel.Text = $"Value of the slider is {Value:F2}";
		InfoLabel.Opacity = Value;
	}


}