﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private Logger()
        {

        }
        private static volatile object _lockObj = new object();
        private static Logger? _logger;
        public static Logger GetInstance()
        {
            if (_logger == null)
            {
                lock (_lockObj)
                {
                    if (_logger == null)
                    {
                        _logger = new Logger();
                    }

                    return _logger;
                }
            }

            return _logger;
        }

        public void Info(string message)
        { 
            Console.WriteLine($"Info: {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
    }
}
