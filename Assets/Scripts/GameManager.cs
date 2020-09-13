using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;
    bool dest=false;

    void Start()
    {
        One = null;
        Two = null;
    }


    void Update()
    {
        if (One!=null && Two!=null && One.gameObject.name!=Two.gameObject.name)
        {
            if (One.gameObject.tag == Two.gameObject.tag)
            {
                dest = true;
                StartCoroutine("WaitTime");
            }
        }
    }

    IEnumerator WaitTime()
    {
        yield return new WaitForSeconds(1f);
        if (dest)
        {
            Destroy(One);
            Destroy(Two);
        }
        dest = false;
    }

}
