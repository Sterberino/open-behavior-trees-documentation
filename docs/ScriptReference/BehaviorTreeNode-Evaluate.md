<h2 class="header"><a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>.Evaluate</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p>protected </p>
        <a class="link" href= "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a>
        <p>Evaluate(<a class="link" href="BehaviorTree.md">BehaviorTree</a> behaviorTree);</p>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>Ran when the node ticks. Returns BehaviorTreeNodeResult.success, BehaviorTreeNodeResult.failure, or BehaviorTreeNodeResult.running. Override this method to implement custom behavior in your BehaviorTreeNode classes.<p>

<h2 class="small-h2 header">Example</h2>

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OpenBehaviorTrees;

public class Example : BehaviorTreeNode
{
    public Vector3 target;
    public float maxDistance;

    //Return failure if too far away from the target. Return true if within range.
    protected override BehaviorTreeNodeResult Evaluate(BehaviorTree behaviorTree)
    {
        if (Vector3.Distance(behaviorTree.transform.position, target) < maxDistance)
        {
            return BehaviorTreeNodeResult.success;
        }

        return BehaviorTreeNodeResult.failure;
    }
}
```