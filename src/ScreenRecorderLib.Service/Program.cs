using System;
using Topshelf;

namespace ScreenRecorderLib.Service
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var ec = HostFactory.Run(hc =>
            {
                hc.Service<ScreenRecorderLibService>(hc =>
                {
                    hc.ConstructUsing(name => new ScreenRecorderLibService());
                    hc.WhenStarted(tc => tc.Start());
                    hc.WhenStopped(tc => tc.Stop());

                    hc.WhenPaused(tc => tc.Stop());
                    hc.WhenContinued(tc => tc.Start());

                    hc.WhenShutdown(tc => tc.Stop());
                });
                hc.RunAsLocalSystem();

                hc.SetDescription("Screen Recorder Library Service Example");
                hc.SetDisplayName("Screen Recorder Library Service");
                hc.SetServiceName("ScreenRecorderLibService");
                
                hc.StartAutomatically();

                hc.EnablePauseAndContinue();
                hc.EnableShutdown();
            });

            var exitCode = (int)Convert.ChangeType(ec, ec.GetTypeCode());
            Environment.ExitCode = exitCode;
        }
    }
}
