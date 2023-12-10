using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHR.Models
{
    public class DeviceTypes
    {
        public int Id { get; set; }
        [DisplayName("タイプ")]
        public required string Name { get; set; }
        public bool Active_Flag { get; set; }
    }
}
