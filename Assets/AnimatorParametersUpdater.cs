using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorParametersUpdater : MonoBehaviour
{
    public Animator animatorRef;
    public Rigidbody2D dwarfRigidbodyRef;

    void FixedUpdate()
    {
        animatorRef.SetFloat("Movement Speed", Mathf.Abs (dwarfRigidbodyRef.velocity.x));

        //savoir si on chute ? velocity.y est négatif*
        if(dwarfRigidbodyRef.velocity.y < 0)
        {
            animatorRef.SetBool("isFalling", true);
        }

        //si la vitesse est 0, on ne chute plus
        if (dwarfRigidbodyRef.velocity.y == 0)
        {
            animatorRef.SetBool("isFalling", false);
        }

        //savoir si on chute ? velocity.y est négatif*
        if (dwarfRigidbodyRef.velocity.y < 0)
        {
            animatorRef.SetBool("isFalling",    true);
            animatorRef.SetBool("IsAscending",  false);
        }

        //savoir si on monte ?
        if (dwarfRigidbodyRef.velocity.y > 0)
        {
            animatorRef.SetBool("IsAscending", true);
        }
    }

}
