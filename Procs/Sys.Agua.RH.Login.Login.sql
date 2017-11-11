
 alter proc [Sys.Agua.RH.Login.Login]
@usuario varchar (20),
@senha varchar (30)


as begin 
	select * from login_usr where usuario = @usuario and senha = @senha
end
