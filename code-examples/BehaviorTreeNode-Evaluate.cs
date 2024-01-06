using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OpenBehaviorTrees;

public class Example : BehaviorTreeNode
{
    public Vector3 target;
    public float maxDistance;

    public override BehaviorTreeNodeResult Evaluate(BehaviorTree behaviorTree)
    {
        if (Vector3.Distance(behaviorTree.transform.position, target) < maxDistance)
        {
            return BehaviorTreeNodeResult.success;
        }

        return BehaviorTreeNodeResult.failure;
    }
}