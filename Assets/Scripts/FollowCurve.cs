using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCurve : MonoBehaviour
{
    public BezierCurve curve;
    [Range(0, 1)] public float percent = 0;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(curve)
        {
            transform.position = curve.FindPositionAt(percent);
        }
    }
}
