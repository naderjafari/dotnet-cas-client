﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace DotNetCasClient.Validation.Schema.Saml20.Assertion
{
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace="urn:oasis:names:tc:SAML:2.0:assertion")]
    [XmlRoot("NameID", Namespace="urn:oasis:names:tc:SAML:2.0:assertion", IsNullable=false)]
    public class NameIdType {
        [XmlAttribute]
        public string NameQualifier
        {
            get;
            set;
        }

        [XmlAttribute("SPNameQualifier")]
        public string SpNameQualifier
        {
            get;
            set;
        }

        [XmlAttribute(DataType="anyURI")]
        public string Format
        {
            get;
            set;
        }

        [XmlAttribute("SPProvidedID")]
        public string SpProvidedId
        {
            get;
            set;
        }

        [XmlText]
        public string Value
        {
            get;
            set;
        }
    }
}