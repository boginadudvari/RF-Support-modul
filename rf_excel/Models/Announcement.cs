using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class Announcement
{
    public int ItemId { get; set; }

    public int ModuleId { get; set; }

    public DateTime? CreatedOnDate { get; set; }

    public string? Title { get; set; }

    public string? Url { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Description { get; set; }

    public int? ViewOrder { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime? PublishDate { get; set; }

    public string? ImageSource { get; set; }

    public int? LastModifiedByUserId { get; set; }

    public DateTime? LastModifiedOnDate { get; set; }

    public int? PortalId { get; set; }

    public int? ContentItemId { get; set; }

    public virtual Module Module { get; set; } = null!;
}
