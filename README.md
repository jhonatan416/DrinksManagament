# DrinksManagament

Proyecto de pruebas para Chubb

## Requisitos previos

Asegúrate de tener instalado lo siguiente:

- Visual Studio 2022
- NetCore 6.0
- SQL Server

## Configuración

1. Clonar el repositorio.

2. Instalar las dependencias:  `dotnet restore`.

3. Configurar las variables de entorno.

3.1 En el archivo appsettings.json se encuentra la variable de configuración de la conexión a base de datos, por favor modifiquela de forma tal que el aplicativo pueda acceder a la misma.

3.2 En el archivo log4net.config en la carpeta Configuration se encuentra la configuracion del logger se recomienda crear una carpeta en el disco C llamada LogsDrinksManagement sobre la cual se encuentra configurado actualmente el aplicativo

4. Desde la consola del administrador de paquetes por favor ejecutar migrations para cargar la base de datos, Ejecutar el comando Update-Database

## Uso

Al ejecutar el proyecto le permitira registrarse o ingresar el usuario puede ingresar con los siguientes usuarios de prueba

Usuario con perfil Administrator:
UserName = admin@localhost.com
Password = P@ssword1

Usuario con perfil de User
UserName = user@localhost.com
Password = P@ssword1

Para el caso practico unicamente los usuarios con perfil administrator pueden crear las bebidas.