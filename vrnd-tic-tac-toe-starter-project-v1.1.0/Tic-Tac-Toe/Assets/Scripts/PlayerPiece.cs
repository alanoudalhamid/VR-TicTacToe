using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPiece : MonoBehaviour {
    public bool hasBeenPlayed = false;
    Vector3 OriginalLocation;
    Vector3 SelectedLocation;



    // Use this for initialization
    void Start () {}
	
	// Update is called once per frame
	void Update () {}

    public void inPlay() {
        OriginalLocation = this.transform.position;
        SelectedLocation = new Vector3(OriginalLocation.x, OriginalLocation.y + 0.3f, OriginalLocation.z);
        this.transform.position = SelectedLocation;
        //StartCoroutine(SmoothMove(SelectedLocation));
        GetComponent<Collider>().enabled = false;
    }

    public void PlayPiece(GameObject GridPlate) {
        hasBeenPlayed = true;
        GridPlate.GetComponent<Collider>().enabled = false;
        SelectedLocation = new Vector3(GridPlate.transform.position.x, GridPlate.transform.position.y, GridPlate.transform.position.z);
        //this.transform.position = new Vector3(GridPlate.transform.position.x, GridPlate.transform.position.y + 0.3f, GridPlate.transform.position.z);
        this.transform.position = SelectedLocation;
        //StartCoroutine(SmoothMove(SelectedLocation));
        //Tell our GameLogic script to occupy the game board array at the right location with a player piece
    }

    /*public void SmoothMove(Vector3 toLocation)
    {
       /* float closeEnough = 0.01f;
        float distance = (this.transform.position - toLocation).magnitude;
        WaitForEndOfFrame wait = new WaitForEndOfFrame();/////////
        while (distance >= closeEnough)
        {
            transform.position = Vector3.Slerp(this.transform.position, toLocation, 0.1f);
            yield return wait;
            distance = (this.transform.position - toLocation).magnitude;
        }
        this.transform.position = toLocation;
    }*/
}
