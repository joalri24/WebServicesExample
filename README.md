# WebServicesExample
An example of a RESTful web services solution. It contains an ASP.net Web Api 2  and a Windows Forms client.

**Referencias:**
* [Primera asp.net api](http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api)
* [asp.net api más avanzado](http://www.asp.net/web-api/overview/data/using-web-api-with-entity-framework/part-1)
* [Utilizar los servicios desde un cliente](http://www.asp.net/web-api/overview/advanced/calling-a-web-api-from-a-net-client)
* [Rutas en asp.net](http://www.asp.net/web-api/overview/web-api-routing-and-actions/routing-in-aspnet-web-api)
* [REST en ASP](http://www.asp.net/web-api/overview/web-api-routing-and-actions/create-a-rest-api-with-attribute-routing)
* [Arreglar problemas de la BD](http://stackoverflow.com/questions/13275054/ef5-cannot-attach-the-file-0-as-database-1)
* [Agregar documnetación en la pagina de ayuda del API](http://stackoverflow.com/questions/24284413/webapi-help-page-description)
* [Agregar migraciones de la BD](http://www.asp.net/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/adding-a-new-field-to-the-movie-model-and-table)
* [Autenticación](http://www.asp.net/web-api/overview/security/individual-accounts-in-web-api)
* [Autenticación con Google+](http://stackoverflow.com/questions/21065648/asp-net-web-api-2-how-to-login-with-external-authentication-services)
* [Cargar archivos al servidor](http://haacked.com/archive/2010/07/16/uploading-files-with-aspnetmvc.aspx/)
* [Bases de datos más complejas](http://www.asp.net/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-a-more-complex-data-model-for-an-asp-net-mvc-application)
* [Despliegue](https://www.asp.net/mvc/overview/deployment/visual-studio-web-deployment/introduction)
* [Data reader debe ser cerrado antes de volver a usar o algo...](http://stackoverflow.com/questions/4867602/entity-framework-there-is-already-an-open-datareader-associated-with-this-comma)


**Get the UserId in a controller of the web app:** var userId = User.Identity.GetUserId();

**Print in the Console of ASP.net:** System.Diagnostics.Debug.WriteLine(...)

**Mostar traza de errores en lugar de Error 500:** En Web.config --> \<System.Web\> --> \<CustomErrors mode="Off" />
