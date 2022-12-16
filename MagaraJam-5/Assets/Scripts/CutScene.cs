using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MagaraJam5.Controller
{
    public class CutScene : MonoBehaviour
    {
        public GameObject playerControl;
        public GameObject cutSceneCam;
        public GameObject silah;
        public GameObject deathLight;

        AudioSource source;
        private void Start()
        {
            cutSceneCam.SetActive(false);
            source = GetComponent<AudioSource>();
            deathLight.SetActive(false);
            silah.SetActive(false);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                cutSceneCam.SetActive(true);
                playerControl.SetActive(false);
                source.Play();
                StartCoroutine(CameraSeconds());
            }
        }


        IEnumerator CameraSeconds()
        {
            yield return new WaitForSeconds(9f);
            playerControl.SetActive(true);
            cutSceneCam.SetActive(false);
            silah.SetActive(true);
            yield return new WaitForSeconds(1f);
            deathLight.SetActive(true);
            Destroy(gameObject);
            
        }

    }

}
