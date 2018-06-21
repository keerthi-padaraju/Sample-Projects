using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBSample.Models
{
    public class TestDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Detail> GetTestDetails()

        {

            var ctx = new API_TESTINGEntities();

            return ctx.Details.ToList();

        }
    }
}