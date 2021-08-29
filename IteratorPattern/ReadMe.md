# Iterator Pattern
> The Iterator Pattern provides a way to access the elements of an aggregate object
sequentially without exposing its underlying representation.

##UML Diagram
![Iterator Pattern UML Diagram](https://upload.wikimedia.org/wikipedia/commons/1/13/Iterator_UML_class_diagram.svg)

##Project Info
A Hardware Store Inventory System.
There are different Items in the Inventory like.
1. Nuts.
2. Bolts.
3. Screws.
4. Glue.
5. Rods
6. Doors and etc

Each Item has an Id, Description and realted properties.

##Problem to solve
Create a list of all the Items with their Ids.

##Important Points
1. Using Iterator Pattern the Aggregate is relieved from the logic of Iteration, 
which is delegated to Iterator class establishing Single Responsibility Principle.
2. Note that here we are coding to Interface and not to Implementation. The Program.cs class using the IInventory interface and not its concerete implemetaion
which is Iterator.cs
3. Because of Iterator the undelying implementations of the Inventory classes is hidden from the client, Program.cs in this case. 
4. In the Inventory classes we always return new Instance of the Iterator. This is beacuse of "index" property in the Iterator Class.
5. Check out "Seeder" class implementation.
6. In C# build in Interfaces IEnumerable and IEnumerator are present which can be used instead of Interfaces IIterable and IIterator.
7. List<T> already has a build in Enumerator defined which can be returned instead of Iterator.cs class 
`GlueCollection.GetEnumerator()` will return the enumertor for the list.
