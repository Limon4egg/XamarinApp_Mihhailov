using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Label label_lbl = new Label
            {
                Text = "Добро пожаловать!",
                FontSize = 30,
                TextColor = Color.White,
                Padding = new Thickness(25, 25, 25, 25),
                FontFamily = "open Sans",
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            Button rgbbtn = new Button
            {
                Text = "Выбор цвета RGB",
                TextColor = Color.White,
                Padding = 15,
                BackgroundColor = Color.Violet
            };
            rgbbtn.Clicked += RGBButton;

            Button tictactoebtn = new Button
            {
                Text = "Крестики - нолики",
                TextColor = Color.White,
                Padding = 15,
                BackgroundColor = Color.Violet
            };
            tictactoebtn.Clicked += TicTacToeButton;
            StackLayout st = new StackLayout
            {
                Children = { label_lbl, rgbbtn, tictactoebtn }
            };
            Content = st;
        }
        private async void TicTacToeButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TicTacToePage());
        }
        private async void RGBButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGBPage());
        }
    }
}

