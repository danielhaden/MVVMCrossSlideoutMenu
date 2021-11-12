using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Wpf.Core;
using Serilog;
using Serilog.Extensions.Logging;


namespace MultiRegionView.WPF
{
    /// <summary>
    /// Custom setup class (required since MVVMCross 8.0 because MvxWpfSetup is now
    /// an abstract class.
    /// </summary>
    public class Setup : MvxWpfSetup<Core.App>
    {

        /// <summary>
        /// CreateLogProvider must be overrided in custom setup class
        /// </summary>
        protected override ILoggerProvider CreateLogProvider()
        {
            return new SerilogLoggerProvider();
        }

        /// <summary>
        /// CreateLogFactor must be overrided in custom setup class
        /// </summary>
        /// <returns></returns>
        protected override ILoggerFactory CreateLogFactory()
        {
            // serilog configuration
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}