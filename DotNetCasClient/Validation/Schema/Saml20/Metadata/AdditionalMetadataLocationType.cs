﻿/*
 * Copyright 2007-2010 The JA-SIG Collaborative. All rights reserved. See license
 * distributed with this file and available online at
 * http://www.ja-sig.org/products/cas/overview/license/index.html
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml20.Metadata
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:metadata")]
    [XmlRoot("AdditionalMetadataLocation", Namespace="urn:oasis:names:tc:SAML:2.0:metadata", IsNullable=false)]
    public class AdditionalMetadataLocationType {
        [XmlAttribute("namespace", DataType="anyURI")]
        public string Namespace
        {
            get;
            set;
        }

        [XmlText(DataType="anyURI")]
        public string Value
        {
            get;
            set;
        }
    }
}