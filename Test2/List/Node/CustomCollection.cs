//namespace Learning.List.Node
//{
//    internal class CustomCollection
//    {
//        public class LinkedList<T>
//        {
//            private Node<T> firstNode;
//            private Node<T> lastNode;

//            public LinkedList()
//            {
//            }

//            public int Count { get; set; }

//            public bool IsEmpty(T value)
//            {
//                if (firstNode == null)
//                {
//                    return true;
//                }
//                else return false;
//            }

//            public void AddToEnd(T value)
//            {
//                var newNode = new Node<T>(value);

//                if (firstNode == null)
//                {
//                    firstNode = newNode;
//                    lastNode = newNode;

//                    Count++;

//                    return;
//                }

//                lastNode.NextNode = newNode;
//                lastNode = newNode;

//                Count++;
//            }
//            public int GetCount(T value)
//            {
//                var newNode = new Node<T>(value);
//                var currentNode = firstNode;
//                var valueCount = 0;

//                while (Count != null)
//                {
//                    if (currentNode.Value.Equals(value) == true)
//                    {
//                        firstNode = currentNode.NextNode;

//                        Count--;
//                        valueCount++;
//                    }

//                    currentNode = currentNode.NextNode;
//                }

//                return valueCount;
//            }
//            public void AddToHead(T value)
//            {
//                var newNode = new Node<T>(value);

//                if (lastNode == null)
//                {
//                    firstNode = newNode;
//                    lastNode = newNode;

//                    Count++;

//                    return;
//                }

//                firstNode.NextNode = newNode;
//                firstNode = newNode;

//                Count++;
//            }

//            public void Delete(T value)
//            {
//                var previousNode = firstNode;
//                var currentNode = firstNode;

//                if (firstNode == null)
//                {
//                    return;
//                }

//                do
//                {
//                    if (currentNode.Value?.Equals(value) == true)
//                    {
//                        if (previousNode == currentNode)
//                        {
//                            firstNode = currentNode.NextNode;
//                        }
//                        else
//                        {
//                            previousNode.NextNode = currentNode.NextNode;
//                        }

//                        Count--;

//                        return;
//                    }

//                    previousNode = currentNode;
//                    currentNode = currentNode.NextNode;
//                }
//                while (currentNode.NextNode != null);
//            }
//        }
//    }
//}
