using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;


namespace U7Offer;
public partial class MainWindow : Window
{
    List<Customer> customers = new List<Customer>()
        {
            new Customer("Robby", "Wood", 13),
            new Customer("Otto", "Werner", 38),
            new Customer("Raphael", "Keller", 25),
            new Customer("Felipe", "Guerrero", 45),
            new Customer("Martha", "Cabrera", 53)
        };

    List<Article> articles = new List<Article>()
        {
            new Article("EarPods", "GPA", 65.99f, true, 12, 999, "/images/earpods.jpg"),
            new Article("Sneaker", "JDS", 125.5f, true, 12, 999, "/images/sneaker.jpg"),
            new Article("Rucksack", "Turina", 82f, false, 18, 31, "/images/rucksack.jpg"),
            new Article("Wecker", "Tirole", 34.99f, true, 0, 50, "/images/wecker.jpg"),
            new Article("Teeblume", "SuSo", 28.99f, true, 27, 42, "/images/teeblume.jpg"),
            new Article("Korkenzieher", "Duly", 34.99f, true, 27, 42, "/images/korkenzieher.jpg"),
            new Article("Gamerstuhl", "Nyntindo", 135.0f, false, 21, 999, "/images/gamerstuhl.png"),
            new Article("Nackenkissen", "ComfortLine", 82.95f, true, 21, 999,"/images/nackenkissen.jpg"),
        };
    public MainWindow()
    {
        InitializeComponent();
        dg_Customers.ItemsSource = customers;
        lv_Articles.ItemsSource = articles;
    }
    private void Window_Loaded(object sender, RoutedEventArgs e) { }

    private void dg_Customers_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        DataGrid dg = (DataGrid)sender;
        Customer currentCustomer = (Customer)dg.SelectedItem;
        tblock_Hello.Text = $"Hallo {currentCustomer.Firstname},\ndas könnte Dich interessieren:";

        var OfferArticles = from a in articles
                            where a.MinAge < currentCustomer.Age && a.MaxAge > currentCustomer.Age
                            select a;
        lv_Articles.ItemsSource = OfferArticles;
    }
}