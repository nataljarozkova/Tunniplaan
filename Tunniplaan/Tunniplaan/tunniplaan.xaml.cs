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
        Label esm, teis, kolm, nelj, red, vene, vene2,  võrgud1, mob1, transp1, ing1, eesti, windows1, windows2, transp2, keemia1, võrgud2, ing2, keemia2, mob2;

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
                BackgroundColor = Color.Blue;
            }
//----------------------
            esm = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSalmon, Text = "Eesmaspäev" };
            grid.Children.Add(esm, 0, 1);
            Grid.SetColumnSpan(esm, 2);

            // Esmaspäev Vene keel ja kirjandus:
            vene = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Gold, Text = "Vene keel ja kirjandus", FontSize = 15 };
            grid.Children.Add(vene, 2, 1);
            Grid.SetColumnSpan(vene, 2);
            var tap = new TapGestureRecognizer();
            tap.Tapped += (s, e)


            // Esmaspäev Võrgud:
            võrgud1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Lime, Text = "Võrgud ja seadm.", FontSize = 15 };
            grid.Children.Add(võrgud1, 4, 1);
            Grid.SetColumnSpan(vene, 2);

            // Esmaspäev Mob.rak:
            mob1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LimeGreen, Text = "Mob.rak", FontSize = 15 };
            grid.Children.Add(mob1, 2, 1);
            Grid.SetColumnSpan(mob1, 2);

//----------------------
            teis = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSalmon, Text = "Teisipäev" };
            grid.Children.Add(teis, 0, 1);
            Grid.SetColumnSpan(teis, 3);

            // Teisipäev - Logistika:
            transp1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Trans.log.juht.", FontSize = 15 };
            grid.Children.Add(transp1, 2, 2);
            Grid.SetColumnSpan(transp1, 3);

            // Teisipäev - Inglise keel:
            ing1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Ing (windows haid)", FontSize = 15 };
            grid.Children.Add(ing1, 6, 2);
            Grid.SetColumnSpan(ing1, 2);

            // Teisipäev - Eesti keel:
            eesti = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGoldenrodYellow, Text = "Eesti keel teise keelena", FontSize = 15 };
            grid.Children.Add(eesti, 8, 2);
            Grid.SetColumnSpan(eesti, 2);

//----------------------
            kolm = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSalmon, Text = "Kolmapäev" };
            grid.Children.Add(kolm, 0, 1);
            Grid.SetColumnSpan(kolm, 4);

            // Kolmapäev - Windows:
            windows1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightGray, Text = "W.paig.swad.", FontSize = 15 };
            grid.Children.Add(windows1, 2, 3);
            Grid.SetColumnSpan(windows1, 3);

            // Kolmapäev - Logistika:
            transp2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightBlue, Text = "Trans.log.juht.", FontSize = 15 };
            grid.Children.Add(transp2, 5, 3);
            Grid.SetColumnSpan(transp2, 5);

            // Kolmapäev - Keemia:
            keemia1 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCyan, Text = "Keemia, bioloogia eesti keeles", FontSize = 15 };
            grid.Children.Add(keemia1, 10, 3);
            Grid.SetColumnSpan(keemia1, 1);

//----------------------
            nelj = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSalmon, Text = "Neljapäev" };
            grid.Children.Add(nelj, 0, 1);
            Grid.SetColumnSpan(nelj, 5);

            // Neljapäev - Windows:
            windows2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCyan, Text = "W.paig.swad.", FontSize = 15 };
            grid.Children.Add(windows2, 2, 4);
            Grid.SetColumnSpan(windows2, 3);

            // Neljapäev - Võrgud:
            võrgud2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.Lime, Text = "Võrgud ja seadm.", FontSize = 15 };
            grid.Children.Add(võrgud2, 6, 4);
            Grid.SetColumnSpan(võrgud2, 2);

            // Neljapäev -Inglise keel:
            ing2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCoral, Text = "Ing (windows haid)", FontSize = 15 };
            grid.Children.Add(ing2, 8, 4);
            Grid.SetColumnSpan(ing2, 2);

//----------------------
            red = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightSalmon, Text = "Reede" };
            grid.Children.Add(red, 0, 1);
            Grid.SetColumnSpan(red, 5);

            // Reede -  Keemia:
            keemia2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LightCyan, Text = "Keemia, bioloogia eesti keeles", FontSize = 15 };
            grid.Children.Add(keemia2, 2, 5);
            Grid.SetColumnSpan(keemia2, 1);

            // Reede -  Mod.rak:
            mob2 = new Label { HorizontalOptions = LayoutOptions.Center, BackgroundColor = Color.LimeGreen, Text = "Mob.rak", FontSize = 15 };
            grid.Children.Add(mob2, 4, 5);
            Grid.SetColumnSpan(mob2, 3);

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
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B236, Алина Ляневали-Тоотс", "Скрыть");
        }
        public async void Info6()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: А243, Лури Шкарбанова", "Скрыть");
        }
        public async void Info7()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B003, Яянус Крулл", "Скрыть");
        }
        public async void Info8()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B144, Светлана Песецкая", "Скрыть");
        }
        public async void Info9()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: А243, Лури Шкарбанова", "Скрыть");
        }
        public async void Info10()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: А123, Михаил Агапов", "Скрыть");
        }
        public async void Info11()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B242, Юлия Воронетская", "Скрыть");
        }
        public async void Info12()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: B144, Светлана Песецкая", "Скрыть");
        }
        public async void Info13()
        {
            await DisplayAlert("Дополнительная информация", "Кабинет и преподаватель: Е07, Марина Олейник", "Скрыть");
        }
    }
    }

