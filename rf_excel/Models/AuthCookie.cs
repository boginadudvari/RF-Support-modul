using System;
using System.Collections.Generic;

namespace rf_excel.Models;

public partial class AuthCookie
{
    public int CookieId { get; set; }

    public string CookieValue { get; set; } = null!;

    public DateTime ExpiresOn { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
