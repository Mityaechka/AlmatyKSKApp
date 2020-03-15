using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AlmatyKSKForms
{
    class StatusResponsePair
    {
        public HttpStatusCode code;
        public string response;

        public StatusResponsePair(HttpStatusCode code, string response)
        {
            this.code = code;
            this.response = response ?? throw new ArgumentNullException(nameof(response));
        }
    }
}
