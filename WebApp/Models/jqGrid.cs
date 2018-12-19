using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class JqGrid
    {
        public string sidx { get; set; }
        public string sord { get; set; }
        public int rows { get; set; }
        public int page { get; set; }
        public int count { get; set; }
    }

    public class JqGridModel<T>
    {
        public int page { get; set; }
        public int total { get; set; }
        public int records { get; set; }
        public int start { get; set; }
        public int limit { get; set; }

        public string sord { get; set; }
        public List<T> rows { get; set; }

        public void Config(JqGrid jq)
        {
            this.sord = jq.sidx + ' ' + jq.sord;

            double count = jq.count;
            double rows = jq.rows;

            int total_pages = jq.count > 0 ? Convert.ToInt32(Math.Ceiling(count / rows)) : 0;
            this.start = (jq.rows * jq.page - jq.rows) + 1;
            this.limit = jq.page == 1 ? jq.rows : jq.rows * jq.page;

            this.page = jq.page;
            this.total = total_pages;
            this.records = jq.count;
        }
        public void DataSource(List<T> data)
        {
            this.rows = data;
        }
    }
}