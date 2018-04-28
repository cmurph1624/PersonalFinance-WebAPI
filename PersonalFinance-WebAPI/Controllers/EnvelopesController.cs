using PersonalFinance_WebAPI.Envelopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PersonalFinance_WebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class EnvelopesController : ApiController
    {
        // GET: api/Envelopes
        public IEnumerable<EnvelopeItem> Get()
        {
            EnvelopesLibrary el = new EnvelopesLibrary();

            List<EnvelopeItem> e = el.GetEnvelopes();
            return e;
        }

        // GET: api/Envelopes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Envelopes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Envelopes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Envelopes/5
        public void Delete(int id)
        {
        }
    }
}
