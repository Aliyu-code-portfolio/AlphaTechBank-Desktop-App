using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Model.Enum
{
    public enum Status
    {
        [Description("Success")]
        Success,
        [Description("Failed")]
        Failed,
        [Description("Pending")]
        Pending
    }
}
