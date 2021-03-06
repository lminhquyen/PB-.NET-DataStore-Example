using DWNet.Data;
using SnapObjects.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_customer_individual", DwStyle.Grid)]
    [Table("Customer", Schema = "Sales")]
    #region DwSelectAttribute  
    [DwSelect("SELECT TOP 100 " 
                  + "Sales.Customer.CustomerID, "
                  + "Sales.Customer.PersonID, "
                  + "Sales.Customer.TerritoryID, "
                  + "Sales.Customer.AccountNumber, "
                  + "Sales.SalesTerritory.Name, "
                  + "Person.Person.Title, "
                  + "Person.Person.FirstName, "
                  + "Person.Person.MiddleName, "
                  + "Person.Person.LastName, "
                  + "Person.Person.Suffix "
                  + "FROM Sales.Customer, "
                  + "Sales.SalesTerritory, "
                  + "Person.Person "
                  + "WHERE ( Sales.SalesTerritory.TerritoryID = Sales.Customer.TerritoryID ) and "
                  + "( ( Sales.Customer.PersonID is not null ) AND "
                  + "( Sales.Customer.PersonID = Person.Person.BusinessEntityID ) ) "
                  + "ORDER BY Sales.Customer.CustomerID ASC")]
    #endregion
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Dddw_Customer_Individual
    {
        [Identity]
        [PropertySave(SaveStrategy.Ignore)]
        public int Customer_Customerid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Customer_Personid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public int? Customer_Territoryid { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Customer_Accountnumber { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Salesterritory_Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Title { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Firstname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Middlename { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Lastname { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public string Person_Suffix { get; set; }

        [DwCompute(" person_lastname +\" \" + person_firstname ")]
        public object Full_Name { get; set; }

    }

}
