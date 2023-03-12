using MauiApp1.Database;
using MauiApp1.Model;

namespace MauiApp1;

public partial class NewPage2 : ContentPage
{
    private MyDbContext _dbContext;
    private Person _person ;
    public NewPage2(MyDbContext dbContext, Person person)
	{
		InitializeComponent();
        _dbContext = dbContext;
        _person = person;
        BindingContext = _person;

    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        _person.FirstName = s1.Text;
        _person.LastName = s2.Text;
        _person.Age = int.Parse(s3.Text);
        _dbContext.Update(_person);
        var editPage = new MainPage();
        await Navigation.PushAsync(editPage);
    }
}