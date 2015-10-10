using UnityEngine;
using System.Collections;

public class CameraMain : MonoBehaviour {
	
	public static bool gameOver = false;
	

	// Use this for initialization
	void Start () {
		gameOver = false;
		collider.isTrigger = true;
	}
		
	public float nowSpeed = 2.5f;
	public float speedPluse = 0.2f;
	
	// Update is called once per frame
	void Update () {
	
		if( gameOver )
		{
			return;
		}
		
		nowSpeed += Time.deltaTime * speedPluse;
		
		
		
		if( Input.GetMouseButton(0))
		{
			if( Input.mousePosition.x > Screen.width/2 )
			{
				transform.localPosition = new Vector3(
					transform.localPosition.x + Time.deltaTime * nowSpeed ,
					transform.localPosition.y ,
					transform.localPosition.z );
			}else
			{
				transform.localPosition = new Vector3(
					transform.localPosition.x - Time.deltaTime * nowSpeed ,
					transform.localPosition.y ,
					transform.localPosition.z);
			}
		}
		
		
	}
	
	private void OnTriggerEnter (Collider other)
	{
		if( other.tag != "Respawn")
		{
			gameOver = true;
		}
		
	}
		
	
	
	
}
