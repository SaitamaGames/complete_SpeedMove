using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
	
	public static float speed = 0;
	
	public static float Score = 0;
	
	[SerializeField] Text speedText;
	[SerializeField] Text scoreText;
	[SerializeField] GameObject Gameover;

	void Start () 
	{
		Score = 0;
		Gameover.gameObject.SetActive (false);
	}
	
	void Update ()
	{
		
		if( CameraMain.gameOver  )  
		{
			Gameover.gameObject.SetActive (true);
			if( Input.GetMouseButtonDown(0))
			{
				Application.LoadLevel("Title");
			}
		}
		speedText.text = " speed " + (int)speed;
		scoreText.text = " Score " + (int)Score;

	}	
}
