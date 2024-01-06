## How to Get Started

<p>The first thing to do is add the behavior tree component to a GameObject</p>
<br/>
<img class="centered" src="../images/Behavior-Tree-Component.png" alt="Behavior Tree Component" width="550"/>
<br/>
<br/>
<p>You will be presented with a button that allows you to create a new tree from a Behavior Tree Root node</p>
<br/>
<img class="centered" src="../images/Create-Node.png" alt="Create New Tree" width="550"/>
<br/>
<br/>
<p>Once you have created your new tree, you will be presented with the option to open it.</p>
<br/>
<img class="centered" src="../images/Open-Node.png" alt="Open Tree" width="550"/>
<br/>
<br/>

## The Node Editor Window

<p>You will be presented with a node editor window for managing and editing Behavior Trees. In the node editor, you can zoom using the scroll wheel, move around using the mouse, and select nodes for inspection. You can also select multiple nodes simultaneously by holding shift.</p>
<br/>
<img class="centered" src="../images/Behavior-Tree-Node-Window.png" alt="Open Tree" width="550"/>
<br/>
<br/>
<img class="centered" src="../images/Multi-Select-Drag.png" alt="Multi-Drag" width="550"/>
<br/>
<br/>
<p>You can also copy and paste nodes by right-clicking to open a context menu:</p>
<br/>
<img class="centered" src="../images/Copy-Paste.png" alt="Copy-Paste" width="550"/>
<br/>
<br/>

## Nodes List

<p>You can view all placeable nodes by opening the Nodes List sidebar. All non-abstract node types will be visible in this window, including any nodes that you create that inherit from the BehaviorTreeNode class. Also in the window will be any existing behavior trees you have created, which can be placed as a sub-tree. This helps with modularity and readibility of trees. You may search for nodes using the searchbar at the top of the nodes list view.</p>
<br/>
<img class="centered" src="../images/Nodes-List.png" alt="Nodes List" width="550"/>
<br/>
<br/>

## Inspector

<p>The Inspector window works exactly like the Unity's built-in inspector window. You may also set an icon for a Node type,
which will be visible in the project window and on the nodes in the Node Editor Window.</p>
<img class="centered" src="../images/Inspector.png" alt="Inspector" width="550"/>
<br/>
<br/>

## Final Notes

- Any changes made to the tree will only be applied by using the save button.
- Standard behavior tree node types are available, such as Selector, Sequencer, Inverter, Always Fail, and more.
- Also available is a UtilitySelector node, for implementing Utility AI/ GOAP behaviors. Children of UtilitySelector must inherit from UtilityEvaluator.
- Scripts are contained in the OpenBehaviorTree namespace.
- More Information about the blackboard can be found [Here](https://github.com/Sterberino/UnitySerializedDictionary)
