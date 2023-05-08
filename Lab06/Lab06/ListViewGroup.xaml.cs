using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewGroup : ContentPage
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ListViewGroup()
        {
            InitializeComponent();
            Groups = new ObservableCollection<Group>
            {
            new Group("A")
            {
                new Item { Title = "Alanya", Subtitle = "Samir" },
                new Item { Title = "Apaza", Subtitle = "Mateo" },
                new Item { Title = "Aguilar", Subtitle = "Valentina" },
                new Item { Title = "Arévalo", Subtitle = "Juan" }
            },
            new Group("B")
            {
                new Item { Title = "Bravo", Subtitle = "Lucas" },
                new Item { Title = "Barrios", Subtitle = "Emma" },
                new Item { Title = "Beltrán", Subtitle = "Alejandro" },
                new Item { Title = "Bautista", Subtitle = "Sebastián" }
            },
            new Group("C")
            {
                new Item { Title = "Castro", Subtitle = "Liam" },
                new Item { Title = "Cortés", Subtitle = "Olivia" },
                new Item { Title = "Cervantes", Subtitle = "Gabriel" },
                new Item { Title = "Campos", Subtitle = "Isabella" }
            },
            };
            GroupedView.ItemsSource = Groups;
        }
    }
}