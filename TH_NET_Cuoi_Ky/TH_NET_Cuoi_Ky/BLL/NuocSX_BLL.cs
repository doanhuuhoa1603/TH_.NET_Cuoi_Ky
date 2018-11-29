﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TH_NET_Cuoi_Ky.DAL;

namespace TH_NET_Cuoi_Ky.BLL
{
    class NuocSX_BLL
    {
        QLCSVC db;
        public NuocSX_BLL()
        {
            db = new QLCSVC();
        }
        public List<String> loadCBB_BLL()
        {
            List<String> l = new List<string>();
            var data = db.NuocSXs.Select(p => new { p.TenNuocSX }).Distinct();
            foreach(var i in data)
            {
                l.Add(i.TenNuocSX);
            }
            return l;
        }
    }
}
