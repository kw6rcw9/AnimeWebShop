using AnimeWebShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AnimeWebShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppDbContext _db;
        public MainWindow()
        {
            _db = new AppDbContext();
          
            InitializeComponent();
            AddItems();
            ShowItemsList();

        }

        private void ShowItemsList() 
        {
            ObservableCollection<Item> items = new ObservableCollection<Item>();
            List<Item> list = _db.Items.ToList();
            foreach (Item item in list)
            {
                items.Add(item);
            }
            ItemsListBox.ItemsSource = items;
        }
        private void AddItems()
        {
            
           
            _db.Items.Add(new Item("Juliet", 10000, "Эта милая девушка найдет путь к сердцу любого, очаровывая своей добротой",
                "juliet.jpg" ));
            _db.Items.Add(new Item("Maki", 12000, "Прекрасные кулинарные способности, чистоплотность, и это не предел того, чем обладает алая красавица",
                "maki.png"));
            _db.Items.Add(new Item("Reina", 14000, "Прекрасна и загадочна как луна, нежная и чуткая как мамины объятия",
                "reina.jpg"));
            _db.Items.Add(new Item("Ice", 15000, "На вид холодная как лед, а от взгляда стынет кровь. Но это лишь маска, скрывающая по иситине нежную, изящную и теплую душу ",
                "ice.jpg"));
            _db.Items.Add(new Item("Mercury", 20000, "Эта девушка сочетает в себе всё. От безграничного таланта во всем, до самой утонченной женственной натуры, что никого не оставит равнодушным ",
                "mercury.png"));
            _db.SaveChanges();
        }

        private void AddToCartButton_Click(object sender, RoutedEventArgs e)
        {
            Item item = (Item)ItemsListBox.Items.CurrentItem;
            CartInfoLabel.Content = item.Name;
        }
    }
}
