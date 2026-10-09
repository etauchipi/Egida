# Egida - Control de Entrega de Uniformes

Egida es una aplicación de escritorio diseñada para gestionar y controlar la entrega, devolución, lavandería, inventario y registro de nuevos uniformes. Está orientada a facilitar el seguimiento de las prendas e implementa una interfaz gráfica para usuarios administradores y operarios.

## 🛠 Pila Tecnológica (Tech Stack)

Basado en el análisis del repositorio, el proyecto utiliza la siguiente pila de tecnologías:

- **Lenguaje:** Visual Basic .NET (VB.NET)
- **Framework:** .NET Framework 4.8 (Windows Forms - WinForms)
- **Comunicación / Servicios Web:** Windows Communication Foundation (WCF) a través de `basicHttpBinding` para conectar con el servicio backend (`wsEgida.svc`).
- **Autenticación e Identidad:** Microsoft Authentication Library (MSAL) y JSON Web Tokens (JWT) para la autenticación de usuarios y conexión con Azure AD / Microsoft Identity.
- **Librerías de Terceros Adicionales:**
  - `Newtonsoft.Json` (Serialización/deserialización JSON)
  - `Microsoft.Web.WebView2` (Navegador integrado para flujos de login)
  - `IdentityModel`
- **IDE Recomendado:** Microsoft Visual Studio.

## ⚙️ Instalación y Configuración del Entorno Local

Sigue estos pasos para configurar y ejecutar el proyecto desde cero en tu entorno de desarrollo local:

1. **Clonar el Repositorio:**
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   cd <NOMBRE_CARPETA>
   ```

2. **Abrir la Solución:**
   Abre el archivo `Egida.sln` usando **Microsoft Visual Studio 2019 o superior**. Asegúrate de tener instalada la carga de trabajo de desarrollo de escritorio de .NET.

3. **Restaurar Paquetes NuGet:**
   El proyecto usa paquetes externos definidos en `packages.config`.
   - Haz clic derecho sobre la solución en el "Explorador de soluciones" y selecciona **"Restaurar paquetes NuGet"**.

4. **Configurar el Archivo `App.config`:**
   En la raíz del proyecto encontrarás el archivo de configuración principal (`App.config`). Debes actualizar los siguientes valores según el entorno en el que se vaya a ejecutar:
   - **Endpoint WCF:**
     Cambia la IP y el puerto de la etiqueta `<endpoint>` dentro de `<client>` para que apunte al servicio SOAP real:
     ```xml
     <client>
       <endpoint address="http://TU_IP:TU_PUERTO/wsEgida/wsEgida.svc" ... />
     </client>
     ```
   - **Autenticación (Si aplica):**
     Si la aplicación se integrará con Microsoft Identity de tu organización, deberás descomentar y completar las variables de entorno en `<appSettings>`:
     `clientId`, `tenant`, `authority`, `redirectAuthority`, `secret`, etc.

5. **Compilar y Ejecutar:**
   - Selecciona la configuración de compilación deseada (Debug/Release, AnyCPU).
   - Presiona `F5` o haz clic en "Iniciar" en Visual Studio para compilar y ejecutar la aplicación localmente.

## 📂 Estructura Principal de Carpetas

A continuación se muestra un resumen de la estructura del código del repositorio:

- `/` (Raíz): Contiene los archivos principales de configuración de la solución y del proyecto (`Egida.sln`, `Egida.vbproj`, `App.config`, `packages.config`, etc).
- `AppCode/`: Probablemente almacene clases utilitarias o extensiones requeridas por la aplicación, incluyendo código para el contexto asíncrono e interacción de base de datos o APIs externas.
- `AppData/`: Definiciones de conjuntos de datos tipados (`dsMain.xsd`, `dsMain.vb`) usados por la aplicación.
- `Connected Services/`: (Declarados en `.vbproj` aunque no aparezcan de inicio en el file system). Contiene referencias y metadatos proxy (WSDL) para consumir el servicio WCF backend.
- `Forms/`: Pantallas secundarias de la aplicación (e.g., ventana de login `frmLogin`, información sobre la aplicación `AboutBox`).
- `Images/` y `Resources/`: Íconos, imágenes, fondos o recursos incrustados (e.g., `egida.ico`, gráficos de usuario) utilizados en la interfaz gráfica.
- `Libs/`: Dependencias externas en formato `.dll` que no se obtienen a través de NuGet (`AppGeneral.dll`, `Compresion.dll`, `AppUtils.dll`, etc).
- `MDIMain.vb`: Pantalla principal del proyecto (MDI Parent). Contiene gran parte de la lógica central para los flujos operativos.

## 🚀 Guía Básica de Uso

La ventana principal de la aplicación proporciona las opciones clave requeridas para el flujo del inventario de uniformes. A continuación, se detallan los módulos de uso diario (la visibilidad depende de si el usuario es `Administrador` u Operario):

1. **Entrega (`btEntrega`)**:
   - Se debe buscar y seleccionar al usuario/empleado al que se le entregarán elementos (desde la base de usuarios mostrada).
   - El operario escanea o introduce hasta cuatro códigos de uniformes (ej: códigos de barras o identificadores de cada prenda).
   - El sistema valida la existencia y disponibilidad de cada elemento y registra el movimiento de "Entrega".

2. **Devolución (`btDevolucion`)**:
   - Usado cuando un empleado devuelve una prenda sucia o que ya no requiere.
   - El operario introduce los códigos de las prendas recibidas.
   - La aplicación actualiza su estado y quita la asignación del empleado, dejándolo libre en el sistema (por ejemplo, para enviar a lavandería).

3. **Lavandería (`btLavanderia`)**:
   - Proceso diseñado para registrar las prendas que regresan limpas de la lavandería para que estén nuevamente disponibles.
   - El operario simplemente escanea los códigos de los elementos, regresándolos a la lista de inventario activo.
   - *Nota: Los administradores pueden tener la opción de dar de "Baja" una prenda (pérdida, dañada) durante este proceso mediante la casilla habilitada.*

4. **Ingreso de Nuevo Inventario (`btIngreso`)**:
   - Disponible exclusivamente para **Administradores**.
   - Permite dar de alta nuevos uniformes a la base de datos de Egida.
   - Se debe seleccionar el "Tipo de Elemento", la "Talla", el "Color" desde las listas desplegables, y finalmente escanear/digitar el nuevo código del ítem.
