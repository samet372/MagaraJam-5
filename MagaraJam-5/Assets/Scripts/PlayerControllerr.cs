using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MagaraJam5.Controller
{
    public class PlayerControllerr : MonoBehaviour
    {
        CharacterController controller;
        AudioSource source;

        Vector3 velocity;
        bool isGrounded;
        public bool isMoving;

        public Transform ground;
        public float distance = 0.3f;

        public float speed;
        public float jumpHeight;
        public float gravity;

        public LayerMask mask;

        public float timeBetweenSteps;
        float timer;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
            source = GetComponent<AudioSource>();
        }

        private void Update()
        {
            #region Movement
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 move = transform.right * horizontal + transform.forward * vertical;
            controller.Move(move * speed * Time.deltaTime);
            #endregion

            #region Audio
            if (horizontal != 0 || vertical != 0)
            {
                isMoving = true;
            }
            else
                isMoving = false;

            if (isMoving && isGrounded)
            {
                timer -= Time.deltaTime;

                if (timer <= 0)
                {
                    timer = timeBetweenSteps;
                    source.Play();
                }
            }
            else
            {
                timer = timeBetweenSteps;
            }

            #endregion

            #region Jump
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {
                velocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
            }
            #endregion

            #region Gravity
            isGrounded = Physics.CheckSphere(ground.position, distance, mask);

            if (isGrounded && velocity.y < 0)
            {
                velocity.y = 0f;
            }

            velocity.y += gravity * Time.deltaTime;
            controller.Move(velocity * Time.deltaTime);
            #endregion
        }
    }

}
