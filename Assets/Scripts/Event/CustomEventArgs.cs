using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrabObjectPutDownArgs : EventArgs
{
    public Vector3 putPosition;
}

public class OnChangeGameFlowStateMachineArgs : EventArgs
{
    public StateSystem oldState;
    public StateSystem newState;
}
