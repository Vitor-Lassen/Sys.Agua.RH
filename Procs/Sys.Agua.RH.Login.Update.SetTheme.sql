
create proc [Sys.Agua.RH.Login.Update.SetTheme]
@usuario varchar (20),
@tema int,
@estilo int

as begin 
update  login_usr
set tema = tema , estilo = @estilo
where usuario = @usuario
end