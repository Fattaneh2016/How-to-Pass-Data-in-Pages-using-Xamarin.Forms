using System;

using Xamarin.Forms;

namespace PassDataXamarinForms
{
	public class SecondPage : ContentPage
	{
		public SecondPage (string data)
		{
			string Name = data;
			Label lbl_name = new Label {
				Text ="hello "+ Name
			};
			Content = new StackLayout { 
				Children = {
					lbl_name
				}
			};
			Title="Second Page";
		}
	}
}


