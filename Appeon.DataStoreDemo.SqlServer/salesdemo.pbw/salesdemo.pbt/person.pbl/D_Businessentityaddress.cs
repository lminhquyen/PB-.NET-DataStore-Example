using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_businessentityaddress", DwStyle.Grid)]
    [Table("BusinessEntityAddress", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Person.BusinessEntityAddress.businessentityid, " 
                  + "Person.BusinessEntityAddress.addressid, "
                  + "Person.BusinessEntityAddress.addresstypeid, "
                  + "Person.BusinessEntityAddress.modifieddate "
                  + "FROM Person.BusinessEntityAddress "
                  + "WHERE Person.BusinessEntityAddress.BusinessEntityID = :ai_id")]
    #endregion
    [DwParameter("ai_id", typeof(decimal?))]
    [DwSort("lookupdisplay(addressid  ) A ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Businessentityaddress
    {
        [Key]
        [DefaultValue("0")]
        public int Businessentityid { get; set; }

        [Key]
        [DwChild("Addressid", "Addressline1", typeof(D_Dddw_Address))]
        public int Addressid { get; set; }

        [Key]
        [DwChild("Addresstypeid", "Name", typeof(D_Dddw_Addresstype))]
        public int Addresstypeid { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

    }

}
