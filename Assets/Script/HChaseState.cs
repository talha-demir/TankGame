﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HChaseState : StateMachineBehaviour {
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<HTankAI>().ChaseState();
    }
}
