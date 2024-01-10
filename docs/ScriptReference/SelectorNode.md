<h2 class="header">SelectorNode</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
        <a class="link" href= "CompositeNode.md">CompositeNode</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p> A composite node that runs all of its children in order. Sometimes referred to as a <a class="link" href= "https://en.wikipedia.org/wiki/Behavior_tree_(artificial_intelligence,_robotics_and_control)#Selector_(fallback)_node">Fallback Node</a> in other implementations.</p>
<br/>
<p> For each child, if the child returns success, the Selector returns success.</p>
<p>If the child returns running, the selector returns running and will start from that child next time it is ticked. </p>
<p>If no child returns success or running, the Selector returns failure.</p>

<h2 class="small-h2 header">Inherited Members</h2>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td>List<<a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>> children</td>
            <td>A list of children nodes.</td>
        </tr>
        <tr>
            <td><a class="link" href = "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a> lastStatus</td>
            <td>The result of the last <a class="link" href = "BehaviorTreeNode-Tick.md">Tick</a> call.</td>
        </tr>
        <tr>
            <td><a class="link" href = "BehaviorTreeNodeEvent.md">BehaviorTreeNodeEvent</a> onTick</td>
            <td>Event invoked after <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> is called, before the result of <a class="link" href = "BehaviorTreeNode-Tick.md">Tick</a> is returned.</td>
        </tr>
        </tr>
    </tbody>
</table>

<h2 class="small-h2 header">Public Methods</h2>
<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-Tick.md">Tick</a></td>
            <td>Ran when the behavior tree ticks. Wraps the <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> method and caches the result.</td>
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

<h2 class="small-h2 header">Protected Methods</h2>
<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a></td>
            <td>Ran when the behavior tree ticks, in the Tick method. Override this method to implement custom behavior.</td>
        </tr>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-OnInit.md">OnInit</a></td>
            <td>Ran when the node ticks for the first time, before <a class="link" href = "BehaviorTreeNode-OnStart.md">OnStart</a>. Override this method to implement custom setup functionality for your BehaviorTreeNode, such as caching references.</td>
        </tr>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode-OnStart.md">OnStart</a></td>
            <td>Ran when the node ticks for the first time, after <a class="link" href = "BehaviorTreeNode-OnInit.md">OnInit</a>. Override this method to implement custom functionality to be ran before the first tick.</td>
        </tr>
    </tbody>
</table>