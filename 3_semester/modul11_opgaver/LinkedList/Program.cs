using LinkedList;

User kristian = new User("Kristian", 1);
User mads = new User("Mads", 2);
User torill = new User("Torill", 3);
User kell = new User("Kell", 4);
User henrik = new User("Henrik", 5);
User klaus = new User("Klaus", 6);
User anders = new User("Anders", 0);
User jacob = new User("Jacob", 7);

UserLinkedList list = new UserLinkedList();
list.AddFirst(kristian);
list.AddFirst(mads);
list.AddFirst(torill);
list.AddFirst(henrik);
list.AddFirst(klaus);

Console.WriteLine(list.CountUsers());
Console.WriteLine(list);

list.RemoveUser(mads);
list.RemoveFirst();

Console.WriteLine(list.CountUsers());
Console.WriteLine(list);

Console.WriteLine(list.Contains(henrik));


SortedUserLinkedList newList = new SortedUserLinkedList();
newList.Add(kristian);
newList.Add(mads);
newList.Add(torill);
newList.Add(henrik);
newList.Add(anders);
newList.Add(jacob);

Console.WriteLine(newList);