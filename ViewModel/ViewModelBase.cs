﻿using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFBase.ViewModel
{
    public class ViewModelBase:Common.NotifyBase
    {
        #region 日志
        public static Logger logger = LogManager.GetCurrentClassLogger();

        //public void MyMethod1()
        //{
        //    int k = 42;
        //    int l = 100;

        //    logger.Trace("Sample trace message, k={0}, l={1}", k, l);
        //    logger.Debug("Sample debug message, k={0}, l={1}", k, l);
        //    logger.Info("Sample informational message, k={0}, l={1}", k, l);
        //    logger.Warn("Sample warning message, k={0}, l={1}", k, l);
        //    logger.Error("Sample error message, k={0}, l={1}", k, l);
        //    logger.Fatal("Sample fatal error message, k={0}, l={1}", k, l);
        //    logger.Log(LogLevel.Info, "Sample informational message, k={0}, l={1}", k, l);
        //}
        #endregion
    }
}
