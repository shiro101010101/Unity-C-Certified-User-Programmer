using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 cameraVelocity;
    [SerializeField] float smoothTime = 1;
    [SerializeField ]bool lookAtPlayer;
    [SerializeField] int lowerlimit = -2;



    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
        if (player.position.y > lowerlimit)
        {

            Vector3 targetPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref cameraVelocity, smoothTime);
            if (lookAtPlayer == true)
            {
                transform.LookAt(player);
            }

        }
    }
}
