using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParametersUpdater : MonoBehaviour
{
    public Animator animatorRef;
    public Rigidbody2D dwarfRigidbodyRef;


    private void Awake()
    {
    }

    private void Start()
    {
        animatorRef.SetTrigger("JumpTrigger");
    }


    private void FixedUpdate()
    {
        //
        animatorRef.SetFloat("RigidbodySpeed", dwarfRigidbodyRef.velocity.x);
    }

}
