using System.IO;
using System.Timers;

namespace ScreenRecorderLib.Service
{
    public class ScreenRecorderLibService
    {
        private Timer _Timer;

        public ScreenRecorderLibService()
        {
            _Timer = null;
        }

        public void Start()
        {
            if (_Timer == null)
            {
                _Timer = new Timer(10000);
                _Timer.Elapsed += _OnTimedEvent;
                _Timer.Start();
            }
        }
        
        public void Stop()
        {
            if (_Timer != null)
            {
                _Timer.Stop();
                _Timer = null;
            }
        }

        private void _OnTimedEvent(object source, ElapsedEventArgs e)
        {
            string videoPath = $"{Path.GetTempPath()}{Path.GetRandomFileName()}.mp4";
            string logPath = $"{Path.GetTempPath()}{Path.GetRandomFileName()}.txt";

            ScreenRecorderLibHelper.StartRecording(videoPath, logPath);

            System.Threading.Thread.Sleep(5000);

            ScreenRecorderLibHelper.StopRecording();
        }
    }
}
