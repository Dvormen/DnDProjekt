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

create table DnDGender(
id int primary key identity(1,1),
druh varchar(50)
)

create table DnDCharacter(
id int primary key identity(1,1),
id_user int foreign key references DnDUser(id),
rasa int foreign key references DnDRace(id),
classa int foreign key references DnDClass(id),
subClassa int foreign key references DnDClass(id),
gender_id int foreign key references DnDGender(id),
jmeno varchar(100),
prijmeni varchar(100),
vek int,
vyska int,
vaha int,
lore varchar(8000),
max_Hp int,
armor_class int,
strength int,
dexterity int,
constitution int,
inteligence int,
wisdom int,
charisma int,
obrazek varbinary(max)
)

create table DnDkostka(
id int primary key identity(1,1),
id_user int foreign key references DnDUser(id),
id_charakter int foreign key references DnDCharacter(id),
stat_id int foreign key references DnDStats(id),
kvantita int,
druh_kostky int,
mod_kostka int
)

create table DnDStats(
id int primary key identity(1,1),
stat varchar(50)
)