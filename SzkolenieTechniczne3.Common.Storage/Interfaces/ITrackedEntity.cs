using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SzkolenieTechniczne3.Common.Storage.Interfaces
{
    interface ITrackedEntity
    {
        DateTime CreatedOn { get; set; }
        DateTime ModifiedOn { get; set; }
        Guid CreatedByUserId { get; set; }
        Guid ModifiedByUserId { get; set; }

    }
}
