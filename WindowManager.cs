﻿using System;
using System.Windows.Controls;
using PAYMAP_BACKEND.Views;
using MahApps.Metro.Controls;

namespace PAYMAP_BACKEND
{
    public partial class WindowManager
    {
        private static WindowManager _instance;
        
        private static CrawlerView _crawlerView;
        private static SplashView _splashView;
        
        public static bool IsModuleRunning = false;
        public static bool IsModuleHealthy = false;

        private WindowManager()
        {
            
        }

        public static WindowManager GetInstance()
        {
            return _instance ?? (_instance = new WindowManager());
        }

        public static void ShowMainWindow()
        {
            if (_mainWindow == null)
            {
                _mainWindow = new MainWindow();
            }
            _mainWindow.Show();
        }

        public static void HideMainWindow()
        {
            try
            {
                _mainWindow?.Close();
            }
            catch (Exception exception)
            {
                LogManager.NewLog(LogType.WindowManager, LogLevel.Error, "HideMainWindow", exception);
            }
        }

        public static void OnMainWindowLoaded()
        {
            InitializeMainWindow();
        }

        public static void OnMainWindowClosed()
        {
            App.OnUserTerminate();
        }

        private static void InitializeCrawlerWindow()
        {
            
        }

        private static void InitializeSplashWindow()
        {
            
        }

        public static void SetCrawlerView(CrawlerView crawlerView)
        {
            _crawlerView = crawlerView;
            InitializeCrawlerWindow();
        }

        public static void SetConsoleView(ConsoleView consoleView)
        {
            _consoleView = consoleView;
            InitializeConsoleWindow();
        }

        public static void SetSplashView(SplashView splashView)
        {
            _splashView = splashView;
            InitializeSplashWindow();
        }
        
    }
}