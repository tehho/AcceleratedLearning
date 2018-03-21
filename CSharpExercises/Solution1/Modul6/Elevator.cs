using System;
using System.Reflection.Metadata;

namespace Modul6
{
    public class Elevator
    {
        public string Name { get; }
        private int _currentFloor;
        private int _uses;
        public int CurrentFloor
        {
            get => _currentFloor;
            set
            {
                if (value < MinFloor || value > MaxFloor)
                {
                    throw new ArgumentException($"Target floor {value} is outside of elevator range {MinFloor} - {MaxFloor}.", nameof(value));
                }
                _currentFloor = value;
            }
        }
        public int MaxFloor { get; }
        public int MinFloor { get; }
        public int Count => Math.Abs(MaxFloor - MinFloor) + 1;

        public Elevator(string name, int minFloor, int maxFloor)
            : this(name, minFloor, maxFloor, minFloor)
        {
        }
        public Elevator(string name, int minFloor, int maxFloor, int currentFloor)
        {
            if (minFloor > maxFloor)
                throw new ArgumentException("minFloor is larger then maxFloor", $"{nameof(minFloor)} or {nameof(maxFloor)}");

            Name = name;
            MinFloor = minFloor;
            MaxFloor = maxFloor;
            CurrentFloor = currentFloor;
            _uses = 100;
        }

        public void Repair(int repairValue)
        {
            if (repairValue < 1)
                throw  new ArgumentException("RepairValue can't be lower then 1", nameof(repairValue));
            _uses = repairValue;
        }


        public void GoTo(int floor)
        {
            if (_uses < 1)
            {
                throw new InvalidOperationException($"Uses < 1, please Repair the elevator {Name}");
            }
            _uses--;
            CurrentFloor = floor;
        }

        public void GoDown()
        {
            GoTo(CurrentFloor - 1);
        }

        public void GoUp()
        {
            GoTo(CurrentFloor + 1);
        }

        public void Crash()
        {
            while (CurrentFloor > MinFloor)
            {
                GoDown();
                Console.WriteLine($"We are crashing! Current floor {CurrentFloor}");
            }
        }
        
        public string Report()
        {
            return ToString();
        }

        public override string ToString()
        {
            return $"Mitt namn är {Name}. Jag bor mellan {MinFloor} och {MaxFloor} och är på våning {CurrentFloor}.";
        }

    }
}