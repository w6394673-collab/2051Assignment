using _2051Assignment.Models;
using _2051Assignment.PageModels;

namespace _2051Assignment.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}