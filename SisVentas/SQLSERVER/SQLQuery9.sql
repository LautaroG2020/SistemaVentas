create procedure Validar_usuario
@Login varchar (50),
@Password varchar(50)
as
select * from Usuario
where Login = @Login and password = @Password and Acceso = '1'
go

create procedure Backup_base
as
backup database [dbventas]
to disk =N'C:\DESARROLLO.LAUTARO\SisVentas\BackUp_Base\dbventas.bak'
with description  =N'Respaldo de la base de datos del Sistema de ventas',
noformat,
init,
name=N'dbventas',
skip,
norewind,
nounload,
stats=10,
checksum
