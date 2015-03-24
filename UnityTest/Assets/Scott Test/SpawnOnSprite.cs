using UnityEngine;
using System.Collections;


public class SpawnOnSprite : MonoBehaviour {

	public Vector3 ObjectSpawnPosition;
	public GameObject obj;
	public Vector3 ObjectSpawnPosition2;
	public GameObject obj2;


	public bool checkIfPosEmpty(Vector3 targetPos){
		GameObject[] allGems = GameObject.FindGameObjectsWithTag("Gem");
		GameObject lastItem = allGems [allGems.Length - 1];
		if(lastItem.transform.position.y >= targetPos.y){
			if(Mathf.Round(lastItem.transform.position.x) != targetPos.x){
				return true;
			}
			else{
				return false;
			}
		}
		return true;
	}
	// Update is called once per frame
	void Update () {
		float x = Random.Range(0,2);
		if(Input.GetKeyDown(KeyCode.X)){
			if(x==0){
				GameObject.Instantiate(obj, ObjectSpawnPosition, Quaternion.identity);
			}

			if(x==1){
				if(checkIfPosEmpty(ObjectSpawnPosition2)){
					GameObject.Instantiate(obj2, ObjectSpawnPosition2, Quaternion.identity);

				}
			}
		}
	}

}