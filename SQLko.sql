create table DnDUser(
id int primary key identity(1,1),
enc_id int foreign key references DnDEncrypt(id),
username varchar(50) unique,
passwd varbinary(16)
)

create table DnDEncrypt(
id int primary key identity(1,1),
kv varbinary(16),
vv varbinary(16)
)

create table DnDRace(
id int primary key identity(1,1),
druh varchar(50)
)

create table DnDClass(
id int primary key identity(1,1),
druh varchar(50)
)

create table DnDCharacter(
id int primary key identity(1,1),
id_user int foreign key references DnDUser(id),
rasa int foreign key references DnDRace(id),
classa int foreign key references DnDClass(id),
jmeno varchar(50),
prijmeni varchar(50),
vek int,
vyska int,
vaha int,
lore varchar(1000),
max_Hp int,
armor_class int,
stre int,
dex int,
con int,
inte int,
wis int,
ch int
--pozdìji pøidat možnost obrázku--
)

create table DnDkostka(
id int primary key identity(1,1),
id_user int foreign key references DnDUser(id),
id_charakter int foreign key references DnDCharacter(id),
kvantita int,
druh_kostky int,
mod_kostka int,
stat varchar(50)
)
