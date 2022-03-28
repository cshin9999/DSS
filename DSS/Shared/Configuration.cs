using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSS.Shared
{
    public class Configuration
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;
        public string ControlFile { get; set; } = string.Empty;
        public string Carriers { get; set; } = string.Empty;
        public DateTime LastModifiedDate { get; set; } = new DateTime();
        public string Status { get; set; } = string.Empty; 
    }
}
