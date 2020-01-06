using SoftwareSecurityAssignmentConsole.Interfaces;

namespace SoftwareSecurityAssignmentConsole.Core {
    public class ActionScheduler {

        IAction currentAction;

        public void SetAction (IAction action) {
            if (currentAction == action) { return; }
            if (currentAction != null) {
                currentAction.Cancel ();
            }
            currentAction = action;
        }

        public void StopAction () {
            SetAction (null);
        }
    }
}