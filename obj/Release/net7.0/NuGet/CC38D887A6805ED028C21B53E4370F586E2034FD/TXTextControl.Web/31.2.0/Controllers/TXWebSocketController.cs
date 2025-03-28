using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TXTextControl.Web;

namespace KipWeb5.Controllers {

   public class TXWebSocketController : ApiController {

      public HttpResponseMessage Get() {
         if (HttpContext.Current.IsWebSocketRequest) {
            var wsHandler = new WebSocketHandler();
            wsHandler.ProcessRequest(HttpContext.Current);
            return new HttpResponseMessage(HttpStatusCode.SwitchingProtocols);
         }
         return new HttpResponseMessage(HttpStatusCode.OK);
      }
   }
}
