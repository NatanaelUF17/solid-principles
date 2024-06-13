var parent = new Person { Name = "Nate" };
var firstChild = new Person { Name = "Nathan" };
var secondChild = new Person { Name = "Ethan" };

var relationships = new Relationships();

relationships.AddParentAndChild(parent, firstChild);
relationships.AddParentAndChild(parent, secondChild);

_ = new Research(relationships, parent);