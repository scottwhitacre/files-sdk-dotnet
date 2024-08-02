using FilesCom.Util;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FilesCom.Models
{
    public class ApiRequestLog
    {
        private Dictionary<string, object> attributes;
        private Dictionary<string, object> options;
        public ApiRequestLog() : this(null, null) { }

        public ApiRequestLog(Dictionary<string, object> attributes, Dictionary<string, object> options)
        {
            this.attributes = attributes;
            this.options = options;

            if (this.attributes == null)
            {
                this.attributes = new Dictionary<string, object>();
            }

            if (this.options == null)
            {
                this.options = new Dictionary<string, object>();
            }

            if (!this.attributes.ContainsKey("timestamp"))
            {
                this.attributes.Add("timestamp", null);
            }
            if (!this.attributes.ContainsKey("api_key_id"))
            {
                this.attributes.Add("api_key_id", null);
            }
            if (!this.attributes.ContainsKey("api_key_prefix"))
            {
                this.attributes.Add("api_key_prefix", null);
            }
            if (!this.attributes.ContainsKey("user_id"))
            {
                this.attributes.Add("user_id", null);
            }
            if (!this.attributes.ContainsKey("username"))
            {
                this.attributes.Add("username", null);
            }
            if (!this.attributes.ContainsKey("user_is_from_parent_site"))
            {
                this.attributes.Add("user_is_from_parent_site", false);
            }
            if (!this.attributes.ContainsKey("interface"))
            {
                this.attributes.Add("interface", null);
            }
            if (!this.attributes.ContainsKey("request_method"))
            {
                this.attributes.Add("request_method", null);
            }
            if (!this.attributes.ContainsKey("request_path"))
            {
                this.attributes.Add("request_path", null);
            }
            if (!this.attributes.ContainsKey("request_ip"))
            {
                this.attributes.Add("request_ip", null);
            }
            if (!this.attributes.ContainsKey("request_host"))
            {
                this.attributes.Add("request_host", null);
            }
            if (!this.attributes.ContainsKey("request_id"))
            {
                this.attributes.Add("request_id", null);
            }
            if (!this.attributes.ContainsKey("api_name"))
            {
                this.attributes.Add("api_name", null);
            }
            if (!this.attributes.ContainsKey("user_agent"))
            {
                this.attributes.Add("user_agent", null);
            }
            if (!this.attributes.ContainsKey("error_type"))
            {
                this.attributes.Add("error_type", null);
            }
            if (!this.attributes.ContainsKey("error_message"))
            {
                this.attributes.Add("error_message", null);
            }
            if (!this.attributes.ContainsKey("response_code"))
            {
                this.attributes.Add("response_code", null);
            }
            if (!this.attributes.ContainsKey("success"))
            {
                this.attributes.Add("success", false);
            }
            if (!this.attributes.ContainsKey("duration_ms"))
            {
                this.attributes.Add("duration_ms", null);
            }
        }

        public Dictionary<string, object> getAttributes()
        {
            return new Dictionary<string, object>(this.attributes);
        }

        public object GetOption(string name)
        {
            return (this.options.ContainsKey(name) ? this.options[name] : null);
        }

        public void SetOption(string name, object value)
        {
            this.options[name] = value;
        }


        /// <summary>
        /// Start Time of Action
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("timestamp")]
        public Nullable<DateTime> Timestamp
        {
            get { return (Nullable<DateTime>)attributes["timestamp"]; }
            private set { attributes["timestamp"] = value; }
        }

        /// <summary>
        /// API Key ID, if applicable
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("api_key_id")]
        public Nullable<Int64> ApiKeyId
        {
            get { return (Nullable<Int64>)attributes["api_key_id"]; }
            private set { attributes["api_key_id"] = value; }
        }

        /// <summary>
        /// API Key Prefix, if applicable
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("api_key_prefix")]
        public string ApiKeyPrefix
        {
            get { return (string)attributes["api_key_prefix"]; }
            private set { attributes["api_key_prefix"] = value; }
        }

        /// <summary>
        /// User ID
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("user_id")]
        public Nullable<Int64> UserId
        {
            get { return (Nullable<Int64>)attributes["user_id"]; }
            private set { attributes["user_id"] = value; }
        }

        /// <summary>
        /// Username
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("username")]
        public string Username
        {
            get { return (string)attributes["username"]; }
            private set { attributes["username"] = value; }
        }

        /// <summary>
        /// true if this change was performed by a user on a parent site.
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(BooleanJsonConverter))]
        [JsonPropertyName("user_is_from_parent_site")]
        public bool UserIsFromParentSite
        {
            get { return attributes["user_is_from_parent_site"] == null ? false : (bool)attributes["user_is_from_parent_site"]; }
            private set { attributes["user_is_from_parent_site"] = value; }
        }

        /// <summary>
        /// API Interface
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("interface")]
        public string Interface
        {
            get { return (string)attributes["interface"]; }
            private set { attributes["interface"] = value; }
        }

        /// <summary>
        /// HTTP Method
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("request_method")]
        public string RequestMethod
        {
            get { return (string)attributes["request_method"]; }
            private set { attributes["request_method"] = value; }
        }

        /// <summary>
        /// Request path
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("request_path")]
        public string RequestPath
        {
            get { return (string)attributes["request_path"]; }
            private set { attributes["request_path"] = value; }
        }

        /// <summary>
        /// IP of requesting client
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("request_ip")]
        public string RequestIp
        {
            get { return (string)attributes["request_ip"]; }
            private set { attributes["request_ip"] = value; }
        }

        /// <summary>
        /// Hostname the request was sent to
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("request_host")]
        public string RequestHost
        {
            get { return (string)attributes["request_host"]; }
            private set { attributes["request_host"] = value; }
        }

        /// <summary>
        /// Unique Id of the Request
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("request_id")]
        public string RequestId
        {
            get { return (string)attributes["request_id"]; }
            private set { attributes["request_id"] = value; }
        }

        /// <summary>
        /// Name of API Endpoint
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("api_name")]
        public string ApiName
        {
            get { return (string)attributes["api_name"]; }
            private set { attributes["api_name"] = value; }
        }

        /// <summary>
        /// User-Agent
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("user_agent")]
        public string UserAgent
        {
            get { return (string)attributes["user_agent"]; }
            private set { attributes["user_agent"] = value; }
        }

        /// <summary>
        /// Error type, if applicable
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("error_type")]
        public string ErrorType
        {
            get { return (string)attributes["error_type"]; }
            private set { attributes["error_type"] = value; }
        }

        /// <summary>
        /// Error message, if applicable
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("error_message")]
        public string ErrorMessage
        {
            get { return (string)attributes["error_message"]; }
            private set { attributes["error_message"] = value; }
        }

        /// <summary>
        /// HTTP Response Code
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("response_code")]
        public Nullable<Int64> ResponseCode
        {
            get { return (Nullable<Int64>)attributes["response_code"]; }
            private set { attributes["response_code"] = value; }
        }

        /// <summary>
        /// `false` if HTTP Response Code is 4xx or 5xx
        /// </summary>
        [JsonInclude]
        [JsonConverter(typeof(BooleanJsonConverter))]
        [JsonPropertyName("success")]
        public bool Success
        {
            get { return attributes["success"] == null ? false : (bool)attributes["success"]; }
            private set { attributes["success"] = value; }
        }

        /// <summary>
        /// Duration (in milliseconds)
        /// </summary>
        [JsonInclude]
        [JsonPropertyName("duration_ms")]
        public Nullable<Int64> DurationMs
        {
            get { return (Nullable<Int64>)attributes["duration_ms"]; }
            private set { attributes["duration_ms"] = value; }
        }



        /// <summary>
        /// Parameters:
        ///   cursor - string - Used for pagination.  When a list request has more records available, cursors are provided in the response headers `X-Files-Cursor-Next` and `X-Files-Cursor-Prev`.  Send one of those cursor value here to resume an existing list from the next available record.  Note: many of our SDKs have iterator methods that will automatically handle cursor-based pagination.
        ///   per_page - int64 - Number of records to show per page.  (Max: 10,000, 1,000 or less is recommended).
        ///   action - string
        ///   page - int64
        ///   filter - object - If set, return records where the specified field is equal to the supplied value. Valid fields are `start_date`, `end_date`, `api_key_id`, `interface`, `request_id`, `request_ip`, `request_method`, `success` or `user_id`. Valid field combinations are `[ start_date ]`, `[ end_date ]`, `[ api_key_id ]`, `[ interface ]`, `[ request_id ]`, `[ request_ip ]`, `[ request_method ]`, `[ success ]`, `[ user_id ]`, `[ start_date, end_date ]`, `[ start_date, api_key_id ]`, `[ start_date, interface ]`, `[ start_date, request_id ]`, `[ start_date, request_ip ]`, `[ start_date, request_method ]`, `[ start_date, success ]`, `[ start_date, user_id ]`, `[ end_date, api_key_id ]`, `[ end_date, interface ]`, `[ end_date, request_id ]`, `[ end_date, request_ip ]`, `[ end_date, request_method ]`, `[ end_date, success ]`, `[ end_date, user_id ]`, `[ api_key_id, interface ]`, `[ api_key_id, request_id ]`, `[ api_key_id, request_ip ]`, `[ api_key_id, request_method ]`, `[ api_key_id, success ]`, `[ api_key_id, user_id ]`, `[ interface, request_id ]`, `[ interface, request_ip ]`, `[ interface, request_method ]`, `[ interface, success ]`, `[ interface, user_id ]`, `[ request_id, request_ip ]`, `[ request_id, request_method ]`, `[ request_id, success ]`, `[ request_id, user_id ]`, `[ request_ip, request_method ]`, `[ request_ip, success ]`, `[ request_ip, user_id ]`, `[ request_method, success ]`, `[ request_method, user_id ]`, `[ success, user_id ]`, `[ start_date, end_date, api_key_id ]`, `[ start_date, end_date, interface ]`, `[ start_date, end_date, request_id ]`, `[ start_date, end_date, request_ip ]`, `[ start_date, end_date, request_method ]`, `[ start_date, end_date, success ]`, `[ start_date, end_date, user_id ]`, `[ start_date, api_key_id, interface ]`, `[ start_date, api_key_id, request_id ]`, `[ start_date, api_key_id, request_ip ]`, `[ start_date, api_key_id, request_method ]`, `[ start_date, api_key_id, success ]`, `[ start_date, api_key_id, user_id ]`, `[ start_date, interface, request_id ]`, `[ start_date, interface, request_ip ]`, `[ start_date, interface, request_method ]`, `[ start_date, interface, success ]`, `[ start_date, interface, user_id ]`, `[ start_date, request_id, request_ip ]`, `[ start_date, request_id, request_method ]`, `[ start_date, request_id, success ]`, `[ start_date, request_id, user_id ]`, `[ start_date, request_ip, request_method ]`, `[ start_date, request_ip, success ]`, `[ start_date, request_ip, user_id ]`, `[ start_date, request_method, success ]`, `[ start_date, request_method, user_id ]`, `[ start_date, success, user_id ]`, `[ end_date, api_key_id, interface ]`, `[ end_date, api_key_id, request_id ]`, `[ end_date, api_key_id, request_ip ]`, `[ end_date, api_key_id, request_method ]`, `[ end_date, api_key_id, success ]`, `[ end_date, api_key_id, user_id ]`, `[ end_date, interface, request_id ]`, `[ end_date, interface, request_ip ]`, `[ end_date, interface, request_method ]`, `[ end_date, interface, success ]`, `[ end_date, interface, user_id ]`, `[ end_date, request_id, request_ip ]`, `[ end_date, request_id, request_method ]`, `[ end_date, request_id, success ]`, `[ end_date, request_id, user_id ]`, `[ end_date, request_ip, request_method ]`, `[ end_date, request_ip, success ]`, `[ end_date, request_ip, user_id ]`, `[ end_date, request_method, success ]`, `[ end_date, request_method, user_id ]`, `[ end_date, success, user_id ]`, `[ api_key_id, interface, request_id ]`, `[ api_key_id, interface, request_ip ]`, `[ api_key_id, interface, request_method ]`, `[ api_key_id, interface, success ]`, `[ api_key_id, interface, user_id ]`, `[ api_key_id, request_id, request_ip ]`, `[ api_key_id, request_id, request_method ]`, `[ api_key_id, request_id, success ]`, `[ api_key_id, request_id, user_id ]`, `[ api_key_id, request_ip, request_method ]`, `[ api_key_id, request_ip, success ]`, `[ api_key_id, request_ip, user_id ]`, `[ api_key_id, request_method, success ]`, `[ api_key_id, request_method, user_id ]`, `[ api_key_id, success, user_id ]`, `[ interface, request_id, request_ip ]`, `[ interface, request_id, request_method ]`, `[ interface, request_id, success ]`, `[ interface, request_id, user_id ]`, `[ interface, request_ip, request_method ]`, `[ interface, request_ip, success ]`, `[ interface, request_ip, user_id ]`, `[ interface, request_method, success ]`, `[ interface, request_method, user_id ]`, `[ interface, success, user_id ]`, `[ request_id, request_ip, request_method ]`, `[ request_id, request_ip, success ]`, `[ request_id, request_ip, user_id ]`, `[ request_id, request_method, success ]`, `[ request_id, request_method, user_id ]`, `[ request_id, success, user_id ]`, `[ request_ip, request_method, success ]`, `[ request_ip, request_method, user_id ]`, `[ request_ip, success, user_id ]`, `[ request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface ]`, `[ start_date, end_date, api_key_id, request_id ]`, `[ start_date, end_date, api_key_id, request_ip ]`, `[ start_date, end_date, api_key_id, request_method ]`, `[ start_date, end_date, api_key_id, success ]`, `[ start_date, end_date, api_key_id, user_id ]`, `[ start_date, end_date, interface, request_id ]`, `[ start_date, end_date, interface, request_ip ]`, `[ start_date, end_date, interface, request_method ]`, `[ start_date, end_date, interface, success ]`, `[ start_date, end_date, interface, user_id ]`, `[ start_date, end_date, request_id, request_ip ]`, `[ start_date, end_date, request_id, request_method ]`, `[ start_date, end_date, request_id, success ]`, `[ start_date, end_date, request_id, user_id ]`, `[ start_date, end_date, request_ip, request_method ]`, `[ start_date, end_date, request_ip, success ]`, `[ start_date, end_date, request_ip, user_id ]`, `[ start_date, end_date, request_method, success ]`, `[ start_date, end_date, request_method, user_id ]`, `[ start_date, end_date, success, user_id ]`, `[ start_date, api_key_id, interface, request_id ]`, `[ start_date, api_key_id, interface, request_ip ]`, `[ start_date, api_key_id, interface, request_method ]`, `[ start_date, api_key_id, interface, success ]`, `[ start_date, api_key_id, interface, user_id ]`, `[ start_date, api_key_id, request_id, request_ip ]`, `[ start_date, api_key_id, request_id, request_method ]`, `[ start_date, api_key_id, request_id, success ]`, `[ start_date, api_key_id, request_id, user_id ]`, `[ start_date, api_key_id, request_ip, request_method ]`, `[ start_date, api_key_id, request_ip, success ]`, `[ start_date, api_key_id, request_ip, user_id ]`, `[ start_date, api_key_id, request_method, success ]`, `[ start_date, api_key_id, request_method, user_id ]`, `[ start_date, api_key_id, success, user_id ]`, `[ start_date, interface, request_id, request_ip ]`, `[ start_date, interface, request_id, request_method ]`, `[ start_date, interface, request_id, success ]`, `[ start_date, interface, request_id, user_id ]`, `[ start_date, interface, request_ip, request_method ]`, `[ start_date, interface, request_ip, success ]`, `[ start_date, interface, request_ip, user_id ]`, `[ start_date, interface, request_method, success ]`, `[ start_date, interface, request_method, user_id ]`, `[ start_date, interface, success, user_id ]`, `[ start_date, request_id, request_ip, request_method ]`, `[ start_date, request_id, request_ip, success ]`, `[ start_date, request_id, request_ip, user_id ]`, `[ start_date, request_id, request_method, success ]`, `[ start_date, request_id, request_method, user_id ]`, `[ start_date, request_id, success, user_id ]`, `[ start_date, request_ip, request_method, success ]`, `[ start_date, request_ip, request_method, user_id ]`, `[ start_date, request_ip, success, user_id ]`, `[ start_date, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id ]`, `[ end_date, api_key_id, interface, request_ip ]`, `[ end_date, api_key_id, interface, request_method ]`, `[ end_date, api_key_id, interface, success ]`, `[ end_date, api_key_id, interface, user_id ]`, `[ end_date, api_key_id, request_id, request_ip ]`, `[ end_date, api_key_id, request_id, request_method ]`, `[ end_date, api_key_id, request_id, success ]`, `[ end_date, api_key_id, request_id, user_id ]`, `[ end_date, api_key_id, request_ip, request_method ]`, `[ end_date, api_key_id, request_ip, success ]`, `[ end_date, api_key_id, request_ip, user_id ]`, `[ end_date, api_key_id, request_method, success ]`, `[ end_date, api_key_id, request_method, user_id ]`, `[ end_date, api_key_id, success, user_id ]`, `[ end_date, interface, request_id, request_ip ]`, `[ end_date, interface, request_id, request_method ]`, `[ end_date, interface, request_id, success ]`, `[ end_date, interface, request_id, user_id ]`, `[ end_date, interface, request_ip, request_method ]`, `[ end_date, interface, request_ip, success ]`, `[ end_date, interface, request_ip, user_id ]`, `[ end_date, interface, request_method, success ]`, `[ end_date, interface, request_method, user_id ]`, `[ end_date, interface, success, user_id ]`, `[ end_date, request_id, request_ip, request_method ]`, `[ end_date, request_id, request_ip, success ]`, `[ end_date, request_id, request_ip, user_id ]`, `[ end_date, request_id, request_method, success ]`, `[ end_date, request_id, request_method, user_id ]`, `[ end_date, request_id, success, user_id ]`, `[ end_date, request_ip, request_method, success ]`, `[ end_date, request_ip, request_method, user_id ]`, `[ end_date, request_ip, success, user_id ]`, `[ end_date, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip ]`, `[ api_key_id, interface, request_id, request_method ]`, `[ api_key_id, interface, request_id, success ]`, `[ api_key_id, interface, request_id, user_id ]`, `[ api_key_id, interface, request_ip, request_method ]`, `[ api_key_id, interface, request_ip, success ]`, `[ api_key_id, interface, request_ip, user_id ]`, `[ api_key_id, interface, request_method, success ]`, `[ api_key_id, interface, request_method, user_id ]`, `[ api_key_id, interface, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method ]`, `[ api_key_id, request_id, request_ip, success ]`, `[ api_key_id, request_id, request_ip, user_id ]`, `[ api_key_id, request_id, request_method, success ]`, `[ api_key_id, request_id, request_method, user_id ]`, `[ api_key_id, request_id, success, user_id ]`, `[ api_key_id, request_ip, request_method, success ]`, `[ api_key_id, request_ip, request_method, user_id ]`, `[ api_key_id, request_ip, success, user_id ]`, `[ api_key_id, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method ]`, `[ interface, request_id, request_ip, success ]`, `[ interface, request_id, request_ip, user_id ]`, `[ interface, request_id, request_method, success ]`, `[ interface, request_id, request_method, user_id ]`, `[ interface, request_id, success, user_id ]`, `[ interface, request_ip, request_method, success ]`, `[ interface, request_ip, request_method, user_id ]`, `[ interface, request_ip, success, user_id ]`, `[ interface, request_method, success, user_id ]`, `[ request_id, request_ip, request_method, success ]`, `[ request_id, request_ip, request_method, user_id ]`, `[ request_id, request_ip, success, user_id ]`, `[ request_id, request_method, success, user_id ]`, `[ request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip ]`, `[ start_date, end_date, api_key_id, interface, request_method ]`, `[ start_date, end_date, api_key_id, interface, success ]`, `[ start_date, end_date, api_key_id, interface, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip ]`, `[ start_date, end_date, api_key_id, request_id, request_method ]`, `[ start_date, end_date, api_key_id, request_id, success ]`, `[ start_date, end_date, api_key_id, request_id, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, request_method, success ]`, `[ start_date, end_date, api_key_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip ]`, `[ start_date, end_date, interface, request_id, request_method ]`, `[ start_date, end_date, interface, request_id, success ]`, `[ start_date, end_date, interface, request_id, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method ]`, `[ start_date, end_date, interface, request_ip, success ]`, `[ start_date, end_date, interface, request_ip, user_id ]`, `[ start_date, end_date, interface, request_method, success ]`, `[ start_date, end_date, interface, request_method, user_id ]`, `[ start_date, end_date, interface, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method ]`, `[ start_date, end_date, request_id, request_ip, success ]`, `[ start_date, end_date, request_id, request_ip, user_id ]`, `[ start_date, end_date, request_id, request_method, success ]`, `[ start_date, end_date, request_id, request_method, user_id ]`, `[ start_date, end_date, request_id, success, user_id ]`, `[ start_date, end_date, request_ip, request_method, success ]`, `[ start_date, end_date, request_ip, request_method, user_id ]`, `[ start_date, end_date, request_ip, success, user_id ]`, `[ start_date, end_date, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip ]`, `[ start_date, api_key_id, interface, request_id, request_method ]`, `[ start_date, api_key_id, interface, request_id, success ]`, `[ start_date, api_key_id, interface, request_id, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method ]`, `[ start_date, api_key_id, interface, request_ip, success ]`, `[ start_date, api_key_id, interface, request_ip, user_id ]`, `[ start_date, api_key_id, interface, request_method, success ]`, `[ start_date, api_key_id, interface, request_method, user_id ]`, `[ start_date, api_key_id, interface, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method ]`, `[ start_date, api_key_id, request_id, request_ip, success ]`, `[ start_date, api_key_id, request_id, request_ip, user_id ]`, `[ start_date, api_key_id, request_id, request_method, success ]`, `[ start_date, api_key_id, request_id, request_method, user_id ]`, `[ start_date, api_key_id, request_id, success, user_id ]`, `[ start_date, api_key_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method ]`, `[ start_date, interface, request_id, request_ip, success ]`, `[ start_date, interface, request_id, request_ip, user_id ]`, `[ start_date, interface, request_id, request_method, success ]`, `[ start_date, interface, request_id, request_method, user_id ]`, `[ start_date, interface, request_id, success, user_id ]`, `[ start_date, interface, request_ip, request_method, success ]`, `[ start_date, interface, request_ip, request_method, user_id ]`, `[ start_date, interface, request_ip, success, user_id ]`, `[ start_date, interface, request_method, success, user_id ]`, `[ start_date, request_id, request_ip, request_method, success ]`, `[ start_date, request_id, request_ip, request_method, user_id ]`, `[ start_date, request_id, request_ip, success, user_id ]`, `[ start_date, request_id, request_method, success, user_id ]`, `[ start_date, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip ]`, `[ end_date, api_key_id, interface, request_id, request_method ]`, `[ end_date, api_key_id, interface, request_id, success ]`, `[ end_date, api_key_id, interface, request_id, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method ]`, `[ end_date, api_key_id, interface, request_ip, success ]`, `[ end_date, api_key_id, interface, request_ip, user_id ]`, `[ end_date, api_key_id, interface, request_method, success ]`, `[ end_date, api_key_id, interface, request_method, user_id ]`, `[ end_date, api_key_id, interface, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method ]`, `[ end_date, api_key_id, request_id, request_ip, success ]`, `[ end_date, api_key_id, request_id, request_ip, user_id ]`, `[ end_date, api_key_id, request_id, request_method, success ]`, `[ end_date, api_key_id, request_id, request_method, user_id ]`, `[ end_date, api_key_id, request_id, success, user_id ]`, `[ end_date, api_key_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method ]`, `[ end_date, interface, request_id, request_ip, success ]`, `[ end_date, interface, request_id, request_ip, user_id ]`, `[ end_date, interface, request_id, request_method, success ]`, `[ end_date, interface, request_id, request_method, user_id ]`, `[ end_date, interface, request_id, success, user_id ]`, `[ end_date, interface, request_ip, request_method, success ]`, `[ end_date, interface, request_ip, request_method, user_id ]`, `[ end_date, interface, request_ip, success, user_id ]`, `[ end_date, interface, request_method, success, user_id ]`, `[ end_date, request_id, request_ip, request_method, success ]`, `[ end_date, request_id, request_ip, request_method, user_id ]`, `[ end_date, request_id, request_ip, success, user_id ]`, `[ end_date, request_id, request_method, success, user_id ]`, `[ end_date, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method ]`, `[ api_key_id, interface, request_id, request_ip, success ]`, `[ api_key_id, interface, request_id, request_ip, user_id ]`, `[ api_key_id, interface, request_id, request_method, success ]`, `[ api_key_id, interface, request_id, request_method, user_id ]`, `[ api_key_id, interface, request_id, success, user_id ]`, `[ api_key_id, interface, request_ip, request_method, success ]`, `[ api_key_id, interface, request_ip, request_method, user_id ]`, `[ api_key_id, interface, request_ip, success, user_id ]`, `[ api_key_id, interface, request_method, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method, success ]`, `[ api_key_id, request_id, request_ip, request_method, user_id ]`, `[ api_key_id, request_id, request_ip, success, user_id ]`, `[ api_key_id, request_id, request_method, success, user_id ]`, `[ api_key_id, request_ip, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method, success ]`, `[ interface, request_id, request_ip, request_method, user_id ]`, `[ interface, request_id, request_ip, success, user_id ]`, `[ interface, request_id, request_method, success, user_id ]`, `[ interface, request_ip, request_method, success, user_id ]`, `[ request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_id, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_ip, success ]`, `[ start_date, end_date, api_key_id, interface, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_method, success ]`, `[ start_date, end_date, api_key_id, request_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_id, success, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method ]`, `[ start_date, end_date, interface, request_id, request_ip, success ]`, `[ start_date, end_date, interface, request_id, request_ip, user_id ]`, `[ start_date, end_date, interface, request_id, request_method, success ]`, `[ start_date, end_date, interface, request_id, request_method, user_id ]`, `[ start_date, end_date, interface, request_id, success, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method, success ]`, `[ start_date, end_date, interface, request_ip, request_method, user_id ]`, `[ start_date, end_date, interface, request_ip, success, user_id ]`, `[ start_date, end_date, interface, request_method, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, request_id, request_method, success, user_id ]`, `[ start_date, end_date, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ start_date, api_key_id, interface, request_id, request_ip, success ]`, `[ start_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_method, success ]`, `[ start_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_id, success, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method, success ]`, `[ start_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_ip, success, user_id ]`, `[ start_date, api_key_id, interface, request_method, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, request_id, request_method, success, user_id ]`, `[ start_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method, success ]`, `[ start_date, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, interface, request_id, request_ip, success, user_id ]`, `[ start_date, interface, request_id, request_method, success, user_id ]`, `[ start_date, interface, request_ip, request_method, success, user_id ]`, `[ start_date, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ end_date, api_key_id, interface, request_id, request_ip, success ]`, `[ end_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_method, success ]`, `[ end_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_id, success, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method, success ]`, `[ end_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_ip, success, user_id ]`, `[ end_date, api_key_id, interface, request_method, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, request_id, request_method, success, user_id ]`, `[ end_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method, success ]`, `[ end_date, interface, request_id, request_ip, request_method, user_id ]`, `[ end_date, interface, request_id, request_ip, success, user_id ]`, `[ end_date, interface, request_id, request_method, success, user_id ]`, `[ end_date, interface, request_ip, request_method, success, user_id ]`, `[ end_date, request_id, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ api_key_id, interface, request_id, request_method, success, user_id ]`, `[ api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, success, user_id ]` or `[ end_date, api_key_id, interface, request_id, request_ip, request_method, success, user_id ]`.
        ///   filter_prefix - object - If set, return records where the specified field is prefixed by the supplied value. Valid fields are `interface`, `request_id`, `request_ip` or `request_method`. Valid field combinations are `[ start_date ]`, `[ end_date ]`, `[ api_key_id ]`, `[ interface ]`, `[ request_id ]`, `[ request_ip ]`, `[ request_method ]`, `[ success ]`, `[ user_id ]`, `[ start_date, end_date ]`, `[ start_date, api_key_id ]`, `[ start_date, interface ]`, `[ start_date, request_id ]`, `[ start_date, request_ip ]`, `[ start_date, request_method ]`, `[ start_date, success ]`, `[ start_date, user_id ]`, `[ end_date, api_key_id ]`, `[ end_date, interface ]`, `[ end_date, request_id ]`, `[ end_date, request_ip ]`, `[ end_date, request_method ]`, `[ end_date, success ]`, `[ end_date, user_id ]`, `[ api_key_id, interface ]`, `[ api_key_id, request_id ]`, `[ api_key_id, request_ip ]`, `[ api_key_id, request_method ]`, `[ api_key_id, success ]`, `[ api_key_id, user_id ]`, `[ interface, request_id ]`, `[ interface, request_ip ]`, `[ interface, request_method ]`, `[ interface, success ]`, `[ interface, user_id ]`, `[ request_id, request_ip ]`, `[ request_id, request_method ]`, `[ request_id, success ]`, `[ request_id, user_id ]`, `[ request_ip, request_method ]`, `[ request_ip, success ]`, `[ request_ip, user_id ]`, `[ request_method, success ]`, `[ request_method, user_id ]`, `[ success, user_id ]`, `[ start_date, end_date, api_key_id ]`, `[ start_date, end_date, interface ]`, `[ start_date, end_date, request_id ]`, `[ start_date, end_date, request_ip ]`, `[ start_date, end_date, request_method ]`, `[ start_date, end_date, success ]`, `[ start_date, end_date, user_id ]`, `[ start_date, api_key_id, interface ]`, `[ start_date, api_key_id, request_id ]`, `[ start_date, api_key_id, request_ip ]`, `[ start_date, api_key_id, request_method ]`, `[ start_date, api_key_id, success ]`, `[ start_date, api_key_id, user_id ]`, `[ start_date, interface, request_id ]`, `[ start_date, interface, request_ip ]`, `[ start_date, interface, request_method ]`, `[ start_date, interface, success ]`, `[ start_date, interface, user_id ]`, `[ start_date, request_id, request_ip ]`, `[ start_date, request_id, request_method ]`, `[ start_date, request_id, success ]`, `[ start_date, request_id, user_id ]`, `[ start_date, request_ip, request_method ]`, `[ start_date, request_ip, success ]`, `[ start_date, request_ip, user_id ]`, `[ start_date, request_method, success ]`, `[ start_date, request_method, user_id ]`, `[ start_date, success, user_id ]`, `[ end_date, api_key_id, interface ]`, `[ end_date, api_key_id, request_id ]`, `[ end_date, api_key_id, request_ip ]`, `[ end_date, api_key_id, request_method ]`, `[ end_date, api_key_id, success ]`, `[ end_date, api_key_id, user_id ]`, `[ end_date, interface, request_id ]`, `[ end_date, interface, request_ip ]`, `[ end_date, interface, request_method ]`, `[ end_date, interface, success ]`, `[ end_date, interface, user_id ]`, `[ end_date, request_id, request_ip ]`, `[ end_date, request_id, request_method ]`, `[ end_date, request_id, success ]`, `[ end_date, request_id, user_id ]`, `[ end_date, request_ip, request_method ]`, `[ end_date, request_ip, success ]`, `[ end_date, request_ip, user_id ]`, `[ end_date, request_method, success ]`, `[ end_date, request_method, user_id ]`, `[ end_date, success, user_id ]`, `[ api_key_id, interface, request_id ]`, `[ api_key_id, interface, request_ip ]`, `[ api_key_id, interface, request_method ]`, `[ api_key_id, interface, success ]`, `[ api_key_id, interface, user_id ]`, `[ api_key_id, request_id, request_ip ]`, `[ api_key_id, request_id, request_method ]`, `[ api_key_id, request_id, success ]`, `[ api_key_id, request_id, user_id ]`, `[ api_key_id, request_ip, request_method ]`, `[ api_key_id, request_ip, success ]`, `[ api_key_id, request_ip, user_id ]`, `[ api_key_id, request_method, success ]`, `[ api_key_id, request_method, user_id ]`, `[ api_key_id, success, user_id ]`, `[ interface, request_id, request_ip ]`, `[ interface, request_id, request_method ]`, `[ interface, request_id, success ]`, `[ interface, request_id, user_id ]`, `[ interface, request_ip, request_method ]`, `[ interface, request_ip, success ]`, `[ interface, request_ip, user_id ]`, `[ interface, request_method, success ]`, `[ interface, request_method, user_id ]`, `[ interface, success, user_id ]`, `[ request_id, request_ip, request_method ]`, `[ request_id, request_ip, success ]`, `[ request_id, request_ip, user_id ]`, `[ request_id, request_method, success ]`, `[ request_id, request_method, user_id ]`, `[ request_id, success, user_id ]`, `[ request_ip, request_method, success ]`, `[ request_ip, request_method, user_id ]`, `[ request_ip, success, user_id ]`, `[ request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface ]`, `[ start_date, end_date, api_key_id, request_id ]`, `[ start_date, end_date, api_key_id, request_ip ]`, `[ start_date, end_date, api_key_id, request_method ]`, `[ start_date, end_date, api_key_id, success ]`, `[ start_date, end_date, api_key_id, user_id ]`, `[ start_date, end_date, interface, request_id ]`, `[ start_date, end_date, interface, request_ip ]`, `[ start_date, end_date, interface, request_method ]`, `[ start_date, end_date, interface, success ]`, `[ start_date, end_date, interface, user_id ]`, `[ start_date, end_date, request_id, request_ip ]`, `[ start_date, end_date, request_id, request_method ]`, `[ start_date, end_date, request_id, success ]`, `[ start_date, end_date, request_id, user_id ]`, `[ start_date, end_date, request_ip, request_method ]`, `[ start_date, end_date, request_ip, success ]`, `[ start_date, end_date, request_ip, user_id ]`, `[ start_date, end_date, request_method, success ]`, `[ start_date, end_date, request_method, user_id ]`, `[ start_date, end_date, success, user_id ]`, `[ start_date, api_key_id, interface, request_id ]`, `[ start_date, api_key_id, interface, request_ip ]`, `[ start_date, api_key_id, interface, request_method ]`, `[ start_date, api_key_id, interface, success ]`, `[ start_date, api_key_id, interface, user_id ]`, `[ start_date, api_key_id, request_id, request_ip ]`, `[ start_date, api_key_id, request_id, request_method ]`, `[ start_date, api_key_id, request_id, success ]`, `[ start_date, api_key_id, request_id, user_id ]`, `[ start_date, api_key_id, request_ip, request_method ]`, `[ start_date, api_key_id, request_ip, success ]`, `[ start_date, api_key_id, request_ip, user_id ]`, `[ start_date, api_key_id, request_method, success ]`, `[ start_date, api_key_id, request_method, user_id ]`, `[ start_date, api_key_id, success, user_id ]`, `[ start_date, interface, request_id, request_ip ]`, `[ start_date, interface, request_id, request_method ]`, `[ start_date, interface, request_id, success ]`, `[ start_date, interface, request_id, user_id ]`, `[ start_date, interface, request_ip, request_method ]`, `[ start_date, interface, request_ip, success ]`, `[ start_date, interface, request_ip, user_id ]`, `[ start_date, interface, request_method, success ]`, `[ start_date, interface, request_method, user_id ]`, `[ start_date, interface, success, user_id ]`, `[ start_date, request_id, request_ip, request_method ]`, `[ start_date, request_id, request_ip, success ]`, `[ start_date, request_id, request_ip, user_id ]`, `[ start_date, request_id, request_method, success ]`, `[ start_date, request_id, request_method, user_id ]`, `[ start_date, request_id, success, user_id ]`, `[ start_date, request_ip, request_method, success ]`, `[ start_date, request_ip, request_method, user_id ]`, `[ start_date, request_ip, success, user_id ]`, `[ start_date, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id ]`, `[ end_date, api_key_id, interface, request_ip ]`, `[ end_date, api_key_id, interface, request_method ]`, `[ end_date, api_key_id, interface, success ]`, `[ end_date, api_key_id, interface, user_id ]`, `[ end_date, api_key_id, request_id, request_ip ]`, `[ end_date, api_key_id, request_id, request_method ]`, `[ end_date, api_key_id, request_id, success ]`, `[ end_date, api_key_id, request_id, user_id ]`, `[ end_date, api_key_id, request_ip, request_method ]`, `[ end_date, api_key_id, request_ip, success ]`, `[ end_date, api_key_id, request_ip, user_id ]`, `[ end_date, api_key_id, request_method, success ]`, `[ end_date, api_key_id, request_method, user_id ]`, `[ end_date, api_key_id, success, user_id ]`, `[ end_date, interface, request_id, request_ip ]`, `[ end_date, interface, request_id, request_method ]`, `[ end_date, interface, request_id, success ]`, `[ end_date, interface, request_id, user_id ]`, `[ end_date, interface, request_ip, request_method ]`, `[ end_date, interface, request_ip, success ]`, `[ end_date, interface, request_ip, user_id ]`, `[ end_date, interface, request_method, success ]`, `[ end_date, interface, request_method, user_id ]`, `[ end_date, interface, success, user_id ]`, `[ end_date, request_id, request_ip, request_method ]`, `[ end_date, request_id, request_ip, success ]`, `[ end_date, request_id, request_ip, user_id ]`, `[ end_date, request_id, request_method, success ]`, `[ end_date, request_id, request_method, user_id ]`, `[ end_date, request_id, success, user_id ]`, `[ end_date, request_ip, request_method, success ]`, `[ end_date, request_ip, request_method, user_id ]`, `[ end_date, request_ip, success, user_id ]`, `[ end_date, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip ]`, `[ api_key_id, interface, request_id, request_method ]`, `[ api_key_id, interface, request_id, success ]`, `[ api_key_id, interface, request_id, user_id ]`, `[ api_key_id, interface, request_ip, request_method ]`, `[ api_key_id, interface, request_ip, success ]`, `[ api_key_id, interface, request_ip, user_id ]`, `[ api_key_id, interface, request_method, success ]`, `[ api_key_id, interface, request_method, user_id ]`, `[ api_key_id, interface, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method ]`, `[ api_key_id, request_id, request_ip, success ]`, `[ api_key_id, request_id, request_ip, user_id ]`, `[ api_key_id, request_id, request_method, success ]`, `[ api_key_id, request_id, request_method, user_id ]`, `[ api_key_id, request_id, success, user_id ]`, `[ api_key_id, request_ip, request_method, success ]`, `[ api_key_id, request_ip, request_method, user_id ]`, `[ api_key_id, request_ip, success, user_id ]`, `[ api_key_id, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method ]`, `[ interface, request_id, request_ip, success ]`, `[ interface, request_id, request_ip, user_id ]`, `[ interface, request_id, request_method, success ]`, `[ interface, request_id, request_method, user_id ]`, `[ interface, request_id, success, user_id ]`, `[ interface, request_ip, request_method, success ]`, `[ interface, request_ip, request_method, user_id ]`, `[ interface, request_ip, success, user_id ]`, `[ interface, request_method, success, user_id ]`, `[ request_id, request_ip, request_method, success ]`, `[ request_id, request_ip, request_method, user_id ]`, `[ request_id, request_ip, success, user_id ]`, `[ request_id, request_method, success, user_id ]`, `[ request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip ]`, `[ start_date, end_date, api_key_id, interface, request_method ]`, `[ start_date, end_date, api_key_id, interface, success ]`, `[ start_date, end_date, api_key_id, interface, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip ]`, `[ start_date, end_date, api_key_id, request_id, request_method ]`, `[ start_date, end_date, api_key_id, request_id, success ]`, `[ start_date, end_date, api_key_id, request_id, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, request_method, success ]`, `[ start_date, end_date, api_key_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip ]`, `[ start_date, end_date, interface, request_id, request_method ]`, `[ start_date, end_date, interface, request_id, success ]`, `[ start_date, end_date, interface, request_id, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method ]`, `[ start_date, end_date, interface, request_ip, success ]`, `[ start_date, end_date, interface, request_ip, user_id ]`, `[ start_date, end_date, interface, request_method, success ]`, `[ start_date, end_date, interface, request_method, user_id ]`, `[ start_date, end_date, interface, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method ]`, `[ start_date, end_date, request_id, request_ip, success ]`, `[ start_date, end_date, request_id, request_ip, user_id ]`, `[ start_date, end_date, request_id, request_method, success ]`, `[ start_date, end_date, request_id, request_method, user_id ]`, `[ start_date, end_date, request_id, success, user_id ]`, `[ start_date, end_date, request_ip, request_method, success ]`, `[ start_date, end_date, request_ip, request_method, user_id ]`, `[ start_date, end_date, request_ip, success, user_id ]`, `[ start_date, end_date, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip ]`, `[ start_date, api_key_id, interface, request_id, request_method ]`, `[ start_date, api_key_id, interface, request_id, success ]`, `[ start_date, api_key_id, interface, request_id, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method ]`, `[ start_date, api_key_id, interface, request_ip, success ]`, `[ start_date, api_key_id, interface, request_ip, user_id ]`, `[ start_date, api_key_id, interface, request_method, success ]`, `[ start_date, api_key_id, interface, request_method, user_id ]`, `[ start_date, api_key_id, interface, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method ]`, `[ start_date, api_key_id, request_id, request_ip, success ]`, `[ start_date, api_key_id, request_id, request_ip, user_id ]`, `[ start_date, api_key_id, request_id, request_method, success ]`, `[ start_date, api_key_id, request_id, request_method, user_id ]`, `[ start_date, api_key_id, request_id, success, user_id ]`, `[ start_date, api_key_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method ]`, `[ start_date, interface, request_id, request_ip, success ]`, `[ start_date, interface, request_id, request_ip, user_id ]`, `[ start_date, interface, request_id, request_method, success ]`, `[ start_date, interface, request_id, request_method, user_id ]`, `[ start_date, interface, request_id, success, user_id ]`, `[ start_date, interface, request_ip, request_method, success ]`, `[ start_date, interface, request_ip, request_method, user_id ]`, `[ start_date, interface, request_ip, success, user_id ]`, `[ start_date, interface, request_method, success, user_id ]`, `[ start_date, request_id, request_ip, request_method, success ]`, `[ start_date, request_id, request_ip, request_method, user_id ]`, `[ start_date, request_id, request_ip, success, user_id ]`, `[ start_date, request_id, request_method, success, user_id ]`, `[ start_date, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip ]`, `[ end_date, api_key_id, interface, request_id, request_method ]`, `[ end_date, api_key_id, interface, request_id, success ]`, `[ end_date, api_key_id, interface, request_id, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method ]`, `[ end_date, api_key_id, interface, request_ip, success ]`, `[ end_date, api_key_id, interface, request_ip, user_id ]`, `[ end_date, api_key_id, interface, request_method, success ]`, `[ end_date, api_key_id, interface, request_method, user_id ]`, `[ end_date, api_key_id, interface, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method ]`, `[ end_date, api_key_id, request_id, request_ip, success ]`, `[ end_date, api_key_id, request_id, request_ip, user_id ]`, `[ end_date, api_key_id, request_id, request_method, success ]`, `[ end_date, api_key_id, request_id, request_method, user_id ]`, `[ end_date, api_key_id, request_id, success, user_id ]`, `[ end_date, api_key_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method ]`, `[ end_date, interface, request_id, request_ip, success ]`, `[ end_date, interface, request_id, request_ip, user_id ]`, `[ end_date, interface, request_id, request_method, success ]`, `[ end_date, interface, request_id, request_method, user_id ]`, `[ end_date, interface, request_id, success, user_id ]`, `[ end_date, interface, request_ip, request_method, success ]`, `[ end_date, interface, request_ip, request_method, user_id ]`, `[ end_date, interface, request_ip, success, user_id ]`, `[ end_date, interface, request_method, success, user_id ]`, `[ end_date, request_id, request_ip, request_method, success ]`, `[ end_date, request_id, request_ip, request_method, user_id ]`, `[ end_date, request_id, request_ip, success, user_id ]`, `[ end_date, request_id, request_method, success, user_id ]`, `[ end_date, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method ]`, `[ api_key_id, interface, request_id, request_ip, success ]`, `[ api_key_id, interface, request_id, request_ip, user_id ]`, `[ api_key_id, interface, request_id, request_method, success ]`, `[ api_key_id, interface, request_id, request_method, user_id ]`, `[ api_key_id, interface, request_id, success, user_id ]`, `[ api_key_id, interface, request_ip, request_method, success ]`, `[ api_key_id, interface, request_ip, request_method, user_id ]`, `[ api_key_id, interface, request_ip, success, user_id ]`, `[ api_key_id, interface, request_method, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method, success ]`, `[ api_key_id, request_id, request_ip, request_method, user_id ]`, `[ api_key_id, request_id, request_ip, success, user_id ]`, `[ api_key_id, request_id, request_method, success, user_id ]`, `[ api_key_id, request_ip, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method, success ]`, `[ interface, request_id, request_ip, request_method, user_id ]`, `[ interface, request_id, request_ip, success, user_id ]`, `[ interface, request_id, request_method, success, user_id ]`, `[ interface, request_ip, request_method, success, user_id ]`, `[ request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_id, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_ip, success ]`, `[ start_date, end_date, api_key_id, interface, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_method, success ]`, `[ start_date, end_date, api_key_id, request_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_id, success, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method ]`, `[ start_date, end_date, interface, request_id, request_ip, success ]`, `[ start_date, end_date, interface, request_id, request_ip, user_id ]`, `[ start_date, end_date, interface, request_id, request_method, success ]`, `[ start_date, end_date, interface, request_id, request_method, user_id ]`, `[ start_date, end_date, interface, request_id, success, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method, success ]`, `[ start_date, end_date, interface, request_ip, request_method, user_id ]`, `[ start_date, end_date, interface, request_ip, success, user_id ]`, `[ start_date, end_date, interface, request_method, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, request_id, request_method, success, user_id ]`, `[ start_date, end_date, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ start_date, api_key_id, interface, request_id, request_ip, success ]`, `[ start_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_method, success ]`, `[ start_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_id, success, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method, success ]`, `[ start_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_ip, success, user_id ]`, `[ start_date, api_key_id, interface, request_method, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, request_id, request_method, success, user_id ]`, `[ start_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method, success ]`, `[ start_date, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, interface, request_id, request_ip, success, user_id ]`, `[ start_date, interface, request_id, request_method, success, user_id ]`, `[ start_date, interface, request_ip, request_method, success, user_id ]`, `[ start_date, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ end_date, api_key_id, interface, request_id, request_ip, success ]`, `[ end_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_method, success ]`, `[ end_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_id, success, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method, success ]`, `[ end_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_ip, success, user_id ]`, `[ end_date, api_key_id, interface, request_method, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, request_id, request_method, success, user_id ]`, `[ end_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method, success ]`, `[ end_date, interface, request_id, request_ip, request_method, user_id ]`, `[ end_date, interface, request_id, request_ip, success, user_id ]`, `[ end_date, interface, request_id, request_method, success, user_id ]`, `[ end_date, interface, request_ip, request_method, success, user_id ]`, `[ end_date, request_id, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ api_key_id, interface, request_id, request_method, success, user_id ]`, `[ api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ end_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ end_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ end_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ end_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ end_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ api_key_id, interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method, success ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, request_method, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_ip, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_id, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, interface, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, api_key_id, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, end_date, interface, request_id, request_ip, request_method, success, user_id ]`, `[ start_date, api_key_id, interface, request_id, request_ip, request_method, success, user_id ]` or `[ end_date, api_key_id, interface, request_id, request_ip, request_method, success, user_id ]`.
        /// </summary>
        public static FilesList<ApiRequestLog> List(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            parameters = parameters != null ? parameters : new Dictionary<string, object>();
            options = options != null ? options : new Dictionary<string, object>();

            if (parameters.ContainsKey("cursor") && !(parameters["cursor"] is string))
            {
                throw new ArgumentException("Bad parameter: cursor must be of type string", "parameters[\"cursor\"]");
            }
            if (parameters.ContainsKey("per_page") && !(parameters["per_page"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: per_page must be of type Nullable<Int64>", "parameters[\"per_page\"]");
            }
            if (parameters.ContainsKey("action") && !(parameters["action"] is string))
            {
                throw new ArgumentException("Bad parameter: action must be of type string", "parameters[\"action\"]");
            }
            if (parameters.ContainsKey("page") && !(parameters["page"] is Nullable<Int64>))
            {
                throw new ArgumentException("Bad parameter: page must be of type Nullable<Int64>", "parameters[\"page\"]");
            }
            if (parameters.ContainsKey("filter") && !(parameters["filter"] is object))
            {
                throw new ArgumentException("Bad parameter: filter must be of type object", "parameters[\"filter\"]");
            }
            if (parameters.ContainsKey("filter_prefix") && !(parameters["filter_prefix"] is object))
            {
                throw new ArgumentException("Bad parameter: filter_prefix must be of type object", "parameters[\"filter_prefix\"]");
            }

            return new FilesList<ApiRequestLog>($"/api_request_logs", System.Net.Http.HttpMethod.Get, parameters, options);
        }

        public static FilesList<ApiRequestLog> All(

            Dictionary<string, object> parameters = null,
            Dictionary<string, object> options = null
        )
        {
            return List(parameters, options);
        }

    }
}