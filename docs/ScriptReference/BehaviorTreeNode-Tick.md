<h2 class="header"><a class="link" href= "BehaviorTreeNode.md">BehaviorTreeNode</a>.Tick</h2>

<div class="flex-row space-between">
    <div class="flex-row">
        <p>public </p>
        <a class="link" href= "BehaviorTreeNodeResult.md">BehaviorTreeNodeResult</a>
        <p>Tick(<a class="link" href="BehaviorTree.md">BehaviorTree</a> behaviorTree);</p>
    </div>
    <a class="link" style="text-align: right" href="mailto:zacharyruiz1@gmail.com" target="_blank">Leave Feedback</a>
</div>

<h2 class="small-h2 header">Description</h2>
<p>Ran when the behavior tree ticks. If it is the first time Tick has been called on the node, calls <a class="link" href="BehaviorTreeNode-OnInit.md">OnInit</a> and then <a class="link" href="BehaviorTreeNode-OnStart.md">OnStart</a>. Then, calls <a class="link" href = "BehaviorTreeNode-Evaluate.md">Evaluate</a> and caches the result in the node's lastStatus property. If you are creating a custom <a class="link" href= "DecoratorNode.md">DecoratorNode</a> or <a class="link" href= "CompositeNode.md">CompositeNode</a>, you will want to call the child nodes' Tick method.<p>
