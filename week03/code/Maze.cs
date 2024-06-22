/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft()
    {
        // FILL IN CODE
        foreach (var value in _mazeMap)
        {
            var key = value.Key;
            var values = value.Value;

            if (values[0] == false)
            {
                Console.WriteLine("Can't go that way!");
            }

            //Moving
            _currX = key.Item1;
        }

    }

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight()
    {
        // FILL IN CODE
        foreach (var value in _mazeMap)
        {
            var key = value.Key;
            var values = value.Value;

            if (values[1] == false)
            {
                Console.WriteLine("Can't go that way!");
            }
            _currX = key.Item1;
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp()
    {
        // FILL IN CODE
        foreach (var value in _mazeMap)
        {
            var key = value.Key;
            var values = value.Value;

            if (values[2] == false)
            {
                Console.WriteLine("Can't go that way!");
            }
            _currY = key.Item2;
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown()
    {
        // FILL IN CODE
        foreach (var value in _mazeMap)
        {
            var key = value.Key;
            var values = value.Value;

            if (values[3] == false)
            {
                Console.WriteLine("Can't go that way!");
            }
            _currY = key.Item2;
        }
    }

    public void ShowStatus()
    {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}