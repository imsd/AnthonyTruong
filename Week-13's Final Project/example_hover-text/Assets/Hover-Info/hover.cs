using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hover : MonoBehaviour {

	public string HoverText;

	public string SecondaryText;

	public TextMesh DisplayTextObject;

	public TextMesh SecondaryDisplayTextObject;

	public GameObject myImage;

	void OnMouseDown() {
		// switch the 3d text so that its text value
		// is now whatever text value this hover instance holds
		DisplayTextObject.text = HoverText;

		SecondaryDisplayTextObject.text = SecondaryText;

		// show it
		DisplayTextObject.color = Color.white;
		SecondaryDisplayTextObject.color = Color.white;

		myImage.SetActive (true);
	}

	void OnMouseExit() {
		DisplayTextObject.color = new Color(0,0,0,0);
		SecondaryDisplayTextObject.color = Color.white;

		myImage.SetActive (false);
	}
}
