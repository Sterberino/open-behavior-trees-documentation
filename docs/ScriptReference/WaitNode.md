<h2 class="header">WaitNode</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
         <a class="link" href= "ConditionNode.md">ConditionNode</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>When this node is evaluated, it increments a counter by the time passed since the last frame. If the time is less than <span class="variable-name">waitTime</span> it returns <a class="link" href= "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a>.failure. Otherwise, it returns <a class="link" href= "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a>.success and the counter is reset.<p>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td><span class="variable-name">float</span> waitTime</td>
            <td>A float that represents how long the node must wait before returning <a class="link" href= "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a>.success.</td>
        </tr>
       <tr>
            <td><a class="link" href = "WaitNode.md">WaitNode.TimeType</a> timeType</td>
            <td>An enum that determines how the counter is incremented.</td>
        </tr>
    </tbody>
</table>

<h2 class="small-h2 header">Inherited Members</h2>
<h2 class="small-h2 header">Public Methods</h2>

<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a></td>
            <td>Ran when the behavior tree ticks. Returns BehaviorTreeNodeResult.success, BehaviorTreeNodeResult.failure, or BehaviorTreeNodeResult.running.</td>
        </tr>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-Clone.md">Clone</a></td>
            <td>An abstract method returning a BehaviorTreeNode. Required to create a runtime instance.</td>
        </tr>
        <tr>
            <td><a class="link" href="BehaviorTreeNode-GetAllChildren.md">GetAllChildren</a></td>
            <td>Returns a list of all children nodes. For non-decorator, non-composite nodes, the list will be empty.</td>
        </tr>
        <tr>
            <td><a class="link" href="https://docs.unity3d.com/ScriptReference/ScriptableObject.OnValidate.html">OnValidate</a></td>
            <td>An empty virtual method exists in the BehaviorTreeNode class. The method is called after changing values in the BehaviorTreeEditorWindow. Override it if you need custom behavior in OnValidate.</td>
        </tr>
    </tbody>

</table>
