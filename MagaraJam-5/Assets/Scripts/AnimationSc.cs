using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSc : MonoBehaviour
{
    Animation _anim;


    private void Start()
    {
        _anim = GetComponent<Animation>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "FatherAnim")
        {

        } 
    }
}
