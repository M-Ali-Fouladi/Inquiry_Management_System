﻿using System;
using System.Data.Entity;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using CustomMembershipEF.Contexts;
using CustomMembershipEF.Models;

namespace CustomMembershipEF.CustomeAuthori
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = true, AllowMultiple = true)]
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            string cookieName = FormsAuthentication.FormsCookieName;

            if (!filterContext.HttpContext.User.Identity.IsAuthenticated ||
                filterContext.HttpContext.Request.Cookies == null ||
                filterContext.HttpContext.Request.Cookies[cookieName] == null
            )
            {
                HandleUnauthorizedRequest(filterContext);
                return;
            }

            var authCookie = filterContext.HttpContext.Request.Cookies[cookieName];
            var authTicket = FormsAuthentication.Decrypt(authCookie.Value);
            string[] roles = authTicket.UserData.Split(',');

            var userIdentity = new GenericIdentity(authTicket.Name);
            var userPrincipal = new GenericPrincipal(userIdentity, roles);

            filterContext.HttpContext.User = userPrincipal;
            base.OnAuthorization(filterContext);
        }
    }

}