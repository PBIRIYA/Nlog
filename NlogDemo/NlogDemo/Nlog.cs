using System;
using NLog;

namespace NlogDemo
{
    public class Nlog
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        /// <summary>
        /// Fine-grained statements concerning program state, typically used for debugging,
        /// </summary>
        /// <param name="="message"></param>
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }
        /// <summary>
        /// Statements that describe non fatal errors in the application
        /// this level is used quite often for logging handled exceptions
        /// <param name="="message"></param>{
        public void LogError(string message)
        {
            logger.Error(message);
        }
        /// <summary>
        /// Statements that describe ptentially harmful events or states in the program
        /// </summary>
        /// <param name="="message"></param>
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
        public void LogInfo(string message)
        {
            logger.Info(message);
        }
    }
}