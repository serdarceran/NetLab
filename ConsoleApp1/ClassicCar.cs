using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public enum Direction2 { LEFT, STRAIGHT, RIGHT }
    class ClassicCar : ICar
    {
        private delegate void LogHandler(ICar carDetails);

        private event LogHandler Log;

        private int _speed = 0;
        public int Speed
        {
            get { return _speed; }
            private set { setField(ref _speed, value); }
        }

        private int _sound = 0;
        public int Sound
        {
            get { return _sound; }
            private set { setField(ref _sound, value); }
        }
        private System.Timers.Timer atimer = new System.Timers.Timer(1000);

        private Boolean _light = false;
        public Boolean LightOn
        {
            get { return _light; }
            private set { setField(ref _light, value); }
        }

        private Direction2 _direction2;
        public Direction2 CarDirection
        {
            get { return _direction2; }
            private set
            {
                setField(ref _direction2, value);
            }
        }

        public int Abc { get; private set; }

        public ClassicCar()
        {
            this.atimer.Elapsed += onTimedEvent;
            this.atimer.AutoReset = true;
            this.CarDirection = Direction2.STRAIGHT;
            this.LightOn = false;
        }

        public void corn()
        {
            if (!this.atimer.Enabled)
            {
                this.atimer.Enabled = true;
            }
            Abc = 5;
        }

        public void onTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Sound += 10;
            if (Sound > 100)
            {
                this.atimer.Stop();
                Sound = 0;
            }
        }

        public void slowDown()
        {
            var s = Speed;
            s -= 10;
            if (s < 0)
            {
                s = 0;
            }
            Speed = s;
        }

        public void speedUp()
        {
            var s = Speed;
            s += 10;
            if (s > 150)
            {
                s = 150;
            }
            Speed = s;
        }

        public void stop()
        {
            Speed = 0;
        }

        public void turnLeft()
        {
            int d = (int)CarDirection;
            CarDirection = (Direction2)Math.Clamp(--d, 0, 2);
        }

        public void turnLightOff()
        {
            LightOn = false;
        }

        public void turnLightOn()
        {
            LightOn = true;
        }

        public void turnRight()
        {
            int d = (int)CarDirection;
            CarDirection = (Direction2)Math.Clamp(++d, 0, 2);
        }

        private void setField<T>(ref T field, T value)
        {
            if (!field.Equals(value))
            {
                field = value;
                Log?.Invoke(this);
            }
        }

        internal void subscribe(Action<ICar> listener)
        {
            Log += new LogHandler(listener);
            listener(this);
        }
    }
}
