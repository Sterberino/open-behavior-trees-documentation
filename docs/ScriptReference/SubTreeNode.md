<h2 class="header">SubTreeNode</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
        <a class="link" href= "DecoratorNode.md">DecoratorNode</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>
    A special decorator node used by the Behavior Tree Editor Window to separate parts of a behavior tree into separate smaller trees. The <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> method simply calls the <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> method of its child node.
</p>

<h2 class="small-h2 header">Inherited Members</h2>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a> child</td>
            <td>The child node. See <a class="link" href= "DecoratorNode.md">DecoratorNode</a>.</td>
        </tr>
    </tbody>
</table>
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
