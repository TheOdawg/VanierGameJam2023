using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingCow : MonoBehaviour
{
    public GameObject Cow;
    // Start is called before the first frame update
    void Start()
    { Cow.SetActive(true); }

        void OnTriggerEnter()
    {
        Cow.SetActive(false);
    }

}
