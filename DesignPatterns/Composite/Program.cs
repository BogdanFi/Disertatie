using Composite;

var leaf1 = new Leaf("Frunza 1");
var leaf2 = new Leaf("Frunza 2");
var leaf3 = new Leaf("Frunza 3");
var leaf4 = new Leaf("Frunza 4");
var leaf5 = new Leaf("Frunza 5");

var tree = new Composite.Composite("Parinte");
var tree2 = new Composite.Composite("Copil");
var tree3 = new Composite.Composite("Nepot");
tree.Add(leaf1);
tree2.Add(leaf2);
tree2.Add(leaf3);
tree3.Add(leaf4);
tree3.Add(leaf5);
tree.Add(tree2);
tree2.Add(tree3);

tree.Draw();