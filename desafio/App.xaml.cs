using desafio.Bind;
using Ninject;
using System.Configuration;
using System.Data;
using System.Windows;

namespace desafio
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IKernel _kernel;

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _kernel = new StandardKernel(new AppModule());

            var mainWindow = _kernel.Get<MainWindow>();
            mainWindow.Show();
        }
    }
}
