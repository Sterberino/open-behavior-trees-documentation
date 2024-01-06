---
isNavigationIncluded: false
---

<h2 class="header"><a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>.Clone</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p>public </p>
        <a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>
        <p>Clone;</p>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>An abstract method returning a BehaviorTreeNode. Required to create a runtime instance.<p>

<h2 class="small-h2 header">Example</h2>

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using OpenBehaviorTrees;

public class CloneExample : BehaviorTreeNode
{
    //The following example will clone all of the fields of the original object (this)
    public override BehaviorTreeNode Clone()
    {
        CloneExample clonedNode = CreateInstance<CloneExample>();

        // Use reflection to get all fields
        FieldInfo[] fields = typeof(CloneExample).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (FieldInfo field in fields)
        {
            // Copy the value of each field from the original to the cloned object
            field.SetValue(clonedNode, field.GetValue(this));
        }

        return clonedNode;
    }
}
```
