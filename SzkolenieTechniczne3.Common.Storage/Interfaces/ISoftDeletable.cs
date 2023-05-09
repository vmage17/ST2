using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SzkolenieTechniczne3.Common.Storage.Interfaces
{
    interface ISoftDeletable
    {
        bool IsDeleted { get; set; }
    }
}
