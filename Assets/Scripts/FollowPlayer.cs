using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour 
{
	public Transform Player;

	private Vector3 offset;

	private void Start ()

	{
		offset = GetComponent<Transform>().position - Player.position;
	}
	// Use this for initialization

	
	// Update is called once per frame
	private void Update () 
	{
		GetComponent<Transform>().position = Player.position + offset;
		
	}
}
