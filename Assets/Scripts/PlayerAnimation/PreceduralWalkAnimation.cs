using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreceduralWalkAnimation : MonoBehaviour
{
    public float sinWaveOffset = 0;
    public float sinWaveSpeed = 1;

    // how far apart should the feet be?
    public float scaleX = 1;

    // how high the foot comes off the ground
    public float distanceY = 1;

    // how far forward / backward the foot goes
    public float distanceZ = 1;

    Vector3 startingPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float time = (Time.time + sinWaveOffset * Mathf.PI) * sinWaveSpeed;

        float offsetZ = Mathf.Sin(time);
        float offsetY = Mathf.Cos(time);
        if (offsetY < 0) offsetY = 0;

        Vector3 finalPosition = startingPosition;

        finalPosition.x *= scaleX;
        finalPosition.y += offsetY; // move final position up or down
        //finalPosition.z += offsetZ; // move final position forward or backward

        transform.localPosition = finalPosition;
    }
}
