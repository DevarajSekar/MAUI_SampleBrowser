using CommunityToolkit.Maui.Views;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MAUIAllApp;

public partial class MainPage : ContentPage
{
    public ViewModelCollection ViewModelCollection { get; set; }
    public MainPage()
    {
        InitializeComponent();
        ViewModelCollection = new ViewModelCollection();
        ViewModelCollection.VMCollection = new List<ViewModel>()
        {
            new ViewModel(){ Name="Device Info", ClassName=new DeviceInfoPage() },
            new ViewModel(){ Name="Scribble Pad", ClassName=new DrawingViewPage() },
            new ViewModel(){ Name="MenuBar Animation", ClassName=new MenuBarPage() },
            new ViewModel(){ Name="Maps", ClassName=new MapsPage() }
        };
        this.BindingContext = ViewModelCollection;
    }
}

public class ViewModelCollection: INotifyPropertyChanged
{
    private List<ViewModel> viewModelColl;
    public ViewModelCollection()
    {
        viewModelColl=new List<ViewModel>();
    }

    public List<ViewModel> VMCollection
    {
        get
        {
            return viewModelColl;
        }
        set
        {
            viewModelColl = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

public class ViewModel
{
    public event PropertyChangedEventHandler PropertyChanged;

    public ICommand ClickCommand { get; set; }
    private string name;
    private object className;
    public ViewModel()
    {
        ClickCommand = new Command(DoNavigation);
    }

    public object ClassName
    {
        get
        {
            return className;
        }
        set
        {
            className = value;
            OnPropertyChanged();
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
            OnPropertyChanged();
        }
    }

    void DoNavigation()
    {
        App.Current.MainPage.Navigation.PushAsync((Page)ClassName);
    }

    public void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}