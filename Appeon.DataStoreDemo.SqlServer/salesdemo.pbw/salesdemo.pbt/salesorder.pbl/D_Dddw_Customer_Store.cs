using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_customer_store", DwStyle.Grid)]
    [Table("Customer", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Sales.Customer\" )  TABLE(NAME=\"Sales.Store\" )  TABLE(NAME=\"Sales.SalesTerritory\" ) COLUMN(NAME=\"Sales.Customer.CustomerID\") COLUMN(NAME=\"Sales.Customer.StoreID\") COLUMN(NAME=\"Sales.Customer.TerritoryID\") COLUMN(NAME=\"Sales.Customer.AccountNumber\") COLUMN(NAME=\"Sales.Store.Name\") COLUMN(NAME=\"Sales.SalesTerritory.Name\") COLUMN(NAME=\"Sales.SalesTerritory.Group\")    JOIN (LEFT=\"Sales.Store.BusinessEntityID\"    OP =\"=\"RIGHT=\"Sales.Customer.StoreID\" )    JOIN (LEFT=\"Sales.SalesTerritory.TerritoryID\"    OP =\"=\"RIGHT=\"Sales.Customer.TerritoryID\" )WHERE(    EXP1 =\"~\"Sales~\".~\"Customer~\".~\"StoreID~\"\"   OP =\"is not\"    EXP2 =\"null\" ) ) ORDER(NAME=\"Sales.Customer.CustomerID\" ASC=yes ) ")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Customer_Store
    {
        [Identity]
        [PropertySave(SaveStrategy.Ignore)]
        public int Customer_Customerid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Customer_Storeid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Customer_Territoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Customer_Accountnumber { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Store_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Group { get; set; }

    }

}
