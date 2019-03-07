using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holdPiece : MonoBehaviour {
    public GameObject GameLogic;
    public GameObject player;
    public PlayerPiece pieceBeingHeld;
    public bool holdingPiece = false;

    void Start () {}

    void Update(){}

        public void grabPiece(PlayerPiece selectedPiece) {
        if (selectedPiece.GetComponent<PlayerPiece>().hasBeenPlayed == false && GameLogic.GetComponent<GameLogic>().playerTurn) {
            pieceBeingHeld = selectedPiece;
            holdingPiece = true;
            selectedPiece.GetComponent<PlayerPiece>().inPlay();
        }
    }
	
    public void makeMove(GameObject GridPlate)
    {
        if (holdingPiece)
        {
            holdingPiece = false;
            pieceBeingHeld.GetComponent<PlayerPiece>().hasBeenPlayed = true;
            pieceBeingHeld.GetComponent<PlayerPiece>().PlayPiece(GridPlate);
            GameLogic.GetComponent<GameLogic>().playerMove(GridPlate);
        }
    }
}








