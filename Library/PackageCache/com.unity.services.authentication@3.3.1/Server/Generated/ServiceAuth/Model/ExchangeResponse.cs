
//-----------------------------------------------------------------------------
// <auto-generated>
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using UnityEngine.Scripting;
using Unity.Services.Authentication.Server.Shared;

namespace Unity.Services.Authentication.Server.ServiceAuth.Generated
{
    /// <summary>
    /// ExchangeResponse
    /// </summary>
    [DataContract(Name = "ExchangeResponse")]
    [Preserve]
    internal partial class ExchangeResponse
    {
        /// <summary>
        /// Stateless access token
        /// </summary>
        /// <value>Stateless access token</value>
        [DataMember(Name = "accessToken", EmitDefaultValue = false)]
        [Preserve]
        public string AccessToken { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExchangeResponse" /> class.
        /// </summary>
        /// <param name="accessToken">Stateless access token.</param>
        [Preserve]
        public ExchangeResponse(string accessToken = default(string))
        {
            this.AccessToken = accessToken;
        }
    }

}
