using System;
using SoftwareSecurityAssignmentConsole.Core;

namespace SoftwareSecurityAssignment
{
    public class StateEngineMock
    {

        public event Action DoorOpen;
        public event Action DoorClosed;
        public event Action TimeChanged;
        public event Action TimeSet;
        public event Action Started;
        public event Action Stopped;
        public event Action Cooking;

        public StateEngineMock ()
        {
            DoorOpen += OpenMicrowaveDoor;
            DoorClosed += CloseMicrowaveDoor;
            TimeChanged += ChangeTime;
            TimeSet += SetTime;
            Started += StartTimer;
            Stopped += StopTimer;
            Cooking += IsCooking;
        }

        private void OpenMicrowaveDoor ()
        {

        }

        private void CloseMicrowaveDoor ()
        {

        }

        private void ChangeTime ()
        {

        }
        private void SetTime ()
        {

        }

        private void StartTimer ()
        {

        }

        private void StopTimer ()
        {

        }
        private void IsCooking ()
        {

        }
    }
}