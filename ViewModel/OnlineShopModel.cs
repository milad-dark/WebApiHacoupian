using System.Collections.Generic;

namespace WebApiHacoupian.ViewModel
{
    /// <summary>
    /// ViewModel For Get data from online shop as python`s.
    /// </summary>
    public class OnlineShopModel
    {
        //Customer Code
        public string user_code { get; set; }
        //Customer Name
        public string user_name { get; set; }
        //Created DateTime (epouch or timestamp)
        public double date { get; set; }
        //Invoice Number '223'
        public long invoice_number { get; set; }
        //Invoice Price Payment '105840000 R'
        public double payment { get; set; }
        //Company Order '2 is hacoupian Or 907 norashen'
        public int orgin { get; set; }
        //List of discount invoice
        public List<Discounts> discounts { get; set; }
        //List of Order Items invoice
        public List<InvoiceSlave> order_items { get; set; }

    }
    public class OnlineShopReturnedModel
    {
        //Customer Code
        public string user_code { get; set; }
        //Customer Name
        public string user_name { get; set; }
        //Created DateTime (epouch or timestamp)
        public double date { get; set; }
        //Invoice Number '223'
        public long invoice_number { get; set; }
        //dot net Invoice id '6523110'
        public long invoice_id { get; set; }
        //Invoice Price Payment '105840000 R'
        public double payment { get; set; }
        //Company Order '2 is hacoupian Or 907 norashen'
        public int orgin { get; set; }
        //List of discount invoice
        public List<Discounts> discounts { get; set; }
        //List of Order Items invoice
        public List<InvoiceSlave> order_items { get; set; }

    }
    public class Discounts
    {
        public int type { get; set; }
        public double price { get; set; }
    }
    public class InvoiceSlave
    {
        public string barcode { get; set; }
        public string name { get; set; }
        public int count { get; set; }
        public double price { get; set; }
    }

    public class Invoice
    {
        public long InvoiceId { get; set; }

    }
}
