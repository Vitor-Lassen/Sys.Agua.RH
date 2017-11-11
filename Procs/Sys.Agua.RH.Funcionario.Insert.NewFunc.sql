


USE [db_RH]
GO


alter procedure [Sys.Agua.RH.Funcionario.Insert.NewFunc]
@nome_func varchar(150),
@cpf_func varchar(14),
@banco_Func varchar(30),
@cont_banco_func int,
@agencia_banco_func int,
@salario_func money,
@codSetor int,
@dataAdm date,
@cod_func int output 
 
 as begin

INSERT INTO db_RH.dbo.[funcionario]
           ([nome_func]
		   ,[cpf_func]
		   ,[banco_Func]
           ,[cont_banco_func]
           ,[agencia_banco_func]
           ,[salario_func]
           ,[codSetor]
           ,[dataAdm])
     VALUES
           (@nome_func ,@cpf_func,@banco_Func ,@cont_banco_func ,@agencia_banco_func ,@salario_func ,@codSetor ,@dataAdm )
	set @cod_func = SCOPE_IDENTITY()
end



