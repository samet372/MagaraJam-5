using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FatherDeath : MonoBehaviour
{
    Animator anim;
  
    public GameObject nextLevel;
    void Start()
    {
        anim = GetComponent<Animator>();
        nextLevel.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Mermi")
        {
            anim.SetBool("Death", true);         
            nextLevel.SetActive(true);
        }
    }
}
