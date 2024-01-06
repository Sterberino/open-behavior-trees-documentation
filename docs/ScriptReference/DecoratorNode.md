<h2 class="header">DecoratorNode</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
         <a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>Derive from this class to create a custom Decorator Node.<p>

<p>The purpose of a decorator node is to manipulate the result of a node's <a class ="link" href="BehaviorTreeNode-Evaluate.md">Evaluate</a> method.</p>

<p>A decorator node has one child node, which should be run in it's <a class ="link" href="BehaviorTreeNode-Evaluate.md">Evaluate</a> method.</p>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td>child</td>
            <td>The child node of the decorator. Call child.Evaluate(BehaviorTree behaviorTree) in your override of Evaluate().</td>
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
