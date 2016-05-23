using ÖvningstentaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ÖvningstentaMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

//
//---------------- den här gör att det går att lagra info
            using (var ctx = new SongContext())
            {
                Artist art = new Artist()
                { Name = "new artist" };
                ctx.Artists.Add(art);
                ctx.SaveChanges();
            }
//
//--------------------------------------------------------
        }
    }
}
