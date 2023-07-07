
select * into b1 from BillInfo where idBill=38

select * into b2 from BillInfo where idBill=39

select * from b1
select * from b2

select b1.id from b1 where idFood in(select idFood from b2)

select * from BillInfo where idBill=39

select * into bill1 from BillInfo where idBill=38

update BillInfo set idBill=39 where idBill=38
;with billmoi as (select idBill,idFood, SUM(count) as sl  from BillInfo where idBill=39 group by idFood,idBill)

update BillInfo set count=billmoi.sl from BillInfo bi,billmoi where bi.idFood=billmoi.idFood and bi.ibBill=39

select * from  billmoi


select idFood from b1 where exists (select idFood from b2 where b1.idFood=b2.idFood)