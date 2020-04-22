using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyFeet : MonoBehaviour
{
    Vector3 plantedPositionLast;
    Vector3 plantedPositionNext;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        CheckIfCanMoveFoot();
        AnimateFoot();

    }
    void AnimateFoot()
    {

    }
    void CheckIfCanMoveFoot()
    {
        DoRaycast();
    }
    void DoRaycast ()
    {

    }
}
