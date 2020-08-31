using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace StockMarket.AdminAPI.Models
{
    [Table("IPO")]
    public class IPO
    {
        [Required]
        public int IPOID { get; set; }
        [ForeignKey("Company")]
        [Required]
        [StringLength(30)]
        public string CompanyCode { get; set; }
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(3)]
        public string StockExchange { get; set; }
        public double PricePerShare { get; set; }
        public int TotalNumberOfShare { get; set; }
        [StringLength(50)]
        public string Remarks { get; set; }
    }
}
