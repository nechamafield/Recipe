--use master
create login dev_HWlogin with password = 'HAPpy123!@#'

--use heartyhearthdb
create users dev_HWusers from login dev_HWlogin

alter role db_datareader add member dev_HWusers
alter role db_datawriter add member dev_HWusers
