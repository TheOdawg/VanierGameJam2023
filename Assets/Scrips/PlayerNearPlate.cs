using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNearPlate : MonoBehaviour
{
    public float radius;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < radius) {

            Debug.Log("In range of plate :");

            this.gameObject.SetActive(false);

        }
    }
}
