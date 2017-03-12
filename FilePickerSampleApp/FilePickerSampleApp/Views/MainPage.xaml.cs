using Plugin.FilePicker;
using Plugin.FilePicker.Abstractions;
using System;
using Xamarin.Forms;

namespace FilePickerSampleApp.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
			FileData file = await CrossFilePicker.Current.PickFile();
			lblFileName.Text = file.FileName;
		}
	}
}
