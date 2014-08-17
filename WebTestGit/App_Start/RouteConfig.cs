// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright © 2014 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.WebTestGit {
   using System.Web.Routing;

   using App.WebTestGit.Routing;

   public class RouteConfig {
      public static void RegisterRoutes(RouteCollection routes) {
         routes.Add("Default", new DefaultRoute());
      }
   }
}
