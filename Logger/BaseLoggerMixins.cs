using System;
using System.Runtime.CompilerServices;

namespace Logger
{
    public static class BaseLoggerMixins
    {
        public static void Error(this BaseLogger logger, string message, string[] parameters)
        {
            if (logger == null)
                throw new ArgumentNullException("");
            else
            {
                string messageAndParameters = message + " caused by";
                if (parameters.Length != 0)
                {
                    foreach (string parameter in parameters)
                    {
                        if (parameter != parameters[parameters.Length - 1])
                            messageAndParameters += $" {parameter},";
                        else
                            messageAndParameters += $" {parameter}";
                    }

                    //messageAndParameters = $"{message} {parameters}";
                    logger.Log(LogLevel.Error, messageAndParameters);
                }

            }
        }

        public static void Warning(this BaseLogger logger, string message, string[] parameters)
        {
            if (logger == null)
                throw new ArgumentNullException("");
            else
            {
                string messageAndParameters = message + " caused by";
                if (parameters.Length != 0)
                {
                    foreach (string parameter in parameters)
                    {
                        if (parameter != parameters[parameters.Length - 1])
                            messageAndParameters += $" {parameter},";
                        else
                            messageAndParameters += $" {parameter}";
                    }

                    //messageAndParameters = $"{message} {parameters}";
                    logger.Log(LogLevel.Warning, messageAndParameters);
                }
            }
        }

        public static void Information(this BaseLogger logger, string message, string[] parameters)
        {
            if (logger == null)
                throw new ArgumentNullException("");
            else
            {
                string messageAndParameters = message + " caused by";
                if (parameters.Length != 0)
                {
                    foreach (string parameter in parameters)
                    {
                        if (parameter != parameters[parameters.Length - 1])
                            messageAndParameters += $" {parameter},";
                        else
                            messageAndParameters += $" {parameter}";
                    }

                    //messageAndParameters = $"{message} {parameters}";
                    logger.Log(LogLevel.Information, messageAndParameters);
                }
            }
        }

        public static void Debug(this BaseLogger logger, string message, string[] parameters)
        {
            if (logger == null)
                throw new ArgumentNullException("");
            else
            {
                string messageAndParameters = message + " caused by";
                if (parameters.Length != 0)
                {
                    foreach (string parameter in parameters)
                    {
                        if (parameter != parameters[parameters.Length - 1])
                            messageAndParameters += $" {parameter},";
                        else
                            messageAndParameters += $" {parameter}";
                    }

                    //messageAndParameters = $"{message} {parameters}";
                    logger.Log(LogLevel.Debug, messageAndParameters);
                }
            }
        }
    }
}
