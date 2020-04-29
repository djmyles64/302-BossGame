using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipBounce : MonoBehaviour
{
    public float sinwaveSpeed = 7;
    public float sinwaveOffset = 0;
    public float sinwaveAmp = .001f;

    public float bounceAmplitude = .001f;
    public float rockingAmplitude = 1f;

    Vector3 startingPosition;
    Quaternion startingRotation;

    void Start()
    {
        startingPosition = transform.localPosition;
        startingRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        float bounceAmount = Mathf.Sin((Time.time + sinwaveOffset * Mathf.PI) * 7);

        transform.localPosition = startingPosition + new Vector3(0, bounceAmount, 0) * bounceAmplitude;
        transform.localRotation = startingRotation * Quaternion.Euler(0, 0, bounceAmount * rockingAmplitude);
    }
}
