<h2 class="header">UtilitySelector</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
        <a class="link" href= "UtilityComposite.md">UtilityComposite</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>The UtilitySelector node selects from a list of <a class="link" href= "UtilityEvaluator.md">UtilityEvaluator</a> child nodes to return the UtilityEvaluator's child node's <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> method.</p>
<br/>
<p>Each UtilityEvaluator node has a GetScore method, which returns a float. The UtilitySelector gets the scores of all of its children, and selects the child to evaluate based on its score.<p>
<br/>
<p><span class="variable-name">chooseFromTopResults</span> determines which node is selected for evaluation. If <span class="variable-name">chooseFromTopResults</span> is 0, the UtilityEvaluator with the highest score is selected for evaluation, otherwise, it is randomly selected from the top <span class="variable-name">chooseFromTopResults</span> scoring nodes.<p>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td><span class="variable-name">int chooseFromTopResults</span></td>
            <td>The UtilitySelector chooses randomly from the top x nodes, where x=<span class="variable-name">chooseFromTopResults</span>. If <span class="variable-name">chooseFromTopResults</span> is 0, the UtilitySelector chooses the top scoring node.</td>
        </tr>
    </tbody>
</table>

<h2 class="small-h2 header">Inherited Members</h2>
<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td>List<<a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>> children</td>
            <td>A list of children nodes. The UtilitySelector node prevents adding non-<a class="link" href= "UtilityEvaluator.md">UtilityEvaluator</a> nodes to this list.</td>
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