using MauiAuth.Models;
using MauiAuth.PageModels;

namespace MauiAuth.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}