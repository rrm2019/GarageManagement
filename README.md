# POC INVENTARIO DE VEHICULOS ( MVC 5 REST API )

## Descripción
Aplicación para controlar el inventario de una empresa dedicada al alquiler de vehiculos a través de una API REST.
Se ha implementado un pequeño frontend con mvc5 razor para consumir esta api.

Se deberá registrar por lo tanto la salida y entrada de vehículos en el garaje de la empresa, así como el control de fecha de revisión del vehículo para saber si está disponible o no.

Las funcionalidades expuestas en la API son las siguientes:
- Listado de vehículos, con la información de los mismos.
- Dado el id del vehículo, listar la infomracion
- Modificar el estado de un vehículo
- Dar de alta un nuevo vehículo en el sistema.

En la capa del frontend , el usuario de la aplicación podrá gestionar la salida a ruta y entrada a garaje así como visualizar el estado del vehículo.
Los coches disponibles se presentan en dos listas. La de vehículos en el garaje, y los que se encuentran actualmente en ruta. El usuario podrá moverlos de una lista a otra.
A parte el usuario podrá llevar a cabo las funcionalidaes básicas para la gestión de un inventarió de vehículos.
- Obtener información del estado:
  - Llave negra: no tiene que pasar la revisión del vehículo.
  - Llave naranja: quedan al menos 5 días para que la fecha de revisión se sobrepase.
 - Llave roja: ya ha llegado la fecha de revisión y el vehículo no puede salir del garaje.
- Introducir un nuevo vehículo
- Moverlo entre las listas

Los coches se persisten en una base de datos Sql Server.

Tambíen se ha añadido swagger para poder exponer la Api para pruebas de una forma sencilla.

## Requisitos 
 - Visual Studio 2017
 - SqlServer
 - Swagger
 - .net MVC Web Api
 
## Cómo ejecutarlo 

Clonar el repositorio y cambiar el data source de la base de datos, esto se realiza en el fichero Web.Config.

```xml
<add name="DefaultConnection" connectionString="Data Source= (LocalDb)\MSSQLLocalDB;initial catalog=SystemGoal;integrated security=True;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" />
```
> cambiar el connectionString por una base de datos que tengamos. No hace falta crear tablas, ya que al ejecutar el programa las tablas se crearán automáticamente basándose en las entidades implementadas (code first).

## Testing

No se han facilitado test unitarios o de integración, pero se ha añadido swagger para poder probar los métodos de la API de manera sencilla.
Para acceder a la api de swagger, basta con acceder al siguiente endpoint:

```
http://localhost:50069/swagger
```

## Mejoras

Debido a la fatal de tiempo, han quedado funcionalidades sin implementar pero que se considerarían imprescindibles en un aplicación real:
- Incluir autorización y control de acceso, mediante el uso de roles y tokens jwt.
- Securizar el acceso a la api y vistas.
- Cambiar las tablas de información por datatables para el control de una posible una carga masiva de datos.
- Renderizar la tabla (por jQuery/javaScript) cada vez que se cambia un registro. Así se evitaría el volver a cargar toda la página de nuevo. 
- Añadir unit testing


 
