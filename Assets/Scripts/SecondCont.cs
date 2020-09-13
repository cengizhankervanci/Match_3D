using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCont : MonoBehaviour
{
    GameManager gm;
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerStay(Collider col)
    {
        gm.Two = col.gameObject;
    }
}
