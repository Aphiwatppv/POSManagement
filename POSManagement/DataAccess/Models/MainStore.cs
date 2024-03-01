using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class MainStore
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal? Price { get; set; }
    public string PriceUnit { get; set; } 
    public int? RemainingStock { get; set; }
    public string StockUnit { get; set; }
}
