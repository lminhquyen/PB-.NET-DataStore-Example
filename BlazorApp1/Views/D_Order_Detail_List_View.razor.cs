using Appeon.DataStoreDemo.SqlServer;
using BlazorApp1.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Views
{
    public class D_Order_Detail_List_ViewModel : DataWindow_ViewModel<D_Order_Detail_List>
    {
        public int Salesorderdetailid
        {
            get => Model.Salesorderdetailid;
            set => Model.Salesorderdetailid = value;
        }
        public int Productid
        {
            get => Model.Productid;
            set => Model.Productid = value;
        }
        public decimal Unitprice
        {
            get => Model.Unitprice;
            set => Model.Unitprice = value;
        }
        public int Orderqty
        {
            get => Model.Orderqty;
            set => Model.Orderqty = value;
        }
        public decimal Unitpricediscount
        {
            get => Model.Unitpricediscount;
            set => Model.Unitpricediscount = value;
        }
        public decimal Linetotal
        {
            get => Model.Linetotal;
            set => Model.Linetotal = value;
        }
        public DateTime Modifieddate
        {
            get => Model.Modifieddate;
            set => Model.Modifieddate = value;
        }

        public int Specialofferid
        {
            get => Model.Specialofferid;
            set => Model.Specialofferid = value;
        }
    }
}
