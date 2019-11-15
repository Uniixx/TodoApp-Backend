using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppBack.DAL.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string ColumnId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
