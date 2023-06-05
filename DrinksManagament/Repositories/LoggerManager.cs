﻿using DrinksManagament.Contracts;
using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;

namespace DrinksManagament.Repositories
{
    public class LoggerManager : ILoggerManager
    {

        private readonly ILog _logger = LogManager.GetLogger(typeof(LoggerManager));
        public LoggerManager()
        {
            try
            {
                XmlDocument log4netConfig = new XmlDocument();

                using (var fs = File.OpenRead("Configuration/log4net.config"))
                {
                    log4netConfig.Load(fs);

                    var repo = LogManager.CreateRepository(
                            Assembly.GetEntryAssembly(),
                            typeof(log4net.Repository.Hierarchy.Hierarchy));
                    string ruta = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    GlobalContext.Properties["FilePath"] = ruta.Substring(6, ruta.Length - 6);
                    XmlConfigurator.Configure(repo, log4netConfig["log4net"]);
                }
            }
            catch (Exception ex)
            {
                _logger.Error("Error", ex);
            }
        }

        public void LogAdvertencia(string message)
        {
            _logger.Info(message);
        }

        public void LogAdvertencia(string message, Exception ex)
        {
            _logger.Info(message, ex);
        }

        public void LogError(string message)
        {
            _logger.Info(message);
        }

        public void LogError(string message, Exception ex)
        {
            _logger.Info(message, ex);
        }

        public void LogInformation(string message)
        {
            _logger.Info(message);
        }

        public void LogInformation(string message, Exception ex)
        {
            _logger.Info(message, ex);
        }
    }
}
