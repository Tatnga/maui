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
        var Inventory = _dbContext.MyData.ToList();
        BindingContext = Inventory;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        person.FirstName = s1.Text;
        person.LastName = s2.Text;
        person.Age = int.Parse(s3.Text);
        _dbContext.Insert(person);
   


        var Inventory = _dbContext.MyData.ToList();
        BindingContext = Inventory;
  
    }





    private async void Button_Clicked_1(object sender, EventArgs e)
    {


    }
}


