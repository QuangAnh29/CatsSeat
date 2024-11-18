using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingBase : HCMonoBehaviour
{
    [SerializeField] private bool _canMove;
    public Vector2Int Position;

    public bool CanMove
    {
        get
        {
            return _canMove;
        }
        set
        {
            _canMove = value;
        }
    }
}
