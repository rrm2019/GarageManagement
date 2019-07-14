# CONTROL DE SALIDAS Y ENTRADAS ( MVC 5 REST API )

## Descripción
Aplicación para controlar la salida y entrada de vehículos en un garaje así como el control de fecha de revisión del vehículo.

Se presentará un listado de vehículos con información de los mismos.
El usuario de la aplicación podrá gestionar la salida a ruta y entrada a garaje así como visualizar el estado del vehículo.
Información del estado:
- Llave negra: no tiene que pasar la revisión del vehículo.
- Llave naranja: quedan al menos 5 días para que la fecha de revisión se sobrepasara.
- Llave roja: ya ha llegado la fecha de revisión y el vehículo no puede salir del garaje.

## Requisitos 
 - Visual Studio 2017
 - SqlServer
 - Swagger
 
## Usage 

En el Web.Config es necesario cambiar 'Data Source' a una base de datos creada en su SQLServer.

```sh
<add name="DefaultConnection" connectionString="Data Source= (LocalDb)\MSSQLLocalDB;initial catalog=SystemGoal;integrated security=True;MultipleActiveResultSets=True;" providerName="System.Data.SqlClient" />
```
A continuación, ejecute el programa, las tablas se crearán solas (code first).

## Testing
Ya que no se ha facilitado un test, se ha facilitado la API de swagger para poder probar los métodos de la API.

```
http://localhost:50069/swagger
```

## Mejoras
Las mejoras a aplica en la aplicación:
- Incluir control de acceso (login).
- Creacción de roles.
- Securizar el acceso a la api y vistas.
- Cambiar las tablas de información por datatables para el control de una posible una carga masiva de datos.
- Renderizar la tabla (por jQuery/javaScript) cada vez que se cambia un registro. Así se evitaría el volver a cargar toda la página de nuevo.


 
