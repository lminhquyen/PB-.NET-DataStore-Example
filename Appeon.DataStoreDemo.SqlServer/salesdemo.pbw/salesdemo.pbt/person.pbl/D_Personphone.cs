using DWNet.Data;
using SnapObjects.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appeon.DataStoreDemo.SqlServer
{
    [DataWindow("d_personphone", DwStyle.Grid)]
    [Table("PersonPhone", Schema = "Person")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"Person.PersonPhone\" ) COLUMN(NAME=\"Person.PersonPhone.BusinessEntityID\") COLUMN(NAME=\"Person.PersonPhone.PhoneNumber\") COLUMN(NAME=\"Person.PersonPhone.PhoneNumberTypeID\") COLUMN(NAME=\"Person.PersonPhone.ModifiedDate\")WHERE(    EXP1 =\"Person.PersonPhone.BusinessEntityID\"   OP =\"=\"    EXP2 =\":ai_id\" ) ) ARG(NAME = \"ai_id\" TYPE = number) ")]
    #endregion
    [DwParameter("ai_id", typeof(decimal?))]
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.Update)]
    public class D_Personphone
    {
        [Key]
        [DefaultValue("0")]
        public int Businessentityid { get; set; }

        [Key]
        public string Phonenumber { get; set; }

        [Key]
        [DwChild("Phonenumbertypeid", "Name", typeof(D_Dddw_Phonenumbertype))]
        public int Phonenumbertypeid { get; set; }

        [SqlDefaultValue("(getdate())")]
        public DateTime Modifieddate { get; set; }

    }

}
