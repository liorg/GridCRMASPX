﻿
using Report.Controls.GridBase;

namespace Report.Controls.C2013.Grid
{
    public partial class HeaderSorting2013 : HeaderSortingBase
    {
        protected string GetCrmGridResizeId(object o)
        {
            return "crmGrid_resize_" + o.ToString();
        }
        protected string GetFilterPopupcrmGridId(object o)
        {
            return "stringFilterPopupcrmGrid" + o.ToString();
        }
    }
}