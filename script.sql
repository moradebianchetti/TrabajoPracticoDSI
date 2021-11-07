use museo;

select * from reserva

select * from entrada
select * from tarifa
select * from Tipo_Entrada
select * from Tipo_Visita
select * from sede
 
INSERT INTO Tipo_Entrada VALUES ('General',0.05);
INSERT INTO Tipo_Entrada VALUES ('No General',0.07);

INSERT INTO Tipo_Visita VALUES ('Completa',0.05);
INSERT INTO Tipo_Visita VALUES ('Por exposición',0.03);


update tipo_entrada set porcentaje=0.05 where id=1;
update tipo_entrada set porcentaje=0.07 where id=2;

update tipo_entrada set nombre='Menores' where id=2;

update Tipo_Visita set porcentaje=0.05 where id=1;
update tipo_visita set porcentaje=0.03 where id=2;

alter table sede alter column montoBase int
alter table tarifa alter column monto  float
alter table tarifa alter column montoAdicionalGuia float

delete from Tipo_Entrada where id =5
delete from Entrada 

alter table tipo_visita alter column porcentaje int
alter table tipo_entrada alter column porcentaje int

INSERT [dbo].[tarifa] ([fechaFinVigencia], [montoAdicionalGuia], [monto], [fechaInicioVigencia], [idSede], [idTipoEntrada], [idTipoVisita]) 
VALUES (CAST(N'2021-06-29' AS Date), 200, 100, CAST(N'2021-06-28' AS Date), 1, 1, 1 )


INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:44:43' AS Time), 200, 8, 1, 1, 1, CAST(N'2021-06-28' AS Date))

INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:46:28' AS Time), 201, 9, 1, 1, 1, CAST(N'2021-06-28' AS Date))

INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'18:54:16' AS Time), 202, 10, 1, 1, 1, CAST(N'2021-06-28' AS Date))

INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'19:17:30' AS Time), 203, 11, 1, 1, 1, CAST(N'2021-06-28' AS Date))

INSERT [dbo].[Entrada] ([fechaVenta], [horaVenta], [monto], [numero], [idSede], [idTipoEntrada], [idTipoVisita], [fechaInicioVigencia]) VALUES (CAST(N'2021-06-28' AS Date), CAST(N'19:26:30' AS Time), 204, 12, 1, 1, 1, CAST(N'2021-06-28' AS Date))


alter table tipo_visita alter column porcentaje int
alter table tipo_entrada alter column porcentaje int

update Tipo_Entrada SET porcentaje=5 WHERE id=1
update Tipo_Entrada SET porcentaje=7 WHERE id=2

update Tipo_Visita SET porcentaje=5 WHERE id=1
update Tipo_Visita SET porcentaje=3 WHERE id=2