namespace LinkedList
{
    class Node
    {
        public Node(User data, Node next)
        {
            this.Data = data;
            this.Next = next;
        }
        public User Data;
        public Node Next;
    }

    class UserLinkedList
    {
        private Node first = null!;

        public void AddFirst(User user)
        {
            Node node = new Node(user, first);
            first = node;
        }

        public User RemoveFirst()
        {
            Node removedNode = first;
            if (first == null) {
                return null!;
            } else {
                first = first.Next;
                return removedNode.Data;
            }
        }

        public void RemoveUser(User user)
        {
            Node node = first;
            Node previous = null!;
            bool found = false;

            while (!found && node != null)
            {
                if (node.Data.Name == user.Name)
                {
                    found = true;
                    if (node == first)
                    {
                        RemoveFirst();
                    }
                    else
                    {
                        previous.Next = node.Next;
                    }
                }
                else
                {
                    previous = node;
                    node = node.Next;
                }
            }
        }

        public User GetFirst()
        {
            return first.Data;
        }

        public User GetLast()
        {
            Node node = first;
            if (first == null) 
            {
                return null;
            }
            else 
            {
                while (node.Next != null!)
                {
                    node = node.Next;
                }
                return node.Data;
            }
            


        }

        public int CountUsers()
        {
            int sum = 0;
            Node node = first;

            if (first == null)
            {
                return -1;
            }
            else
            {
                sum += 1;
                while (node.Next != null)
                {
                    sum += 1;
                    node = node.Next;
                }
                return sum;
            }
        }



        public override String ToString()
        {
            Node node = first;
            String result = "";
            while (node != null)
            {
                result += node.Data.Name + ", ";
                node = node.Next;
            }
            return result.Trim();
        }
        public bool Contains(User user)
        {
            Node node = first;

            if (first == null)
            {
                return false;
            }
            else 
            {
                while (node.Data != null)
                {
                    if (node.Data == user) 
                    {
                        return true;
                    } else 
                    {
                        node = node.Next;
                    }
                }
                return false;
            }
        }
    }
}