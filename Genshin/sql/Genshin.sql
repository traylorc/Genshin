use GenshinDb;

-- Weapons data

Insert into Weapons(WeaponType)
	VALUES('Bow');

Insert into Weapons(WeaponType)
	VALUES('Catalyst')

Insert into Weapons(WeaponType)
	VALUES('Claymore');

Insert into Weapons(WeaponType)
	VALUES('Longsword');

Insert into Weapons(WeaponType)
	VALUES('Polearm');

go

--Element data 

Insert into Elements(Name)
	VALUES('Anemo');

Insert into Elements(Name)
	VALUES('Cryo');

Insert into Elements(Name)
	VALUES('Dendro');

Insert into Elements(Name)
	VALUES('Electro');

Insert into Elements(Name)
	VALUES('Geo');

Insert into Elements(Name)
	VALUES('Hydro');

Insert into Elements(Name)
	VALUES('Pyro');

go
-- declaring variables 

declare @bow int;
Select @bow = Id from Weapons where WeaponType = 'Bow';

declare @catalyst int;
Select @catalyst = Id from Weapons where WeaponType = 'Catalyst';

declare @claymore int;
Select @claymore = Id from Weapons where WeaponType = 'Claymore';

declare @longsword int;
Select @longsword = Id from Weapons where WeaponType = 'Longsword';

declare @polearm int;
Select @polearm = Id from Weapons where WeaponType = 'Polearm';

declare @anemo int;
Select @anemo = Id from Elements where Name = 'Anemo';

declare @cryo int;
Select @cryo = Id from Elements where Name = 'Cryo';

declare @dendro int; 
Select @dendro = Id from Elements where Name = 'Dendro';

declare @electro int;
Select @electro = Id from Elements where Name = 'Electro';

declare @geo int;
Select @geo = Id from Elements where Name = 'Geo';

declare @hydro int;
Select @hydro = Id from Elements where Name = 'Hydro';

declare @pyro int;
Select @pyro = Id from Elements where Name = 'Pyro';


Insert into Characters( Name, Region, Location, Ranking, WeaponId, ElementId)
	VALUES('Albedo','Mondstadt','Wyrmrest Valley', 5, @longsword, @geo);

Insert into Characters(Name,Region,Location, Ranking, WeaponId, ElementId)
	VALUES('Amber', 'Mondstadt', 'Mondstadt', 4, @bow, @pyro);

Insert into Characters( Name, Region, Location, Ranking, WeaponId, ElementId)
	VALUES('Barbara', 'Mondstadt', 'Cathedral', 4, @catalyst, @hydro);

Insert into Characters(Name, Region, Location, Ranking, WeaponId, ElementId)
	VALUES('Beidou', 'Inazuma', 'Guyun Stone Forest', 4, @claymore, @electro);

Insert into Characters(Name, Region, Location, Ranking, WeaponId, ElementId)
	VALUES('Ganyu', 'Liyue', 'Liyue Harbor', 5, @bow, @cryo);

Insert into Characters(Name, Region, Location, Ranking, WeaponId, ElementId)
	VALUES('Xiao', 'Liyue', 'Wangshu Inn', 5, @polearm, @anemo);

go