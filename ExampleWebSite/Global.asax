﻿<%@ Application Language="C#" %>
<script runat="server">
    /*
     * Copyright 2007-2010 The JA-SIG Collaborative. All rights reserved. See license
     * distributed with this file and available online at
     * http://www.ja-sig.org/products/cas/overview/license/index.html
     */

    void Application_Start(object sender, EventArgs e) 
    {
        log4net.Config.XmlConfigurator.Configure();
    }
</script>
