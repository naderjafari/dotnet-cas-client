﻿/*
 * Copyright 2007-2010 The JA-SIG Collaborative. All rights reserved. See license
 * distributed with this file and available online at
 * http://www.ja-sig.org/products/cas/overview/license/index.html
 */

using DotNetCasClient.Security;

namespace DotNetCasClient.Validation.TicketValidator
{
    /// <summary>
    /// Contract for a validator that will confirm the validity of a supplied ticket.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Validator makes no statement about how to validate the ticket or the format 
    /// of the ticket (other than that it must be a String).
    /// </para>
    /// <para>
    /// This is the .Net port of org.jasig.cas.client.validation.TicketValidator
    /// </para>
    /// </remarks>
    /// <author>Scott Battaglia</author>
    /// <author>William G. Thompson, Jr. (.Net)</author>
    interface ITicketValidator
    {
        /// <summary>
        /// You retrieve CasAuthentication properties in the constructor or else you will cause 
        /// a StackOverflow.  CasAuthentication.Initialize() will call Initialize() on all 
        /// relevant controls when its initialization is complete.  In Initialize(), you can 
        /// retrieve properties from CasAuthentication.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Attempts to validate a ticket for the provided service.
        /// </summary>
        /// <param name="ticket">the ticket to validate</param>
        /// <param name="service">the service associated with this ticket</param>
        /// <returns>
        /// The ICasPrincipal backed by the CAS Assertion included in the response from
        /// the CAS server for a successful ticket validation.
        /// </returns>
        /// <exception cref="TicketValidationException">
        /// Thrown if ticket validation fails.
        /// </exception>
        ICasPrincipal Validate(string ticket, string service);

        string UrlSuffix
        {
            get;
        }

        string ArtifactParameterName
        {
            get;
        }

        string ServiceParameterName
        {
            get;
        }
    }
}


