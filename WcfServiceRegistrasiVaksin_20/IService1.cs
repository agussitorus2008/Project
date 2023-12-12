using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfServiceRegistrasiVaksin_20;

namespace WcfServiceRegistrasiVaksin_20
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<VaksinData> GetVaksin();
        [OperationContract]
        void InsertVaksin(VaksinData obj);
        [OperationContract]
        void UpdateVaksin(VaksinData obj);
        [OperationContract]
        void DeleteVaksin(string id);
        [OperationContract]
        VaksinData GetDataById(string id);
        [OperationContract]
        void GetData();
    }
    [DataContract]
    public class Vaksin_Data
    {
        [DataMember]
        [Key]
        [Required]
        public string no_register { get; set; }
        [DataMember]
        [Required]
        public System.DateTime tanggal_dibuat { get; set; }
    }
}
