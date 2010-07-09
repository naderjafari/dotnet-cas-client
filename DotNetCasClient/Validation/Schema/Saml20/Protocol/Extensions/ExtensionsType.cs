﻿/*
 * Copyright 2007-2010 The JA-SIG Collaborative. All rights reserved. See license
 * distributed with this file and available online at
 * http://www.ja-sig.org/products/cas/overview/license/index.html
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml20.Protocol.Extensions
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(TypeName="ExtensionsType", Namespace="urn:oasis:names:tc:SAML:2.0:protocol")]
    [XmlRoot("Extensions", Namespace="urn:oasis:names:tc:SAML:2.0:protocol", IsNullable=false)]
    public class ExtensionsType {
        [XmlAnyElement]
        public XmlElement[] Any
        {
            get;
            set;
        }
    }
}