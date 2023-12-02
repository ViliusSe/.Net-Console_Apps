// Delegates

using _20231130HomeWork;

Person person1 = new Person("Jhon", 12);
Person person2 = new Person("Steve", 25);
Person person3 = new Person("Mark", 17);
Person person4 = new Person("Antonio", 75);
Person person5 = new Person("Sandra", 32);

List<Person> personslist = new List<Person> { person1, person2, person3, person4, person5 };

Filters f = new Filters();
FilterFunction functionIsChild = new FilterFunction(PersonService.IsChild);
FilterFunction functionIsAdult = new FilterFunction(PersonService.IsAdult);
FilterFunction functionIsSenior = new FilterFunction(PersonService.IsSenior);

f.DisplayPeople("Children", personslist, functionIsChild);
f.DisplayPeople("Adult", personslist, functionIsAdult);
f.DisplayPeople("Senior", personslist, functionIsSenior);


//LINQ

