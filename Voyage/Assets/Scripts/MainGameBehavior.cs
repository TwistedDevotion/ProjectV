using UnityEngine;
using System.Collections;

public class MainGameBehavior : MonoBehaviour
{
	public GameObject cube;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		cube.transform.position += new Vector3(0.5f, 0, 0);
		
		if (Input.GetMouseButtonDown(0))
		{
			cube.animation.Play("AnimationCube");
		}
	}
}
