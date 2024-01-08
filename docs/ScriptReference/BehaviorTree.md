<h2 class="header">BehaviorTree</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p style="margin-right:10px">class in OpenBehaviorTrees</p>
        <p style="margin-right:10px">/</p>
        <p>inherits from: </p>
        <a class="link" href= "https://docs.unity3d.com/ScriptReference/MonoBehaviour.html">MonoBehavior</a>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>The behavior tree component. Should be added to any NPC or AI agent that you wish to make use of behavior trees.<p>

<h2 class="small-h2 header">Properties</h2>
<table class="table">
    <tbody>
        <tr>
            <td><a class="link" href = "BehaviorTreeNode.md">BehaviorTreeNode</a> rootNode</td>
            <td>The root of the behavior tree and the first node that is evaluated when the behavior tree ticks.</td>
        </tr>
           <tr>
            <td><a class="link" href = "BehaviorTreeNode.md">BehaviorTreeNode</a> activeSubTree</td>
            <td>If activeSubTree is not null, then when the behavior tree ticks, it will tick from activeSubTree instead of rootNode.</td>
        </tr>
        <tr>
            <td><a class="link" href = "Blackboard.md">Blackboard</a> blackboard</td>
            <td>The global data store for the behavior tree. A <a class="link" href="https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-8.0">Dictionary</a>&lt;<span class="variable-name">string</span>, <span class="variable-name">object</span>> used to access global data from <a class="link" href = "BehaviorTreeNode.md">BehaviorTreeNodes</a></td>
        </tr>
        <tr>
            <td><span class="variable-name">bool</span> paused</td>
            <td>If set to <span class="variable-name">true</span>, the behavior tree will not tick.</td>
        </tr>
        <tr>
            <td><span class="variable-name">bool</span> startOnEnable</td>
            <td>If set to <span class="variable-name">true</span>, the behavior tree will start running when <a class="link" href="https://docs.unity3d.com/ScriptReference/MonoBehaviour.OnEnable.html">OnEnable</a> is called. Otherwise, you will need to call <span class="variable-name">Setup()</span> manually to start the Behavior Tree. You may wish to do this if AI agents are loaded asynchronously.</td>
        </tr>
    </tbody>
</table>

<h2 class="small-h2 header">Public Methods</h2>
<table class="table">
    <tbody>
        <tr>
            <td><span class="variable-name">void</spawn> Setup()</td>
            <td>Creates a new <a class="link" href = "Blackboard.md">Blackboard</a> if blackboard is null, and generates the runtime instances of the <a class="link" href = "BehaviorTreeNode.md">BehaviorTreeNodes</a> in the tree. This is necessary for non-persistant runtime data, as <span class="variable-name">BehaviorTreeNode</span> inherits from <a class="link" href= "https://docs.unity3d.com/Manual/class-ScriptableObject.html">ScriptableObject</a>.</td>
        </tr>
    </tbody>
</table>
