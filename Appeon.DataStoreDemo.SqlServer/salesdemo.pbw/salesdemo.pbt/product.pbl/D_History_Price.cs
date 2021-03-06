using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_history_price", DwStyle.Grid)]
    [Table("ProductListPriceHistory", Schema = "Production")]
    #region DwSelectAttribute  
    [DwSelect("SELECT production.productlistpricehistory.productid, " 
                  + "production.productlistpricehistory.startdate, "
                  + "production.productlistpricehistory.enddate, "
                  + "production.productlistpricehistory.listprice, "
                  + "production.productlistpricehistory.modifieddate "
                  + "FROM production.productlistpricehistory "
                  + "WHERE    production.productlistpricehistory.productid = :al_id")]
    #endregion
    [DwParameter("al_id", typeof(decimal?))]
    [DwSort("modifieddate D ")]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_History_Price
    {
        [Key]
        [DwChild("Productid", "Name", typeof(D_Dddw_Product))]
        public int Productid { get; set; }

        [Key]
        public DateTime Startdate { get; set; }

        public DateTime? Enddate { get; set; }

        public decimal Listprice { get; set; }

        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

        [DwCompute("getrow()")]
        public object Compute_1 { get; set; }

    }

}
