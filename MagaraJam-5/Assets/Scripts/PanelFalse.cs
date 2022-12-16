using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFalse : MonoBehaviour
{
    public GameObject panel;
    public GameObject player;

    private void Start()
    {
        panel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            panel.SetActive(true);
            player.SetActive(false);
        }
    }

}
