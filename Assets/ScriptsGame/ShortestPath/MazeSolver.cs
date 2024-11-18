using UnityEngine;
using System.Collections.Generic;
using Sirenix.OdinInspector;

public class MazeSolver : SerializedMonoBehaviour
{

    [SerializeField] private Vector2Int _matrixSize;
    [SerializeField] private HoldingBase[,] _maze;

    public static MazeSolver instance;

    [SerializeField] private GameController _gameController;

    private void Awake()
    {
        instance = this;
    }

    public List<HoldingBase> FindPath(HoldingBase start, HoldingBase end)
    {
        SetMaze(_gameController.holdingBases);
        AStarNode[,] nodes = new AStarNode[_matrixSize.x, _matrixSize.y];
        for (int x = 0; x < _matrixSize.x; x++)
        {
            for (int y = 0; y < _matrixSize.y; y++)
            {
                nodes[x, y] = new AStarNode(new Vector2Int(x, y), _maze[x, y]);
            }
        }

        List<AStarNode> path = AStar.FindPath(nodes, start.Position, end.Position);

        List<HoldingBase> holdingBasePath = new List<HoldingBase>();
        foreach (AStarNode node in path)
        {
            holdingBasePath.Add(node.HoldingBase);
        }

        return holdingBasePath;
    }

    private void SetMaze(List<HoldingBase> holdingBases)
    {
        if (_matrixSize.x <= 0 || _matrixSize.y <= 0)
        {
            return;
        }

        _maze = new HoldingBase[(int)_matrixSize.x, (int)_matrixSize.y];

        int a = 0;
        for (int x = 0; x < _matrixSize.x; x++)
        {
            for (int y = 0; y < _matrixSize.y; y++)
            {
                _maze[x, y] = holdingBases[a];
                a += 1;
            }
        }
    }
}
