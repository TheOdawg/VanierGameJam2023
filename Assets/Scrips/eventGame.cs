using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class eventGame : MonoBehaviour
{
    public float plateRadius;
    public GameObject player;
    public TMP_Text TopObjectiveText;
    public GameObject plate1;
    public GameObject plate2;
    public GameObject plate3;
    public GameObject plate4;
    public GameObject plate5;
    bool platePickedUp1 = false;
    bool platePickedUp2 = false;
    bool platePickedUp3 = false;
    bool platePickedUp4 = false;
    bool platePickedUp5 = false;
    int platesCollected;

    // Start is called before the first frame update
    void Start()
    {
        TopObjectiveText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        TopObjectiveText.text = ("Plates Collected : " + platesCollected);
        if (platePickedUp1 == false) { platePickedUp1 = PlayerNearPlate(plate1, platePickedUp1); }
        if (platePickedUp2 == false) { platePickedUp2 = PlayerNearPlate(plate2, platePickedUp2); }
        if (platePickedUp3 == false) { platePickedUp3 = PlayerNearPlate(plate3, platePickedUp3); }
        if (platePickedUp4 == false) { platePickedUp4 = PlayerNearPlate(plate4, platePickedUp4); }
        if (platePickedUp5 == false) { platePickedUp5 = PlayerNearPlate(plate5, platePickedUp5); }
    }

    private bool PlayerNearPlate(GameObject plate, bool platePicked) 
    {

        if (Vector3.Distance(plate.transform.position, player.transform.position) < plateRadius)
        {

            Debug.Log("In range of plate :");
            platesCollected++;
            plate.gameObject.SetActive(false);
            platePicked = true;
            return platePicked;
        }
        else { return false; }

    }

}
