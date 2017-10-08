using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    [Serializable]
    public class MockItem
    {
        public int CompontentID;
        public string ComponentName;
        public string ComponentDesc;
        public string ComponentUnit;
        public int InstructionID;
        public string InstructionDesc;
        public int SequenceNumber;
        public string WhenInstructionUsedFrom;
        public string WhenInstructionUsedTo;   
        public int QuantityUsed;
        public int ProcessID;
        public string ProcessName;
        public string ProcessDescription;
        public int Difficulty;
        public int ProcessDurationMinutes;
        public int ProcessTypeID;
        public string ProcessTypeName;
        public string ProcessTypeDescription;
        public int ExecutionID;
        public string WhenExecutionStarted;  
        public string WhenExecutionFinished; 
        public int PersonID;
        public string PersonUserName;
        public string PersonEmail;
        public string PersonName;
    }
}
