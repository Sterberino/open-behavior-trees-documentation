<h2 class="header">UtilityDecorator</h2>

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
    A special decorator node that only accepts a child of type <a class="link" href= "UtilityEvaluator.md">UtilityEvaluator</a>. Derive from this class if you want to manipulate the output of a UtilityEvaluator's GetScore method.
</p>

<h2 class="small-h2 header">Inherited Members</h2>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a> child</td>
            <td>The child node that will have its score altered. UtilityDecorator will not allow for nodes that are not derived from <a class="link" href= "UtilityEvaluator.md">UtilityEvaluator</a>.</td>
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
