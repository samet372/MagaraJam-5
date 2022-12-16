using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MagaraJam5.Controller
{
    public class PlayerAnimation : MonoBehaviour
    {
        Animator _anim;
        void Start()
        {
            _anim = GetComponent<Animator>();
        }
        void Update()
        {
            if (Input.GetKey(KeyCode.W))
            {
                _anim.SetBool("_kosuyorMu", true);
            }
            else
            {
                _anim.SetBool("_kosuyorMu", false);
            }
        }
    }
}

