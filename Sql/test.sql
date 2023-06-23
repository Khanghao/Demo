select t1.id, t1.AdID, t1.LogUpdate, t1.Message
from ADS as t1
inner join(
	select AdID, MIN(Logupdate) as MinLogUpdate
	from ADS
	group by AdID
)
t2 on t1.AdID = t2.AdID and t1.LogUpdate = t2.MinLogUpdate