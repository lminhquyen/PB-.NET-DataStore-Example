using DWNet.Data;
using SnapObjects.Data;
using System.Collections.Generic;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_dddw_email", DwStyle.Grid)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    [DwTemplate(DataFormat.Xml, "d_dddw_email", "salesdemo.pbw\\salesdemo.pbt\\person.pbl\\d_dddw_email.tpl.d_dddw_email.xml")]
    [DwData(typeof(D_Dddw_Email_Data))]
    public class D_Dddw_Email
    {
        [PropertySave(SaveStrategy.Ignore)]
        public string Name { get; set; }

        [PropertySave(SaveStrategy.Ignore)]
        public decimal? Value { get; set; }

    }

    #region D_Dddw_Email_Data
    public class D_Dddw_Email_Data : DwDataInitializer<D_Dddw_Email>
    {
        public override IList<D_Dddw_Email> GetDefaultData()
        {
            var datas = new List<D_Dddw_Email>()
            { 
                 new D_Dddw_Email() { Name = "Contact does not wish to receive e-mail promotions", Value = 0m },  
                 new D_Dddw_Email() { Name = "Contact does wish to receive e-mail promotions from AdventureWorks ", Value = 1m },  
                 new D_Dddw_Email() { Name = "Contact does wish to receive e-mail promotions from AdventureWorks and selected partners ", Value = 2m },              
            };

            return datas;
        }
    }
    #endregion
}
