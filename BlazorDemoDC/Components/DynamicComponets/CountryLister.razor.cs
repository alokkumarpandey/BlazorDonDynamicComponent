using BlazorLab4.Models;
using LabEntity.Shared;

namespace BlazorDemoDC.Components.DynamicComponets
{
    public partial class CountryLister
    {
        public List<Country>? Countrlist { get; set; }

        protected override void OnInitialized()
        {
            Countrlist = DummyDataService.GetCountryList!;
        }
    }
}
