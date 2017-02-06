﻿//-----------------------------------------------------
// <copyright file="ConsoleLoggerUnitTests.cs" company="Magenic">
//  Copyright 2017 Magenic, All rights Reserved
// </copyright>
// <summary>Test the file logger</summary>
//-----------------------------------------------------
using Magenic.MaqsFramework.Utilities.Helper;
using Magenic.MaqsFramework.Utilities.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilitiesUnitTesting
{
    /// <summary>
    /// Console logger unit tests
    /// </summary>
    [TestClass]
    public class ConsoleLoggerUnitTests
    {
        /// <summary>
        ///  Log message to a new console logger
        /// </summary>
        [TestMethod]
        [TestCategory(TestCategories.Utilities)]
        public void ConsoleLoggerLogMessage()
        {
            ConsoleLogger console = new ConsoleLogger();
            console.LogMessage("TestString {0} {1}", "args1", "args2");
        }

        /// <summary>
        /// Write message to new console logger
        /// </summary>
        [TestMethod]
        [TestCategory(TestCategories.Utilities)]
        public void ConsoleLoggerWriteMessage()
        {
            ConsoleLogger console = new ConsoleLogger();
            console.Write("TestString {0} {1}", "args1", "args2");
        }

        /// <summary>
        /// Write message to new console logger using defined message type
        /// </summary>
        [TestMethod]
        [TestCategory(TestCategories.Utilities)]
        public void ConsoleLoggerWriteMessageSelectType()
        {
           ConsoleLogger testConsole = new ConsoleLogger();
           testConsole.Write(MessageType.GENERIC, "TestString {0}", "args1");
        }
    }
}