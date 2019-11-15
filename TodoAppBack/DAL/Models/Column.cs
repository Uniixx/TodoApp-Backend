using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoAppBack.DAL.Models
{
    public class Column
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string RawData { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
