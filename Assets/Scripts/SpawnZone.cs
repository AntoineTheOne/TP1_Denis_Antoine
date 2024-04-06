using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    [SerializeField] GameObject rochePrefab;
    [SerializeField] private Vector3 zoneSize;
    [SerializeField] private float repeatTime = 0.5f;

private void Start(){
InvokeRepeating("AddGameObject", 0, repeatTime);
}


void AddGameObject(){

    GameObject instantiated = Instantiate(rochePrefab);

        instantiated.transform.position = new Vector3(
            Random.Range(transform.position.x - zoneSize.x / 2, transform.position.x + zoneSize.x / 2),
            Random.Range(transform.position.x - zoneSize.y / 2, transform.position.x + zoneSize.y / 2),
            Random.Range(transform.position.x - zoneSize.z / 2, transform.position.x + zoneSize.z / 2)
        );
}



private void OnDrawGizmos() {
    Gizmos.color = Color.red;
    Gizmos.DrawWireCube(transform.position, zoneSize);
}






    
}
