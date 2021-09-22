using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject Load;
    public Button tap;

    // Update is called once per frame
    void Update()
    {
        if (Load.transform.localScale.x > 7.2 )
        {
            tap.gameObject.SetActive(true);
        }
    }
}
