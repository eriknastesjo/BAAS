using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BAAS.ViewModel
{
    // Enables data binding between a data source (like your view model) and a
    // UI element (like a control in your application's user interface).
    // The goal is similar to states in React.
    //public class BaseViewModel : INotifyPropertyChanged 
    // (changed to interface ObservableObject from CommunityToolkit )



    // ObservableObject is an implementation of data binding (see explanation above). 
    public partial class BaseViewModel : ObservableObject
    {

        [ObservableProperty]
        string titleOfCurrentPage;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(PageIsNotLoading))]
        bool pageIsLoading;

        public bool PageIsNotLoading => !PageIsLoading;




        // Only need this with INotifyPropertyChanged, not with ObservableObject

        //string _titleOfCurrentPage;
        //bool _pageIsLoading;

        //public string TitleOfCurrentPage
        //{
        //    get => _titleOfCurrentPage; // is same as get { return _titleOfCurrentPage; } 
        //    set
        //    {
        //        if (_titleOfCurrentPage == value)
        //        {
        //            // so that is doesn't need to "fire off"
        //            // when no change actually happened
        //            return;
        //        }
        //        _titleOfCurrentPage = value;
        //    }

        //}

        //public bool PageIsLoading
        //{
        //    get => _pageIsLoading;
        //    set 
        //    { 
        //        if (_pageIsLoading == value) 
        //        {
        //            return;
        //        }
        //        _pageIsLoading = value;
        //    }

        //}

        //public event PropertyChangedEventHandler PropertyChanged;

        //public void OnPropertyChanged([CallerMemberName] string name = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        //}
    }
}
