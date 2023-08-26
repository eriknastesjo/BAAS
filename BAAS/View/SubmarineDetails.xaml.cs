using BAAS.ViewModel;

namespace BAAS.View;

public partial class SubmarineDetails : ContentPage
{
	public SubmarineDetails(SubmarineDetailsViewModel submarineDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = submarineDetailsViewModel;	
	}
}