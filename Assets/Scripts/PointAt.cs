using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAt : MonoBehaviour
{
    public Transform target;


    
    void Update()
    {
        if (target == null) return;

        Vector3 look = target.position - transform.position;
        look.Normalize();

        Quaternion targetRot = Quaternion.LookRotation(look, Vector3.up);
        transform.rotation = AnimMath.Lerp(transform.rotation, targetRot, .01f);
    }
}
