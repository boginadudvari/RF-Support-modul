using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class AnnouncementsSubscriber
{
    public int AnnouncementsSubscriberId { get; set; }

    public int ModuleId { get; set; }

    public int UserId { get; set; }

    public int? CreatedByUserId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public virtual Module Module { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
