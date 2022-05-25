using System;
using System.Diagnostics;
using System.Threading;

namespace ScreenRecorderLib.Service
{
    public static class ScreenRecorderLibHelper
    {
        private static Recorder _Recorder;

        public static void StartRecording(string videoPath, string logPath)
        {
            if (_Recorder == null)
            {
                try
                {
                    Console.WriteLine();
                    _Log("Configuring Record");
                    _Log($"Video Path: {videoPath}");
                    _Log($"Log Path: {logPath}");

                    RecorderOptions options = new RecorderOptions
                    {
                        OutputOptions = new OutputOptions
                        {
                            RecorderMode = RecorderMode.Video,
                            Stretch = StretchMode.Uniform
                        },
                        VideoEncoderOptions = new VideoEncoderOptions
                        {
                            Encoder = new H264VideoEncoder
                            {
                                BitrateMode = H264BitrateControlMode.Quality,
                                EncoderProfile = H264Profile.Main
                            }
                        },
                        LogOptions = new LogOptions
                        {
                            IsLogEnabled = true,
                            LogSeverityLevel = LogLevel.Trace,
                            LogFilePath = logPath
                        }
                    };

                    _Log("Creating Recorder");

                    _Recorder = Recorder.CreateRecorder(options);
                    _Recorder.OnStatusChanged += Rec_OnStatusChanged;
                    _Recorder.OnRecordingFailed += Rec_OnRecordingFailed;
                    _Recorder.OnRecordingComplete += Rec_OnRecordingComplete;

                    _Log($"Starting Record");

                    _Recorder.Record(videoPath);

                    while (_Recorder.Status != RecorderStatus.Recording)
                    {
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception exception)
                {
                    _Log($"Failed to Start Recording: {exception.Message}");
                    _Log(exception.ToString());
                }
            }
        }

        public static void StopRecording()
        {
            if (_Recorder != null)
            {
                _Log("Finishing Record");

                _Recorder.Stop();

                while (_Recorder.Status != RecorderStatus.Idle)
                {
                    Thread.Sleep(1000);
                }

                _Recorder = null;
            }
        }

        private static void Rec_OnStatusChanged(object sender, RecordingStatusEventArgs e)
        {
            _Log($"Recorder OnStatusChanged Event: {e.Status}");
        }

        private static void Rec_OnRecordingFailed(object sender, RecordingFailedEventArgs e)
        {
            _Log($"Recorder OnRecordingFailed Event: {e.Error}");
        }

        private static void Rec_OnRecordingComplete(object sender, RecordingCompleteEventArgs e)
        {
            _Log("Recorder OnRecordingComplete Event");
        }

        private static void _Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:dd/mm/yyyy HH:mm:ss}] {message}");
            EventLog.WriteEntry("ScreenRecorderLibService", message);
        }
    }
}
