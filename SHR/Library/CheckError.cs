using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHR.Library
{
    public class CheckError
    {
        private readonly List<string> ErrorMsg;
        public CheckError() { ErrorMsg = new List<string>(); }
        public void AddError(string msg) { ErrorMsg.Add(msg); }
        public bool HasError() { return ErrorMsg.Any(); }
        public string GetError() { return string.Join("\n", ErrorMsg); }
        public void ClearError() { ErrorMsg.Clear(); }
    }
}
