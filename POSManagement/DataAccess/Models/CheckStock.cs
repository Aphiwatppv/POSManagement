using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class CheckStock
{
    public int IdTransaction { get; set; }
    public int ProductId { get; set; }
    public int? CarID { get; set; }
    public int? TakingStockFromStore { get; set; }
    public int? ReturningStockFromCar { get; set; }
    public string StockUnit { get; set; }
    public bool? IsReturnToStore { get; set; }
    public DateTime? Datetime { get; set; }
    public int? IdEmployee { get; set; }
}
