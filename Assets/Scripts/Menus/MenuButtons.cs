using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{

    public Transform Indicator_1;


    // Start is called before the first frame update
    void Start()
    {
        Indicator_1.gameObject.SetActive(false);
    }

    public void mouseIn()
    {
        Indicator_1.gameObject.SetActive(true);
    }

    public void mouseOut()
    {
        Indicator_1.gameObject.SetActive(false);
    }
}
