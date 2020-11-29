select *
from RestaurantTable
FULL OUTER JOIN Orders ON Orders.RestaurantTableID=RestaurantTable.RestaurantTableID
where WaiterID=2;