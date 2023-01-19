namespace MAUIAllApp;

public partial class DeviceInfoPage : ContentPage
{
    public DeviceInfoPage()
    {
        InitializeComponent();

        label1.Text = "Model: " + DeviceInfo.Current.Model;
        label2.Text = "Manufacturer: " + DeviceInfo.Current.Manufacturer;
        label3.Text = "Name: " + DeviceInfo.Name;
        label4.Text = "OS Version: " + DeviceInfo.VersionString;
        label6.Text = "Idiom: " + DeviceInfo.Current.Idiom;
        label7.Text = "Platform: " + DeviceInfo.Current.Platform;
        label8.Text = "Version: " + DeviceInfo.Current.Version;
    }
}