namespace LinkedList
{
    class SortedUserLinkedList
    {
        private Node first = null;

        public void Add(User user)
        {
            if (first == null! || user.Id < first.Data.Id)
            {
                Node node = new Node(user, first);
                first = node;
            }
            else
            {
                Node node = first;

                while (node.Next != null)
                {
                    if (node.Next.Data.Id > user.Id)
                    {
                        node.Next = new Node(user, node.Next);

                        return;
                    }
                    else
                    {
                        node = node.Next;
                    }
                    
                }

                node.Next = new Node(user, null);
            }


        }

        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + " ID: " + node.Data.Id + ", ";
                node = node.Next;
            }
            return result.Trim();
        }
        
        public User GetFirst()
        {
            return first.Data;
        }

    }

}