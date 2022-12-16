using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kilSayacai : MonoBehaviour
{
    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mermi")
        {
            anim.SetBool("Death", true);

        }
    }
}
