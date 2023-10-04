using AnimeWebShop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using System.Windows;

using CloudIpspSDK;
using CloudIpspSDK.Checkout;


namespace AnimeWebShop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AppDbContext _db;
        private int _totalAmount = 0;
        private int _totalPrice = 0;
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
            
           
            Item item = (Item)ItemsListBox.Items[ItemsListBox.SelectedIndex];
            _totalAmount++;
            _totalPrice += item.Price;
            CartInfoLabel.Content = "В вашей корзине есть товары";
            CartAmountLabel.Content = $"Количество: {_totalAmount}шт";
            CartPriceLabel.Content = $"Общая стоимость: {_totalPrice}$";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CartPriceLabel.ToString() == "")
            {
                MessageBox.Show("Вы не добавили товары в корзину");
                return;
            }

            Config.MerchantId = 1396424;
            Config.SecretKey = "test";

            var req = new CheckoutRequest
            {
                order_id = Guid.NewGuid().ToString("N"),
                amount = _totalPrice * 100,
                order_desc = "checkout json demo",
                currency = "USD"
            };
            var resp = new Url().Post(req);

            if (resp.Error == null)
            {
                string url = resp.checkout_url;
                System.Diagnostics.Process.Start(url);
            }

        }
    }
}
