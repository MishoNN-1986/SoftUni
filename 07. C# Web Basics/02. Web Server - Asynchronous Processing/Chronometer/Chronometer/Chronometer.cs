﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chronometer
{
    public class Chronometer : IChronometer
    {
        private long milliseconds;

        public string GetTime => $"{milliseconds / 60000:D2}:{milliseconds / 1000:D2}:{(milliseconds % 1000):D4}";

        private bool isRunning;

        public Chronometer()
        {
            this.Reset();
        }

        public List<string> Laps { get; private set }

        public string Lap()
        {
            string lap = this.GetTime;
            this.Laps.Add(lap);
            return lap;
        }

        public void Reset()
        {
            this.Stop();
            this.milliseconds = 0;
            this.Laps = new List<string>();
        }

        public void Start()
        {
            this.isRunning = true;

            Task.Run(() =>
            {
                while (this.isRunning)
                {
                    Thread.Sleep(1);
                    this.milliseconds++;
                }
            });
        }

        public void Stop()
        {
            this.isRunning = false;
        }

    }
}
