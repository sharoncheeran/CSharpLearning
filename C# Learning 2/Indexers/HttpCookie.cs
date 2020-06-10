using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string keys]
        {
            get => _dictionary[keys];
            set => _dictionary[keys] = value;
        }
    }
}