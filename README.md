# Enlace del cuestiorio de git 
[Clic aqui ](https://itlaedudo-my.sharepoint.com/:w:/g/personal/202010742_itla_edu_do/EVuM_BW5oqZJptZgleluW8oBond-7nVCQFaV5-cTOvzg-w?e=d9HS8e)

# Proyecto: Sistema de Registro para el Bono de Ayuda

Descripción General
El proyecto "Bono Ayuda" se centra en facilitar el proceso de registro y distribución de bonos de ayuda económica proporcionados por el gobierno dominicano. La iniciativa busca llegar a estudiantes y personas con habilidades diversas que requieren asistencia financiera.

Características Clave:
Registro y Solicitud:

La plataforma permite a los usuarios registrarse y solicitar el bono de ayuda proporcionando información clave.
La cédula dominicana se utiliza como primer paso de verificación.
Si la cédula es válida, se solicitarán datos adicionales, incluyendo teléfono, correo, dirección, estado civil, profesión, y una breve justificación de por qué el usuario merece recibir el bono.
Validación de Cédula:

Se utiliza la API de validación de cédulas (https://api.adamix.net/apec/cedula/CEDULA) para verificar la autenticidad de la cédula ingresada.
En caso de cédula inválida, se informa al usuario y se le impide continuar hasta que proporcione una cédula válida.
Referencias y Recompensas:

Opcionalmente, los usuarios pueden referenciar hasta 5 amigos.
Por cada amigo referenciado que complete su registro, tanto el referente como el referido recibirán una recompensa de 5,000 pesos.
Validación Completa:

Antes de guardar la información del usuario, se requiere que el usuario complete todos los campos obligatorios.
Se proporcionan mensajes amigables para informar al usuario sobre los campos faltantes.
Vista de la Presidencia:

Una interfaz específica para la presidencia permite visualizar estadísticas clave.
La vista incluye el total de personas registradas, desglose por sexo y desglose por edad.
Listado Completo de Registrados:

Se proporciona una lista completa de todos los usuarios registrados.
La lista incluye información esencial como cédula, nombre, apellido, teléfono y edad.
Tecnologías Utilizadas:
Frontend: HTML, CSS, Blazor (WebAssembly)
Backend: .NET Core
Almacenamiento de Datos: Base de datos (por determinar)
Objetivo:
El proyecto "Bono Ayuda" tiene como objetivo crear una plataforma eficiente y segura que permita a los ciudadanos acceder al bono de ayuda del gobierno dominicano de manera transparente y equitativa. Además, busca proporcionar a la presidencia herramientas efectivas para la supervisión y gestión de los registros.






