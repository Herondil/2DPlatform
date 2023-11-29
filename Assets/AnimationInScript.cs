using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationInScript : MonoBehaviour
{
    public Vector3 destination;
    public Vector3 depart;

    float counter = 0;


    // Update is called once pe r frame
    void Update()
    {
        transform.position = Vector3.Slerp(depart, destination, counter);

        //Debug.Log(Vector3.Slerp(depart, destination, counter));

        counter += 0.001f;
    }
}
