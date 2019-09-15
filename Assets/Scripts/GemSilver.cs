using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemSilver : MonoBehaviour
{
    
    public GameObject ScoreBox;

    void OnTriggerEnter() {
        Destroy(gameObject);
    }


}
