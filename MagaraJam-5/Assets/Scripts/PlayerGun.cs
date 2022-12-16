using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject _namlu;
    public GameObject _mermi;
    AudioSource source;

    [SerializeField]
    float _bulletSpeed = 3;

    bool atisSerbest;
    private void Start()
    {
        source = GetComponent<AudioSource>();
        atisSerbest = true;
    }
    private void FixedUpdate()
    {
        
        if (Input.GetButtonDown("Fire1") && atisSerbest == true)
        {
            GameObject mermi = Instantiate(_mermi, _namlu.transform.position, _namlu.transform.rotation) as GameObject;
            Rigidbody fizik = mermi.GetComponent<Rigidbody>();
            fizik.AddForce(-transform.forward * _bulletSpeed);
            source.Play();
            atisSerbest = false;
            StartCoroutine(AtisSerbest());
        }
    }

    IEnumerator AtisSerbest()
    {
        yield return new WaitForSecondsRealtime(.8f);
        atisSerbest = true;
    }
    
}
