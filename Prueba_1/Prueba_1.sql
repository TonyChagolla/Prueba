--Depurar solo los ID diferentes de 6,7,9 y 10 de la tabla usuarios
DELETE FROM usuarios 
where userId not in (6,7,9,10)

--Actualizar el dato Sueldo en un 10 porciento a los empleados que tienen fechas entre el año 2000 y 2001
UPDATE e set Sueldo = Sueldo * 1.1 
FROM empleados e
where DATEPART(YEAR, e.FechaIngreso) in ('2000', '2001')

--Realiza una consulta para traer el nombre de usuario y fecha de ingreso de los usuarios que
--gananen mas de 10000 y su apellido comience con T ordernado del mas reciente al mas antiguo
SELECT Nombre, e.FechaIngreso FROM 
usuarios u 
inner join empleados e on e.userId = u.userId
WHERE (Paterno like 'T%' or Materno like 'T%')
AND sueldo > 10000
ORDER BY FechaIngreso DESC

--Realiza una consulta donde agrupes a los empleados por sueldo, un grupo con los que ganan
--menos de 1200 y uno mayor o igual a 1200
SELECT 'Menor a 12' as Grupo, COUNT(*) Numero_Empleados FROM empleados
WHERE sueldo < 12000
UNION
SELECT 'Mayor o igual a 12' as Grupo, COUNT(*) Numero_Empleados FROM empleados
WHERE sueldo >= 12000

--¿Cuantos hay en cada grupo?
--Sin depurar la tabla - Menor a 12000: 18 empleados; Menor 12000: 28 empleados
--Con la tabla depurada - Menor a 12000: 2 empleados; Menor 12000: 2 empleados

