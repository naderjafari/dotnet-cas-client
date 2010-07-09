﻿/*
 * Copyright 2007-2010 The JA-SIG Collaborative. All rights reserved. See license
 * distributed with this file and available online at
 * http://www.ja-sig.org/products/cas/overview/license/index.html
 */

using System;
using DotNetCasClient;

namespace Restricted.AuthenticatedUsersOnly
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CasAuthentication.ServiceTicketManager != null)
            {
                YourTickets.DataSource = CasAuthentication.ServiceTicketManager.GetUserServiceTickets(User.Identity.Name);
                YourTickets.DataBind();
            }
        }
    }
}