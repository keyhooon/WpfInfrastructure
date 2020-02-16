using System.Windows;
using Prism.Commands;

namespace WpfInfrastructure
{
    public static class WindowCommands
    {


        private static DelegateCommand<Window> _closeWindowCommand;
        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public static DelegateCommand<Window> CloseWindowCommand
        {
            get
            {
                return _closeWindowCommand ??= new DelegateCommand<Window>(window =>
                {
                    window.Close();
                });
            }
        }

        private static DelegateCommand<Window> _maximizedWindowCommand;
        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public static DelegateCommand<Window> MaximizedWindowCommand
        {
            get
            {
                return _maximizedWindowCommand ??= new DelegateCommand<Window>(window =>
                {
                    window.WindowState = window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
                });
            }
        }

        private static DelegateCommand<Window> _minimizedWindowCommand;
        /// <summary>
        /// Gets the MyCommand.
        /// </summary>
        public static DelegateCommand<Window> MinimizedWindowCommand
        {
            get
            {
                return _minimizedWindowCommand ??= new DelegateCommand<Window>(window =>
                {
                    window.WindowState = WindowState.Minimized;
                });
            }
        }



    }
}
