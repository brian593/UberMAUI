using CloneUber.ViewModels;

namespace CloneUber.Views.Register;

public partial class VerificationCodePage : ContentPage
{
	public VerificationCodePage(VerificationCodePageVM viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
