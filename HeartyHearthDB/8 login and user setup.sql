--use master
create login dev_HWlogin with password = 'HAPpy123!@#'

--use heartyhearthdb
create user dev_HWuser from login dev_HWlogin

alter role db_datareader add member dev_HWuser
alter role db_datawriter add member dev_HWuser