using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugDrawSphere : HCMonoBehaviour
{
    [SerializeField] private float _radius = 0.5f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(this.transform.position, _radius);
    }

}
