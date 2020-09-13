using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCont : MonoBehaviour
{
    GameManager gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerStay(Collider col)
    {
        gm.One = col.gameObject;  
    }
}
