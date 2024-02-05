using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startingPosition;
    void Start()
    {
        //Debug.Log("I'm a start." + Time.frameCount);
        startingPosition = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        Transform siblingTransform = GetComponent<Transform>();

        float offset = Mathf.Sin(Time.time);
        siblingTransform.position = startingPosition + Vector3.right * offset;

        //Debug.Log("I'm an update." + Time.frameCount);
    }
}
