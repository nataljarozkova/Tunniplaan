using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tunniplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class tunniplaan : ContentPage
    {
        Label nimi, esm, teis, kolm, nelj, reed, vene, vene2, vorgud1, mob1, transp1, ing1, eesti, windows1, windows2, transp2, keemia1, vorgud2, ing2, keemia2, mob2;

        public tunniplaan()
        {
            Grid grid = new Grid();
            for (int i = 0; i < 10; i++) ;
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            for (int i = 0; i < 5; i++) ;
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
            {
                BackgroundColor = Color.White;
            }

            //-----------------------
            esm = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Esmaspäev " };
            grid.Children.Add(esm, 0, 1);
            Grid.SetColumnSpan(esm, 2);

            nimi = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSeaGreen, Text = "Elvira Burtassova, LOGITpv19 ", FontSize = 20 };
            grid.Children.Add(nimi, 0, 0);
            Grid.SetColumnSpan(nimi, 11);

            //Понедельник - Русский и литература:
            vene = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGreen, Text = "Keel ja kirjandus ", FontSize = 15 };
            grid.Children.Add(vene, 2, 1);
            Grid.SetColumnSpan(vene, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e) =>
            {
                vene = (Label)s;
                Info();
            };

            //Понедельник - Сети:
            vorgud1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.PeachPuff, Text = "Võrgud ja sead. ", FontSize = 15 };
            grid.Children.Add(vorgud1, 4, 1);
            Grid.SetColumnSpan(vorgud1, 2);
            var tap1 = new TapGestureRecognizer();
            tap1.Tapped += (s, e) =>
            {
                vorgud1 = (Label)s;
                Info1();
            };

            // Понедельник - Приложения:
            mob1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Mob.rak. ", FontSize = 15 };
            grid.Children.Add(mob1, 7, 1);
            Grid.SetColumnSpan(mob1, 3);
            var tap2 = new TapGestureRecognizer();
            tap2.Tapped += (s, e) =>
            {
                mob1 = (Label)s;
                Info2();
            };

            //----------------------------
            teis = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Orange, Text = "Teisipäev " };
            grid.Children.Add(teis, 0, 2);
            Grid.SetColumnSpan(teis, 2);

            // Вторник - логистика:
            transp1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightYellow, Text = "Transp.log.juht. ", FontSize = 15 };
            grid.Children.Add(transp1, 2, 2);
            Grid.SetColumnSpan(transp1, 3);
            var tap3 = new TapGestureRecognizer();
            tap3.Tapped += (s, e) =>
            {
                transp1 = (Label)s;
                Info3();
            };

            // Вторник - англиский:
            ing1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Ing (windows haid) ", FontSize = 15 };
            grid.Children.Add(ing1, 6, 2);
            Grid.SetColumnSpan(ing1, 2);
            var tap4 = new TapGestureRecognizer();
            tap4.Tapped += (s, e) =>
            {
                ing1 = (Label)s;
                Info4();
            };

            // Вторник - эстонский:
            eesti = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Pink, Text = "Eesti keel teise keelena ", FontSize = 15 };
            grid.Children.Add(eesti, 8, 2);
            Grid.SetColumnSpan(eesti, 2);
            var tap5 = new TapGestureRecognizer();
            tap5.Tapped += (s, e) =>
            {
                eesti = (Label)s;
                Info5();
            };

            //--------------------------------
            kolm = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Yellow, Text = "Kolmapäev " };
            grid.Children.Add(kolm, 0, 3);
            Grid.SetColumnSpan(kolm, 2);

            // Среда - Windows:
            windows1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "W.paig.sead. ", FontSize = 15 };
            grid.Children.Add(windows1, 2, 3);
            Grid.SetColumnSpan(windows1, 3);
            var tap6 = new TapGestureRecognizer();
            tap6.Tapped += (s, e) =>
            {
                windows1 = (Label)s;
                Info6();
            };

            // Среда - логистика:
            transp2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightYellow, Text = "Transp.log.juht. ", FontSize = 15 };
            grid.Children.Add(transp2, 5, 3);
            Grid.SetColumnSpan(transp2, 5);
            var tap7 = new TapGestureRecognizer();
            tap7.Tapped += (s, e) =>
            {
                transp2
                = (Label)s;
                Info7();
            };

            // Среда - химия:
            keemia1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.HotPink, Text = "Keemia, bioloogia eesti keeles ", FontSize = 15 };
            grid.Children.Add(keemia1, 10, 3);
            Grid.SetColumnSpan(keemia1, 1);
            var tap8 = new TapGestureRecognizer();
            tap8.Tapped += (s, e) =>
            {
                keemia1 = (Label)s;
                Info8();
            };

            //--------------------------------
            nelj = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Green, Text = "Neljapäev " };
            grid.Children.Add(nelj, 0, 4);
            Grid.SetColumnSpan(nelj, 2);

            // Четверг - Windows:
            windows2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Purple, Text = "W.paig.sead. ", FontSize = 15 };
            grid.Children.Add(windows2, 2, 4);
            Grid.SetColumnSpan(windows2, 3);
            var tap9 = new TapGestureRecognizer();
            tap9.Tapped += (s, e) =>
            {
                windows2 = (Label)s;
                Info9();
            };

            // Четверг - Сети:
            vorgud2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.PeachPuff, Text = "Võrgud ja seadm. ", FontSize = 15 };
            grid.Children.Add(vorgud2, 6, 4);
            Grid.SetColumnSpan(vorgud2, 2);
            var tap10 = new TapGestureRecognizer();
            tap10.Tapped += (s, e) =>
            {
                vorgud2 = (Label)s;
                Info10();
            };

            // Четверг - англиский:
            ing2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "Ing (windows haid) ", FontSize = 15 };
            grid.Children.Add(ing2, 8, 4);
            Grid.SetColumnSpan(ing2, 2);
            var tap11 = new TapGestureRecognizer();
            tap11.Tapped += (s, e) =>
            {
                ing2 = (Label)s;
                Info11();
            };

            //--------------------------------
            reed = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.BlueViolet, Text = "Reede " };
            grid.Children.Add(reed, 0, 5);
            Grid.SetColumnSpan(reed, 2);

            // Пятница - химия:
            keemia2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.HotPink, Text = "Keemia, bioloogia eesti keeles ", FontSize = 15 };
            grid.Children.Add(keemia2, 2, 5);
            Grid.SetColumnSpan(keemia2, 1);
            var tap12 = new TapGestureRecognizer();
            tap12.Tapped += (s, e) =>
            {
                keemia2 = (Label)s;
                Info12();
            };

            // Пятница - Приложения:
            mob2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Mob.rak. ", FontSize = 15 };
            grid.Children.Add(mob2, 4, 5);
            Grid.SetColumnSpan(mob2, 3);
            var tap13 = new TapGestureRecognizer();
            tap13.Tapped += (s, e) =>
            {
                mob2 = (Label)s;
                Info13();
            };

            vene.GestureRecognizers.Add(tap);
            vorgud1.GestureRecognizers.Add(tap1);
            mob1.GestureRecognizers.Add(tap2);
            transp1.GestureRecognizers.Add(tap3);
            ing1.GestureRecognizers.Add(tap4);
            eesti.GestureRecognizers.Add(tap5);
            windows1.GestureRecognizers.Add(tap6);
            transp2.GestureRecognizers.Add(tap7);
            keemia1.GestureRecognizers.Add(tap8);
            windows2.GestureRecognizers.Add(tap9);
            vorgud2.GestureRecognizers.Add(tap10);
            ing2.GestureRecognizers.Add(tap11);
            keemia2.GestureRecognizers.Add(tap12);
            mob2.GestureRecognizers.Add(tap13);

            Content = grid;
        }
        public async void Info()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B221, Людмила Михайлова", "Скрыть");
        }
        public async void Info1()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: A123, Михаил Агапов", "Скрыть");
        }
        public async void Info2()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: Е07, Марина Олейник", "Скрыть");
        }
        public async void Info3()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: В002, Яянус Крулл", "Скрыть");
        }
        public async void Info4()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B242, Юлия Воронетская", "Скрыть");
        }
        public async void Info5()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236,Alina);
        }
        public async void Info6()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236);
        }
        public async void Info7()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236);
        }
        public async void Info8()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236);
        }
        public async void Info9()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236);
        }
        public async void Info10()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236,);
        }
        public async void Info11()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236,);
        }
        public async void Info12()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236,);
        }
        public async void Info13()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236,);
        }