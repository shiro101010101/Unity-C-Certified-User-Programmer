using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float JumpForce = 5;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(new Vector2(0,JumpForce),ForceMode2D.Impulse);

        }

    }
}
