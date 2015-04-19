using UnityEngine;
using System.Collections;

public class MatFlow : MonoBehaviour {

	public Renderer rend;
	private float offset = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		offset += 0.01f;
		rend.material.mainTextureOffset = new Vector2 (0.0f, offset);
	}
}
