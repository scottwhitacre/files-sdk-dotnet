using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Files.Models
{
    public class Bundle
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public Bundle()
        {
            this.attributes = new Dictionary<string, object>();
            this.options = new Dictionary<string, object>();

            this.attributes.Add("code", null);
            this.attributes.Add("url", null);
            this.attributes.Add("description", null);
            this.attributes.Add("password_protected", null);
            this.attributes.Add("require_registration", null);
            this.attributes.Add("clickwrap_body", null);
            this.attributes.Add("id", null);
            this.attributes.Add("created_at", null);
            this.attributes.Add("expires_at", null);
            this.attributes.Add("max_uses", null);
            this.attributes.Add("note", null);
            this.attributes.Add("user_id", null);
            this.attributes.Add("username", null);
            this.attributes.Add("clickwrap_id", null);
            this.attributes.Add("inbox_id", null);
            this.attributes.Add("paths", new string[0]);
            this.attributes.Add("password", null);
        }

        public Bundle(Dictionary<string, object> attributes, Dictionary<string, object> options)
        {
            this.attributes = attributes;
            this.options = options;
        }

        /// <summary>
        /// Bundle code.  This code forms the end part of the Public URL.
        /// </summary>
        [JsonPropertyName("code")]
        public string Code
        {
            get { return (string) attributes["code"]; }
            set { attributes["code"] = value; }
        }

        /// <summary>
        /// Public URL of Share Link
        /// </summary>
        [JsonPropertyName("url")]
        public string Url
        {
            get { return (string) attributes["url"]; }
            set { attributes["url"] = value; }
        }

        /// <summary>
        /// Public description
        /// </summary>
        [JsonPropertyName("description")]
        public string Description
        {
            get { return (string) attributes["description"]; }
            set { attributes["description"] = value; }
        }

        /// <summary>
        /// Is this bundle password protected?
        /// </summary>
        [JsonPropertyName("password_protected")]
        public bool PasswordProtected
        {
            get { return (bool) attributes["password_protected"]; }
            set { attributes["password_protected"] = value; }
        }

        /// <summary>
        /// Show a registration page that captures the downloader's name and email address?
        /// </summary>
        [JsonPropertyName("require_registration")]
        public bool RequireRegistration
        {
            get { return (bool) attributes["require_registration"]; }
            set { attributes["require_registration"] = value; }
        }

        /// <summary>
        /// Legal text that must be agreed to prior to accessing Bundle.
        /// </summary>
        [JsonPropertyName("clickwrap_body")]
        public string ClickwrapBody
        {
            get { return (string) attributes["clickwrap_body"]; }
            set { attributes["clickwrap_body"] = value; }
        }

        /// <summary>
        /// Bundle ID
        /// </summary>
        [JsonPropertyName("id")]
        public Nullable<Int64> Id
        {
            get { return (Nullable<Int64>) attributes["id"]; }
            set { attributes["id"] = value; }
        }

        /// <summary>
        /// Bundle created at date/time
        /// </summary>
        [JsonPropertyName("created_at")]
        public Nullable<DateTime> CreatedAt
        {
            get { return (Nullable<DateTime>) attributes["created_at"]; }
        }

        /// <summary>
        /// Bundle expiration date/time
        /// </summary>
        [JsonPropertyName("expires_at")]
        public Nullable<DateTime> ExpiresAt
        {
            get { return (Nullable<DateTime>) attributes["expires_at"]; }
            set { attributes["expires_at"] = value; }
        }

        /// <summary>
        /// Maximum number of times bundle can be accessed
        /// </summary>
        [JsonPropertyName("max_uses")]
        public Nullable<Int64> MaxUses
        {
            get { return (Nullable<Int64>) attributes["max_uses"]; }
            set { attributes["max_uses"] = value; }
        }

        /// <summary>
        /// Bundle internal note
        /// </summary>
        [JsonPropertyName("note")]
        public string Note
        {
            get { return (string) attributes["note"]; }
            set { attributes["note"] = value; }
        }

        /// <summary>
        /// Bundle creator user ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public Nullable<Int64> UserId
        {
            get { return (Nullable<Int64>) attributes["user_id"]; }
            set { attributes["user_id"] = value; }
        }

        /// <summary>
        /// Bundle creator username
        /// </summary>
        [JsonPropertyName("username")]
        public string Username
        {
            get { return (string) attributes["username"]; }
            set { attributes["username"] = value; }
        }

        /// <summary>
        /// ID of the clickwrap to use with this bundle.
        /// </summary>
        [JsonPropertyName("clickwrap_id")]
        public Nullable<Int64> ClickwrapId
        {
            get { return (Nullable<Int64>) attributes["clickwrap_id"]; }
            set { attributes["clickwrap_id"] = value; }
        }

        /// <summary>
        /// ID of the associated inbox, if available.
        /// </summary>
        [JsonPropertyName("inbox_id")]
        public Nullable<Int64> InboxId
        {
            get { return (Nullable<Int64>) attributes["inbox_id"]; }
            set { attributes["inbox_id"] = value; }
        }

        /// <summary>
        /// A list of paths in this bundle
        /// </summary>
        [JsonPropertyName("paths")]
        public string[] Paths
        {
            get { return (string[]) attributes["paths"]; }
            set { attributes["paths"] = value; }
        }

        /// <summary>
        /// Password for this bundle.
        /// </summary>
        [JsonPropertyName("password")]
        public string Password
        {
            get { return (string) attributes["password"]; }
            set { attributes["password"] = value; }
        }

        /// <summary>
        /// Send email(s) with a link to bundle
        ///
        /// Parameters:
        ///   to (required) - array(string) - A list of email addresses to share this bundle with.
        ///   note - string - Note to include in email.
        /// </summary>
        public async Task<Bundle> Share(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id")) {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("to") && !(parameters["to"] is string[] ))
            {
                throw new ArgumentException("Bad parameter: to must be of type string[]", "parameters[\"to\"]");
            }
            if (parameters.ContainsKey("note") && !(parameters["note"] is string ))
            {
                throw new ArgumentException("Bad parameter: note must be of type string", "parameters[\"note\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("to") || parameters["to"] == null)
            {
                throw new ArgumentNullException("Parameter missing: to", "parameters[\"to\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{attributes["id"]}/share", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }


        /// <summary>
        /// Parameters:
        ///   password - string - Password for this bundle.
        ///   expires_at - string - Bundle expiration date/time
        ///   max_uses - int64 - Maximum number of times bundle can be accessed
        ///   description - string - Public description
        ///   note - string - Bundle internal note
        ///   code - string - Bundle code.  This code forms the end part of the Public URL.
        ///   require_registration - boolean - Show a registration page that captures the downloader's name and email address?
        ///   clickwrap_id - int64 - ID of the clickwrap to use with this bundle.
        ///   inbox_id - int64 - ID of the associated inbox, if available.
        /// </summary>
        public async Task<Bundle> Update(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id")) {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("expires_at") && !(parameters["expires_at"] is string ))
            {
                throw new ArgumentException("Bad parameter: expires_at must be of type string", "parameters[\"expires_at\"]");
            }
            if (parameters.ContainsKey("max_uses") && !(parameters["max_uses"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_uses must be of type Nullable<Int64>", "parameters[\"max_uses\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string ))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("note") && !(parameters["note"] is string ))
            {
                throw new ArgumentException("Bad parameter: note must be of type string", "parameters[\"note\"]");
            }
            if (parameters.ContainsKey("code") && !(parameters["code"] is string ))
            {
                throw new ArgumentException("Bad parameter: code must be of type string", "parameters[\"code\"]");
            }
            if (parameters.ContainsKey("require_registration") && !(parameters["require_registration"] is bool ))
            {
                throw new ArgumentException("Bad parameter: require_registration must be of type bool", "parameters[\"require_registration\"]");
            }
            if (parameters.ContainsKey("clickwrap_id") && !(parameters["clickwrap_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: clickwrap_id must be of type Nullable<Int64>", "parameters[\"clickwrap_id\"]");
            }
            if (parameters.ContainsKey("inbox_id") && !(parameters["inbox_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: inbox_id must be of type Nullable<Int64>", "parameters[\"inbox_id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{attributes["id"]}", System.Net.Http.HttpMethod.Patch, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }


        /// <summary>
        /// </summary>
        public async Task<Bundle> Delete(Dictionary<string, object> parameters)
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            parameters["id"] = attributes["id"];

            if (!attributes.ContainsKey("id")) {
                throw new ArgumentException("Current object doesn't have a id");
            }
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{attributes["id"]}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }

        public async void Destroy(Dictionary<string, object> parameters)
        {
            Delete(parameters);
        }


        public async Task Save()
        {
            if (this.attributes["id"] != null)
            {
                await this.Update(this.attributes);
            }
            else
            {
                // TODO: Remove this cast after return types are implemented
                var newObj = (Bundle) await Bundle.Create(this.attributes, this.options);
                this.attributes = newObj.attributes;
            }
        }

        /// <summary>
        /// Parameters:
        ///   user_id - int64 - User ID.  Provide a value of `0` to operate the current session's user.
        ///   page - int64 - Current page number.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   action - string - Deprecated: If set to `count` returns a count of matching records rather than the records themselves.
        /// </summary>
        public static async Task<Bundle[]> List(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("user_id") && !(parameters["user_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: user_id must be of type Nullable<Int64>", "parameters[\"user_id\"]");
            }
            if (parameters.ContainsKey("page") && !(parameters["page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: page must be of type Nullable<Int64>", "parameters[\"page\"]");
            }
            if (parameters.ContainsKey("per_page") && !(parameters["per_page"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: per_page must be of type Nullable<Int64>", "parameters[\"per_page\"]");
            }
            if (parameters.ContainsKey("action") && !(parameters["action"] is string ))
            {
                throw new ArgumentException("Bad parameter: action must be of type string", "parameters[\"action\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<Bundle[]>(responseJson);
        }

        public static async Task<Bundle[]> All(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await List(parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   id (required) - int64 - Bundle ID.
        /// </summary>
        public static async Task<Bundle> Find(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{parameters["id"]}", System.Net.Http.HttpMethod.Get, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }

        public static async Task<Bundle> Get(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Find(id, parameters, options);
        }

        /// <summary>
        /// Parameters:
        ///   user_id - int64 - User ID.  Provide a value of `0` to operate the current session's user.
        ///   paths (required) - array(string) - A list of paths to include in this bundle.
        ///   password - string - Password for this bundle.
        ///   expires_at - string - Bundle expiration date/time
        ///   max_uses - int64 - Maximum number of times bundle can be accessed
        ///   description - string - Public description
        ///   note - string - Bundle internal note
        ///   code - string - Bundle code.  This code forms the end part of the Public URL.
        ///   require_registration - boolean - Show a registration page that captures the downloader's name and email address?
        ///   clickwrap_id - int64 - ID of the clickwrap to use with this bundle.
        ///   inbox_id - int64 - ID of the associated inbox, if available.
        /// </summary>
        public static async Task<Bundle> Create(
            
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("user_id") && !(parameters["user_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: user_id must be of type Nullable<Int64>", "parameters[\"user_id\"]");
            }
            if (parameters.ContainsKey("paths") && !(parameters["paths"] is string[] ))
            {
                throw new ArgumentException("Bad parameter: paths must be of type string[]", "parameters[\"paths\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("expires_at") && !(parameters["expires_at"] is string ))
            {
                throw new ArgumentException("Bad parameter: expires_at must be of type string", "parameters[\"expires_at\"]");
            }
            if (parameters.ContainsKey("max_uses") && !(parameters["max_uses"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_uses must be of type Nullable<Int64>", "parameters[\"max_uses\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string ))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("note") && !(parameters["note"] is string ))
            {
                throw new ArgumentException("Bad parameter: note must be of type string", "parameters[\"note\"]");
            }
            if (parameters.ContainsKey("code") && !(parameters["code"] is string ))
            {
                throw new ArgumentException("Bad parameter: code must be of type string", "parameters[\"code\"]");
            }
            if (parameters.ContainsKey("require_registration") && !(parameters["require_registration"] is bool ))
            {
                throw new ArgumentException("Bad parameter: require_registration must be of type bool", "parameters[\"require_registration\"]");
            }
            if (parameters.ContainsKey("clickwrap_id") && !(parameters["clickwrap_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: clickwrap_id must be of type Nullable<Int64>", "parameters[\"clickwrap_id\"]");
            }
            if (parameters.ContainsKey("inbox_id") && !(parameters["inbox_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: inbox_id must be of type Nullable<Int64>", "parameters[\"inbox_id\"]");
            }
            if (!parameters.ContainsKey("paths") || parameters["paths"] == null)
            {
                throw new ArgumentNullException("Parameter missing: paths", "parameters[\"paths\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }


        /// <summary>
        /// Send email(s) with a link to bundle
        ///
        /// Parameters:
        ///   to (required) - array(string) - A list of email addresses to share this bundle with.
        ///   note - string - Note to include in email.
        /// </summary>
        public static async Task<Bundle> Share(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("to") && !(parameters["to"] is string[] ))
            {
                throw new ArgumentException("Bad parameter: to must be of type string[]", "parameters[\"to\"]");
            }
            if (parameters.ContainsKey("note") && !(parameters["note"] is string ))
            {
                throw new ArgumentException("Bad parameter: note must be of type string", "parameters[\"note\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("to") || parameters["to"] == null)
            {
                throw new ArgumentNullException("Parameter missing: to", "parameters[\"to\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{parameters["id"]}/share", System.Net.Http.HttpMethod.Post, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }


        /// <summary>
        /// Parameters:
        ///   password - string - Password for this bundle.
        ///   expires_at - string - Bundle expiration date/time
        ///   max_uses - int64 - Maximum number of times bundle can be accessed
        ///   description - string - Public description
        ///   note - string - Bundle internal note
        ///   code - string - Bundle code.  This code forms the end part of the Public URL.
        ///   require_registration - boolean - Show a registration page that captures the downloader's name and email address?
        ///   clickwrap_id - int64 - ID of the clickwrap to use with this bundle.
        ///   inbox_id - int64 - ID of the associated inbox, if available.
        /// </summary>
        public static async Task<Bundle> Update(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (parameters.ContainsKey("password") && !(parameters["password"] is string ))
            {
                throw new ArgumentException("Bad parameter: password must be of type string", "parameters[\"password\"]");
            }
            if (parameters.ContainsKey("expires_at") && !(parameters["expires_at"] is string ))
            {
                throw new ArgumentException("Bad parameter: expires_at must be of type string", "parameters[\"expires_at\"]");
            }
            if (parameters.ContainsKey("max_uses") && !(parameters["max_uses"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: max_uses must be of type Nullable<Int64>", "parameters[\"max_uses\"]");
            }
            if (parameters.ContainsKey("description") && !(parameters["description"] is string ))
            {
                throw new ArgumentException("Bad parameter: description must be of type string", "parameters[\"description\"]");
            }
            if (parameters.ContainsKey("note") && !(parameters["note"] is string ))
            {
                throw new ArgumentException("Bad parameter: note must be of type string", "parameters[\"note\"]");
            }
            if (parameters.ContainsKey("code") && !(parameters["code"] is string ))
            {
                throw new ArgumentException("Bad parameter: code must be of type string", "parameters[\"code\"]");
            }
            if (parameters.ContainsKey("require_registration") && !(parameters["require_registration"] is bool ))
            {
                throw new ArgumentException("Bad parameter: require_registration must be of type bool", "parameters[\"require_registration\"]");
            }
            if (parameters.ContainsKey("clickwrap_id") && !(parameters["clickwrap_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: clickwrap_id must be of type Nullable<Int64>", "parameters[\"clickwrap_id\"]");
            }
            if (parameters.ContainsKey("inbox_id") && !(parameters["inbox_id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: inbox_id must be of type Nullable<Int64>", "parameters[\"inbox_id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{parameters["id"]}", System.Net.Http.HttpMethod.Patch, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }


        /// <summary>
        /// </summary>
        public static async Task<Bundle> Delete(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            parameters.Add("id", id);
            if (parameters.ContainsKey("id") && !(parameters["id"] is Nullable<Int64> ))
            {
                throw new ArgumentException("Bad parameter: id must be of type Nullable<Int64>", "parameters[\"id\"]");
            }
            if (!parameters.ContainsKey("id") || parameters["id"] == null)
            {
                throw new ArgumentNullException("Parameter missing: id", "parameters[\"id\"]");
            }

            string responseJson = await FilesClient.SendRequest($"/bundles/{parameters["id"]}", System.Net.Http.HttpMethod.Delete, parameters, options);

            return JsonSerializer.Deserialize<Bundle>(responseJson);
        }

        public static async Task<Bundle> Destroy(
            Nullable<Int64> id, 
            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return await Delete(id, parameters, options);
        }

    }
}

