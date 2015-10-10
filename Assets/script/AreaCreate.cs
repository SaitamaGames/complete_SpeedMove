using UnityEngine;
using System.Collections;

public class AreaCreate : MonoBehaviour {
	
	public GameObject[] CreateAreas;
	
	GameObject[] Areas = new GameObject[10];
	
	// Use this for initialization
	void Start () {
	
		for(int i = 0;i < Areas.Length; i++)
		{
			Areas[i] = null;
			{
				Areas[i] = (GameObject)Instantiate( CreateAreas[Random.Range(0,CreateAreas.Length)]) ;
				Areas[i].transform.localPosition = new Vector3(0,0,i*30);
				Areas[i].transform.parent = this.transform;
			}
		}
	}
	
	public float nowSpeed = 2f;
	public float speedPluse = 0.2f;
	public float EriaWidth = 30;
	
	// Update is called once per frame
	void Update () {
		
		nowSpeed += Time.deltaTime * speedPluse;
	
		if( CameraMain.gameOver == false)
		{
			score.speed = nowSpeed ;			
			score.Score += nowSpeed ;
		}
		
		
		for(int i = 0;i < Areas.Length; i++)
		{
			if( Areas[i] == null)
			{
				Areas[i] = (GameObject)Instantiate( CreateAreas[Random.Range(0,CreateAreas.Length)]) ;
				Areas[i].transform.localPosition = new Vector3(0,0,i*EriaWidth);
				Areas[i].transform.parent = this.transform;
			}else
			{
				
			}
			
			if( CameraMain.gameOver == false)
			{
				Areas[i].transform.localPosition = new Vector3(
					Areas[i].transform.localPosition.x ,
					Areas[i].transform.localPosition.y ,
					Areas[i].transform.localPosition.z - Time.deltaTime * nowSpeed);
			}
				
			if(Areas[0].transform.localPosition.z < -30)
			{
				Destroy( Areas[0] );
				Areas[0] = null;
		
				//
				for(int f = 0;f < Areas.Length-1; f++)
				{
					if( Areas[f] == null )
					{
						Areas[f] = Areas[f+1];
						Areas[f+1] = null;
					}
					
				}
			}
			
			
			
			
		}
	}
	
	
	
}














