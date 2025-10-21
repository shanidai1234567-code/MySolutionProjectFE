﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReportList: List<Report>
    {
        public ReportList(){}
        public ReportList(IEnumerable<Report> list) : base(list) { }
        public ReportList(IEnumerable<BaseEntity> list) : base(list.Cast<Report>().ToList()) { }
    }
}
