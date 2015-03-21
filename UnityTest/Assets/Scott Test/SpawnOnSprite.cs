using UnityEngine;
using System.Collections;

public class SpawnOnSprite : MonoBehaviour {

	public Vector3 ObjectSpawnPosition;
	public GameObject obj;
	public Vector3 ObjectSpawnPosition2;
	public GameObject obj2;
	public float BoxYPosition = -100;

	// Update is called once per frame
	void Update () {
		float x = Random.Range(0,2);
		if(Input.GetKeyDown(KeyCode.X)){
			if(x==0){
				GameObject.Instantiate(obj, ObjectSpawnPosition, Quaternion.identity);
			}

			if(x==1){
					GameObject.Instantiate(obj2, ObjectSpawnPosition2, Quaternion.identity);
					BoxYPosition = obj2.transform.position.y;

			}
		}
	}
}