select * from OrderDetails
full OUTER JOIN Menu ON OrderDetails.MenuID=Menu.MenuID
where Price >0
Order by OrdersID;