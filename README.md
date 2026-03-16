# Sistema ETL de Análisis de Opiniones de Clientes

## Descripción del Proyecto

Este proyecto implementa un proceso de **extracción de datos (ETL)** para un sistema de análisis de opiniones de clientes. El objetivo principal es recopilar información proveniente de diferentes fuentes de datos y centralizarla para su posterior análisis.

se desarrolló un servicio utilizando **C#, .NET 9** y un **Worker Service**, lo que permite ejecutar procesos de extracción de datos en segundo plano de forma automatizada.

Las fuentes de datos utilizadas incluyen archivos CSV, una base de datos relacional y una API REST que proporciona comentarios externos de clientes.

---

## Arquitectura del Sistema

El sistema está basado en una arquitectura modular que separa las responsabilidades de cada componente. Para lograr mayor flexibilidad y mantenibilidad, se implementó una interfaz común para los extractores de datos.

Cada fuente de datos es manejada por un extractor específico que implementa la interfaz `IExtractor`.

---

## Fuentes de Datos

El sistema obtiene datos desde las siguientes fuentes:

* Archivos **CSV**
* **Base de datos relacional**
* **API REST**

Los archivos CSV utilizados incluyen:

* productos.csv
* clientes.csv
* encuestas.csv
* comentarios_sociales.csv
* resenas_web.csv
* fuentes.csv

---

## Estructura del Proyecto

El proyecto está organizado en diferentes carpetas para mantener una estructura clara y modular:

```
ETL_Opiniones_Worker
│
├── Extractors
│   ├── ApiExtractor.cs
│   ├── CsvExtractor.cs
│   └── DatabaseExtractor.cs
│
├── Interfaces
│   └── IExtractor.cs
│
├── Models
│
├── Services
│
├── data
│   ├── productos.csv
│   ├── clientes.csv
│   ├── encuestas.csv
│   ├── comentarios_sociales.csv
│   ├── resenas_web.csv
│   └── fuentes.csv
│
├── Program.cs
├── Worker.cs
└── ETL_Opiniones_Worker.csproj
```

---

## Flujo del Proceso ETL

El sistema ejecuta el proceso ETL siguiendo estos pasos:

1. Inicio del Worker Service.
2. Ejecución de los extractores de datos.
3. Extracción de información desde archivos CSV.
4. Consulta de datos desde la base de datos relacional.
5. Obtención de comentarios desde la API REST.
6. Consolidación de los datos extraídos para su posterior procesamiento.

---

## Ejecución del Proyecto

Para ejecutar el proyecto, se debe utilizar el siguiente comando en la terminal:

```
dotnet run
```

Durante la ejecución, el sistema iniciará el proceso ETL y ejecutará cada uno de los extractores configurados.

---

## Tecnologías Utilizadas

* .NET 9
* C#
* Worker Service
* Arquitectura modular
* Interfaces para desacoplamiento de componentes

---
