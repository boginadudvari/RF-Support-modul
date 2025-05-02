using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class NewsletterSubscriber
{
    public int SubscriberId { get; set; }

    public string? Email { get; set; }

    public string? Name { get; set; }

    public DateTime? DateSubscribed { get; set; }
}
