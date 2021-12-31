using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstructions : MonoBehaviour
{
    public string gameInstractuins = "Move the player ";

    byte sampleByte;//0-255
    int sampleInt;//
    float sampleFloat;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameInstractuins);
    }

  
}
