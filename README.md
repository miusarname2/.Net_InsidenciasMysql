<img src="https://img.shields.io/badge/State-Developing-green">

# Incident Management System - Documentation

The Incident Management System is an application that allows you to record and manage incident reports related to hardware and software. Provides an API to interact with core functions, including authentication, report creation, and access to existing reports.

## Characteristics

- **Token-based authentication:** JSON Web Tokens (JWT) are used to authenticate users and allow secure access to protected paths.

- **Request Limiting:** A request limiting mechanism has been implemented to prevent system abuse and maintain service integrity.

- **Endpoints for Camper and Trainer:** Specific routes have been established for Camper and Trainer, each with different actions and permissions.

- **Report management:** Users can report incidents, and the reports are stored in a MongoDB database following defined schemas.

## Used technology:
- C#
- .NET Core [8.0]



## Taxpayers:
- Oscar M Alvarez G

<br>

[![Contributors](https://contrib.rocks/image?repo=miusarname2/insidenciasmysql)](https://github.com/miusarname2/insidenciasmysql/graphs/contributors)

## Final Notes

This documentation provides an overview of the key features and usage of the Incident Management application. Be sure to review the source code and specific paths to get a deeper understanding of the implemented functionalities.

Of course, here's an updated README that emphasizes installation, how to request tokens, and how to query your app using the `.env` file you provided:

---

## Licencia:
Este proyecto está bajo la Licencia MIT. Para más detalles, consulta el archivo [LICENSE](ruta/al/archivo/LICENSE).
