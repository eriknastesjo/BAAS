using BAAS.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAAS.ViewModel
{
    [QueryProperty(nameof(Submarine), "Submarine")] // This attribute is used to indicate that
                                                    // the SubmarineDetailsViewModel class can receive
                                                    // query parameters from a URL or a navigation request.
                                                    // When you navigate to the SubmarineDetailsViewModel,
                                                    // typically from another view or page in your application,
                                                    // you can include a query parameter in the navigation request
                                                    // with the name "Submarine" and a value
    public partial class SubmarineDetailsViewModel: BaseViewModel
    {
        // We're binding the QueryProperty to this instance of Submarine. 
        [ObservableProperty]
        Submarine submarine;

        public SubmarineDetailsViewModel()
        {
            TitleOfCurrentPage = "Details";
        }
    }
}
