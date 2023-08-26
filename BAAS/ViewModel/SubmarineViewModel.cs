using BAAS.Model;
using BAAS.Services;
using BAAS.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAAS.ViewModel
{
    public partial class SubmarineViewModel: BaseViewModel
    {
        private readonly SubmarineService submarineService;
        public ObservableCollection<Submarine> Submarines { get; private set; } = new(); // new() is same as new ObservableCollection<Submarine>();

        public SubmarineViewModel(SubmarineService submarineService)
        {
            TitleOfCurrentPage = "My Submarines"; // see BaseViewModel.cs
            this.submarineService = submarineService;
        }

        [ObservableProperty]
        bool isRefreshing;

        [RelayCommand] // Tidigare ICommand
        public async Task GetSubmarineList()
        {
            if (PageIsLoading) return;

            try
            {
                PageIsLoading = true;
                if(Submarines.Any()) Submarines.Clear();

                var submarines = submarineService.GetSubmarines();
                foreach (var submarine in submarines)
                {
                    Submarines.Add(submarine);
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine($"Unable to get submarines: {exception.Message}");
                await Shell.Current.DisplayAlert("Error", "Failed to retrive list of submarines.", "Ok");
            }
            finally 
            {
                PageIsLoading = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        async Task GoToSubmarineDetails(Submarine submarine)
        {
            if (submarine == null) return;
            // Go to page SubmarineDetails page, animation = true,
            // expect a dictionary with string submarine name as a key and the Submarine object as value
            await Shell.Current.GoToAsync(nameof(SubmarineDetails), true, new Dictionary<string, object>
            {
                {nameof(Submarine), submarine}
            });
        }
    }
}
