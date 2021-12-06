using System;
using System.Collections.Generic;

namespace WebApiHacoupian.ViewModel
{
    public class ProductionOrderViewModel
    {
        //نوع محصول
        public string productType { get; set; }
        //جمع متراژ
        public double SumMeasure { get; set; }
        //جمع تعداد
        public long SumOrder { get; set; }
        //تاریخ سفارش
        public DateTime DateOrder { get; set; }
        //مارک
        public string Mark { get; set; }
        //توضیحات
        public string Explation { get; set; }
        //کالیته
        public string Kalite { get; set; }
        //دراپ
        public string Derap { get; set; }
        //سفارشات
        public List<ProductionOrderList> ProductionOrders { get; set; }

    }
    /// <summary>
    /// ViewModel For Save Product Barcode and Count for Size
    /// ذخیره اطلاعات مربوط به تعداد سفارش و تولید هر سایز و بارکد آن
    /// </summary>
    public class OrderSizeCount
    {
        //بارکد محصول
        public string Header_Code { get; set; }
        //سایز
        public string Size { get; set; }
        //تعداد سفارش
        public long Order_Count { get; set; }
        //تعداد تولید
        public long Product_count { get; set; }

    }

    public class ProductionOrderList
    {
        //متراژ
        public double Measure { get; set; }
        //تعداد کل مجصولات
        public long Count { get; set; }
        //بارکد تولید
        public string Cloth_Code { get; set; }
        //بارکد محصول بدوت سایز
        public string Product_Code { get; set; }
        //لیست تعداد هر سایز
        public List<OrderSizeCount> Orders { get; set; }
    }

    public class ProductOrderRequstModel
    {
        public string Number { get; set; }

    }
}
