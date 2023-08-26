using BAAS.ViewModel;
using System.Diagnostics;

namespace BAAS.View;

public partial class MySubmarines : ContentPage
{

    private readonly SubmarineViewModel submarineViewModel;

    public MySubmarines(SubmarineViewModel submarineViewModel)
    {
        InitializeComponent();
        this.submarineViewModel = submarineViewModel;
        BindingContext = submarineViewModel;    // See Binding TitleOfCurrentPage in xaml file 
        GetSubmarines();
    }

    async private void GetSubmarines()
    {
        await submarineViewModel.GetSubmarineList();
    }

    private void TestDebug(object sender, EventArgs e)
    {
        Debug.WriteLine("FUNKAR!!!");
    }

    private void TestThis(object sender, TappedEventArgs e)
    {
        Debug.WriteLine("TAAAAAAAAAAAAAAAAAAPAAAAAAAAAAAAAAAAAAAAAA!!!");
    }
}