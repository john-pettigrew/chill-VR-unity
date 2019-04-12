using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDrops : MonoBehaviour {
	public float frameTime = 2;
	public float frameWidth = 128;
	public float maxWidth = 512;
	public float startingOffset = 0;

	private Renderer rend;
	private float currentShift = 0;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		currentShift = startingOffset;
		InvokeRepeating("ShiftTexture", 0, frameTime);
	}

	private void ShiftTexture(){
		if(currentShift + frameWidth > maxWidth){
			currentShift = 0;
		}

		rend.material.SetTextureOffset("_MainTex", new Vector2(currentShift, 0));

		currentShift += frameWidth;
	}
}
