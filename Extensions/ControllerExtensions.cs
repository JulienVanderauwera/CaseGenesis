using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CaseGenesis.Extensions
{
    public static class ControllerExtensions
    {
        public static void HandleClientCall(this Controller controller, Action action)
        {
            controller.HandleClientCall(() =>
            {
                action();
                return true;
            });
        }
        public static void HandleClientCall(this Controller controller, Func<bool> function)
        {
            if (controller.ModelState.IsValid)
            {
                try
                {
                    if (!function())
                    {
                        //TodO implement LOG
                        return;
                    }
                }
                 catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }
    }
}