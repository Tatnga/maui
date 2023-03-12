using SQLite;
using Microsoft.Maui.Controls;
using MauiApp1.Model;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Xml.Linq;
using MauiApp1.Database;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private MyDbContext _dbContext;
    Person person = new Person();
   
    public MainPage()
    {

        InitializeComponent();
        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "mydatabase.db7");
        _dbContext = new MyDbContext(dbPath);
        var Person = _dbContext.MyData.ToList();
        BindingContext = Person;
        listView.ItemsSource = Person;

    }
    private void Deletebtn(object sender, EventArgs e)
    {


        var button = (Button)sender;
        var item = (Person)button.BindingContext;
        _dbContext.Delete(item);
        listView.ItemsSource = _dbContext.MyData.ToList();
    }
    private async void Editbtn(object sender, EventArgs e)
    {

        var button = (Button)sender;
        var item = (Person)button.BindingContext;

        var editPage = new NewPage2(_dbContext, item);
        await Navigation.PushAsync(editPage);
    }

}


