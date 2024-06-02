public class BalancedBinaryTree
{
    public class Node
    {
        public string Data { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }

        public Node(string data)
        {
            Data = data;
        }
    }

    private Node? _root;

    private void AddRecursive(Node curr, Node toAdd)
    {
        if (curr.Left is null)
            curr.Left = toAdd;
        else if (curr.Right is null)
            curr.Right = toAdd;
        else
        {
            AddRecursive(curr.Left, toAdd);
            AddRecursive(curr.Right, toAdd);
        }
    }

    public void Add(Node node)
    {
        if (_root == null)
        {
            _root = node;
        }
        else
        {
            AddRecursive(_root, node);
        }
    }


    public void Iterate()
    {
        var queue = new Queue<Node>();

        queue.Enqueue(_root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            Console.Write(node.Data);
            if (node.Left is not null)
                queue.Enqueue(node.Left);

            if (node.Right is not null)
                queue.Enqueue(node.Right);
        }
    }
}