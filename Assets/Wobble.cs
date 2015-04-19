using UnityEngine;
using System.Collections;

public class Wobble : MonoBehaviour {
	public float amount = 10.0f;
	public float speed = 1.0f;
	public float offset = 0.0f;
	private Vector3 rotation = Vector3.zero;
	
	void Start () {
	}
	
	void Update () {
		offset += 0.005f;
		rotation.x = Mathf.PerlinNoise(offset, offset * 2.0f) * 4.0f - 2.0f;
		rotation.y = Mathf.PerlinNoise(offset + 10.0f, offset * 2.0f + 10.0f) * 4.0f - 2.0f;
		rotation.z = Mathf.PerlinNoise (offset + 20.0f, offset * 2.0f + 20.0f) * 4.0f - 2.0f + 180.0f;
		transform.localEulerAngles = rotation;
	}
}