USE [db_RH]
GO


create procedure [Sys.Agua.RH.Funcionario.Update.AtuaFunc]
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

UPDATE [dbo].[funcionario]
   SET [nome_func] = @nome_func 
      ,[cpf_func] = @cpf_func
      ,[banco_Func] = @banco_Func
      ,[cont_banco_func] = @cont_banco_func
      ,[agencia_banco_func] = @agencia_banco_func
      ,[salario_func] = @salario_func
      ,[codSetor] = @codSetor
      ,[dataAdm] = @dataAdm
 WHERE cod_func = @cod_func
end