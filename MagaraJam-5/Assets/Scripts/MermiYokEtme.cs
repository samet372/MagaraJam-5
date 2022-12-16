using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiYokEtme : MonoBehaviour
{
    public int kill;

    private void Start()
    {
        kill = 0;
    }
    private void OnCollisionEnter(Collision collision)
    {
        kill += 1;
        Destroy(gameObject);
    }
}
