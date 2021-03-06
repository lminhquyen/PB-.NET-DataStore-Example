using DWNet.Data;
using SnapObjects.Data;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_address_filter", DwStyle.Default)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Address_Filter
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string City { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        [DwChild("Stateprovinceid", "Name", typeof(D_Dddw_Stateprovince))]
        public decimal? Stateprovinceid { get; set; }

    }

}
