using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class VwMessagesForDispatch
{
    public int UserId { get; set; }

    public int RecipientId { get; set; }

    public Guid? EmailSchedulerInstance { get; set; }

    public int EmailFrequency { get; set; }
}
