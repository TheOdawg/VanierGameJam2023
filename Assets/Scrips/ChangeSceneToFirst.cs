using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeSceneToFirst : MonoBehaviour
{

    public void LoadSceneOne() { 
            SceneManager.LoadScene("Home");
            Debug.Log("change scene");
        
    }

}