La empresa N5 solicita una Web API para el registro de permisos de usuarios, para realizar esta tarea
es necesario cumplir con los siguientes pasos:
1. Cree una tabla de Permisos con los siguientes campos:

  ### permisos 
  
  | Name              | Data Type  |Extra Field     | Description             |
  |-------------------|------------|----------------|-------------------------|
  | Id                | Integer    | Auto-increment | Unique ID               |
  | NombreEmpleado    | Text       | Not null       | Employee Forename       |
  | ApellidoEmpleado  | Text       | Not null       | Employee Surname        | 
  | TipoPermiso       | Integer    | Not null       | Permission Type         | 
  | FechaPermiso      | Date       | Not null       | Permission granted on   |


2. Cree una tabla TipoPermisos con los siguientes campos:

  ### TipoPermisos 
 
  | Name              | Data Type  |Extra Field     | Description             |
  |-------------------|------------|----------------|-------------------------|
  | Id                | Integer    | Auto-increment | Unique ID               |
  | Descripcion       | Text       | Not null       | Permission description  |
  
3. Crear relación entre Permiso y TipoPermiso
4. Construir una API web con ASP .NET Core y guarde los datos en SQL Server.
5. La Web API debe tener 3 servicios &quot;Solicitar permiso&quot;, &quot;Modificar permiso&quot; y &quot;Obtener
permisos&quot;. Cada servicio debe conservar un registro de permisos.
Utilizar los patrones de diseño Repository, Unit of Work y (deseable) CQRS. Considerar que es
requisito mantener una arquitectura limpia y separada en capas utilizando inyeccion de
dependencia.
6. Cree pruebas unitarias para llamar a los tres servicios.
7. Construir una aplicación en ReactJS y use Axios para conectarse al backend.
8. Cree los tres formularios para consumir la API web.
9. Darle estilos a los tres formularios, para que se vea lo más atractivo y sencillo posible.
10. Suba el ejercicio a algún repositorio (github, gitlab,etc).
