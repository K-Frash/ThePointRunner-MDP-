﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalState : BaseState
{
    public GoalState(string reward)
    {
        Reward = reward;
    }
}
