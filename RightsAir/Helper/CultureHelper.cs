using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.SessionState;

namespace RightsAir.Helper
{
    public class CultureHelper
    {

        protected HttpSessionState session;

        //constructor   
        public CultureHelper(HttpSessionState httpSessionState)
        {
            session = httpSessionState;
        }
        // Properties  
        public static int CurrentCulture
        {
            get
            {
                if (Thread.CurrentThread.CurrentUICulture.Name == "es-US")
                {
                    return 0;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "es-ES")
                {
                    return 1;
                }
                else if (Thread.CurrentThread.CurrentUICulture.Name == "fr-FR")
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            set
            {

                if (value == 0)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                }
                else if (value == 1)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");
                }
                else if (value == 2)
                {
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
                }

                Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;

            }
        }
    }
}