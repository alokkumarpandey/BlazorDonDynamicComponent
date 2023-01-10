using BlazorDemoDC.Components.DynamicComponets;

namespace BlazorDemoDC.Pages
{
    public partial class DynamicComponetList
    {
        public List<Type> DList { get; set; } =
            new List<Type>() { typeof(CustomerCounter), typeof(CountryLister) };
    }
}
