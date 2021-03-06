using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_stateprovince", DwStyle.Grid)]
    [Table("StateProvince", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.StateProvince\" ) COLUMN(NAME=\"Person.StateProvince.StateProvinceID\") COLUMN(NAME=\"Person.StateProvince.Name\")) ")]
    #endregion
    [DwSort("stateprovinceid A ")]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Stateprovince
    {
        [PropertySave(SaveStrategy.Ignore)]
        public int Stateprovinceid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Name { get; set; }

    }

}
