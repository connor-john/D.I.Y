using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class MockItem
    {
        public int CompontentID { get; set; }
        public string ComponentName { get; set; }
        public string ComponentDesc { get; set; }
        public string ComponentUnit { get; set; }
        public int InstructionID { get; set; }
        public string InstructionDesc { get; set; }
        public int SequenceNumber { get; set; }
        public string WhenInstructionUsedFrom { get; set; } // Could turn this into a datetime
        public string WhenInstructionUsedTo { get; set; }   // Could turn this into a datetime
        public int QuantityUsed { get; set; }
        public int ProcessID { get; set; }
        public string ProcessName { get; set; }
        public string ProcessDescription { get; set; }
        public int Difficulty { get; set; }
        public int ProcessDurationMinutes { get; set; }
        public int ProcessTypeID { get; set; }
        public string ProcessTypeName { get; set; }
        public string ProcessTypeDescription { get; set; }
        public int ExecutionID { get; set; }
        public string WhenExecutionStarted { get; set; }    // Could turn this into a datetime
        public string WhenExecutionFinished { get; set; }   // Could turn this into a datetime
        public int PersonID { get; set; }
        public string PersonUserName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonName { get; set; }
    }
}
