using SHR.Library;
using Dapper;
using System.Data.Common;

namespace SHR.Models
{
    public class Devices
    {
        public int Id { get; set; }
        public required string Code { get; set; }
        public int Location_Id { get; set; }
        public bool Active_Flag { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DeviceTypes? DeviceType { get; set; }
        public OS? OS { get; set; }

        // 引数なしのコンストラクタがないとDapperがエラーになる
        public Devices() { }

        public static IEnumerable<Devices> GetDevices()
        {
            using DbConnection con = DbConnector.GetDbConnector();
            con.Open();
            return con.Query<Devices, DeviceTypes, OS, Devices>(
                "SELECT * From shr.devices D " +
                "LEFT JOIN shr.devicetypes DT ON D.devicetype_id = DT.id " +
                "LEFT JOIN shr.os OS ON D.os_id = OS.id",
                (d, dt, os) => { d.DeviceType = dt; d.OS = os; return d; });
        }
    }
}
