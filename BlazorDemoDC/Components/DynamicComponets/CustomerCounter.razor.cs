using BlazorLab4.Models;

namespace BlazorDemoDC.Components.DynamicComponets
{
    public partial class CustomerCounter
    {
        public int CoustomerCounter { get; set; }

        protected override void OnInitialized()
        {
            CoustomerCounter = DummyDataService.Customers!.Count;
        }
    }
}
