using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public GameObject namlu;
    public GameObject _mermi;
    public GameObject ben;

    void AtesYonu()
    {
        gameObject.transform.rotation = ben.transform.rotation;
    }

    IEnumerator Mermi()
    {
        yield return new WaitForSeconds(1f);
        GameObject mermi = Instantiate(_mermi, namlu.transform.position, namlu.transform.rotation) as GameObject;
        Rigidbody fizik = mermi.GetComponent<Rigidbody>();
        fizik.AddForce(-transform.forward * 1500);

    }
    
}