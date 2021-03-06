using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_order_detail_list", DwStyle.Grid)]
    [Table("SalesOrderDetail", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("SELECT Sales.SalesOrderDetail.salesorderid, " 
                  + "Sales.SalesOrderDetail.salesorderdetailid, "
                  + "Sales.SalesOrderDetail.carriertrackingnumber, "
                  + "Sales.SalesOrderDetail.orderqty, "
                  + "Sales.SalesOrderDetail.productid, "
                  + "Sales.SalesOrderDetail.specialofferid, "
                  + "Sales.SalesOrderDetail.unitprice, "
                  + "Sales.SalesOrderDetail.unitpricediscount, "
                  + "Sales.SalesOrderDetail.linetotal, "
                  + "Sales.SalesOrderDetail.modifieddate "
                  + "FROM Sales.SalesOrderDetail "
                  + "WHERE Sales.SalesOrderDetail.SalesOrderID = :al_order_id "
                  + "ORDER BY Sales.SalesOrderDetail.salesorderdetailid ASC")]
    #endregion
    [DwParameter("al_order_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    public class D_Order_Detail_List
    {
        [Key]
        [DefaultValue("0")]
        public int Salesorderid { get; set; }

        [Identity]
        [Key]
        [DefaultValue("0")]
        public int Salesorderdetailid { get; set; }

        [ConcurrencyCheck]
        public string Carriertrackingnumber { get; set; }

        [ConcurrencyCheck]
        public int Orderqty { get; set; }

        [ConcurrencyCheck]
        [DwChild("Product_Productid", "Product_Name", typeof(D_Dddw_Order_Production))]
        public int Productid { get; set; }

        [ConcurrencyCheck]
        public int Specialofferid { get; set; }

        [ConcurrencyCheck]
        public decimal Unitprice { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("((0.0))")]
        public decimal Unitpricediscount { get; set; }

        [ConcurrencyCheck]
        [PropertySave(SaveStrategy.Ignore)]
        public decimal Linetotal { get; set; }

        [ConcurrencyCheck]
        [SqlDefaultValue("1990/1/1")]
        public DateTime Modifieddate { get; set; }

        [DwCompute("sum( linetotal )")]
        public object Compute_Sum { get; set; }

    }

}
