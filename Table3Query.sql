select *
from Orders
FULL OUTER JOIN RestaurantTable ON Orders.RestaurantTableID=RestaurantTable.RestaurantTableID
FULL OUTER JOIN Waiter ON Orders.WaiterID=Waiter.WaiterID
FULL OUTER JOIN OrderDetails ON Orders.OrdersID=OrderDetails.OrderDetailsID
FULL OUTER JOIN Menu ON OrderDetails.MenuID=Menu.MenuID
where  RestaurantTable.RestaurantTableID=3;