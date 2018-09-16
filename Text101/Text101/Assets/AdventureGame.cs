using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// Use this for initialization
	void Start () {
        textComponent.text = "This is the story of a witcher who went by the name of Geralt.";	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
