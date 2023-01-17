using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LookAtPLayer : MonoBehaviour
{
    private Transform player;
    public Material cowSkin;
    public Material cowMeat;
    private bool hasTurned;
    public AudioSource mooing;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine("seeThatPlayer");
        mooing.SetScheduledStartTime(0.3);
    }

    // Update is called once per frame
    void Update()
    {

        if (hasTurned) {

            transform.LookAt(player);

        }
        
    }

    private IEnumerator seeThatPlayer() {

        yield return new WaitForSeconds(8f);
    //    player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(player);
        this.gameObject.GetComponentInChildren<MeshRenderer>().material =  cowMeat;
        mooing.Play();
        yield return new WaitForSeconds(0.5f);
        this.gameObject.GetComponentInChildren<MeshRenderer>().material = cowSkin;
        hasTurned=true;

    }
    
    }
