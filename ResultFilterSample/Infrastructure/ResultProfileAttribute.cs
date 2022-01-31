﻿using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;
using System.IO;

namespace ActionFilterSample.Infrastructure
{
    public class ResultProfileAttribute : ResultFilterAttribute
    {
        private Stopwatch timer;

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            timer.Stop();
            string message = $"На выполнение резальтата {context.ActionDescriptor.DisplayName} затрачено {timer.Elapsed}";

            StreamWriter streamWriter = new StreamWriter("App_Data/log.txt", true);
            streamWriter.WriteLine(message);
            streamWriter.Close();
        }
    }
}
