public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else if (Left is not null && !Left.Contains(value))
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else if (Right is not null && !Right.Contains(value))
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value < Data)
        {
            if (Left is null)
            {
                return false;
            }
            return Left.Contains(value);
        }

        else if (value > Data)
        {
            if (Right is null)
            {
                return false;
            }
            return Right.Contains(value);
        }
        else
        { // If value == Data, then return true
            return true;
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        if (this == null)
        {
            return 0;
        }

        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        return Math.Max(leftHeight, rightHeight) + 1; // Replace this line with the correct return statement(s)
    }
}