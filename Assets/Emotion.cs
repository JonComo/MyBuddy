using UnityEngine;
using System.Collections;

public class Emotion : MonoBehaviour {

	public int offset = 0;
	public Renderer rend;
	public Texture[] textures;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (offset == 5) {
			rend.material.mainTexture = textures[1];
		}

		if (offset == 20) {
			rend.material.mainTexture = textures [0];
		}

		if (offset == 200) {
			offset = 0;
		}

		offset += 1;
	}
}
