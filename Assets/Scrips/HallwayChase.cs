using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayChase : MonoBehaviour
{
    public GameObject Cow;
    public GameObject PostProcess;

    void Start()
    {
        Cow.SetActive(false);
        PostProcess.SetActive(false);
    }
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Cow.SetActive(true);
        PostProcess.SetActive(true);
    }

}
