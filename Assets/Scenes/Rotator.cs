using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    public float yawDegreePerSecond = 45f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform rotateTransform = GetComponent<Transform>();
        rotateTransform.Rotate(new Vector3(0f, yawDegreePerSecond * Time.deltaTime, 0f), Space.World);
        
    }
}
