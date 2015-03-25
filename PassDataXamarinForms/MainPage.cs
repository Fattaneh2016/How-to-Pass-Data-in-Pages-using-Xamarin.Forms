using System;

using Xamarin.Forms;

namespace PassDataXamarinForms
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{

			Entry txt_name = new Entry {
				WidthRequest=250,
				HorizontalOptions = LayoutOptions.Start,
				Placeholder="Enter Name"
			};
			var txtlayout = new StackLayout {
				Padding= new Thickness(35,20,0,0),
				Children={
					txt_name,
				},
					
			};
			txtlayout.WidthRequest = 10;
			Button btn_send = new Button{
				Text="Send"
			};

			btn_send.Clicked += (sender, e) => {
				Navigation.PushAsync(new SecondPage(txt_name.Text));
			};


			Content = new StackLayout { 
				Children = {
					txtlayout,btn_send
				}
			};
			Title="First Page";
		}
	}
}


