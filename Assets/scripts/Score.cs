using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public int punten;
    public Text score;

	// Use this for initialization
	void Start () {
        punten = 0;
	}
	
    public void puntErbij() {
        punten += 1;
        score.text = "Score = " + punten;
    }

	// Update is called once per frame
	void Update () {
		
	}
}
