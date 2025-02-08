/* using System;

class Order{
    protected string orderId;
    protected DateTime orderDate;
    public Order(string orderId,DateTime orderDate){
        this.orderId = orderId;
        this.orderDate = orderDate;
    }
    public virtual void GetOrderStatus(){
        Console.WriteLine($"Order ID: {this.orderId}, Order Date: {this.orderDate.ToShortDateString()} - Status: Order Placed");
    }
}

class ShippedOrder:Order{
    protected string trackingNumber;
    public ShippedOrder(string orderId,DateTime orderDate,string trackingNumber):base(orderId,orderDate){
        this.trackingNumber = trackingNumber;
    }
    public override void GetOrderStatus(){
        Console.WriteLine($"Order ID: {this.orderId}, Tracking Number: {this.trackingNumber} - Status: Order Shipped");
    }
}

class DeliveredOrder:ShippedOrder{
    private DateTime deliveryDate;
    public DeliveredOrder(string orderId,DateTime orderDate,string trackingNumber,DateTime deliveryDate):base(orderId,orderDate,trackingNumber){
        this.deliveryDate = deliveryDate;
    }
    public override void GetOrderStatus(){
        Console.WriteLine($"Order ID: {this.orderId}, Delivered on: {this.deliveryDate.ToShortDateString()} - Status: Order Delivered");
    }
}

class Program{
    public static void Main(){
        Order order = new Order("ORD123", DateTime.Now);
        order.GetOrderStatus();
        ShippedOrder shippedOrder = new ShippedOrder("ORD124",DateTime.Now,"TRK123456");
        shippedOrder.GetOrderStatus();
        DeliveredOrder deliveredOrder = new DeliveredOrder("ORD125",DateTime.Now,"TRK987654",DateTime.Now.AddDays(3));
        deliveredOrder.GetOrderStatus();
    }
} */