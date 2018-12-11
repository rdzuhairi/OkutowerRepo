using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemy : MonoBehaviour {

    GameObject tower;
    GameObject terrain;
    float floatValue = 0.5f;

    float speed = 10f;
    //int speed = 2;

	// Use this for initialization
	void Start () {
        //find the cylinder and move towards that
        tower = GameObject.Find("tower");
        terrain = GameObject.Find("terrain");
	}
	
	// Update is called once per frame
	void Update () {
        if(tower == null){
            Destroy(this.gameObject);
        }else{
            Vector3 dir = tower.transform.position - this.transform.localPosition;
            float distanceTraveled = speed * Time.deltaTime;

            //move towards the tower
            this.transform.Translate(dir.normalized * distanceTraveled, Space.World);
            //this.transform.rotation = Quaternion.LookRotation(dir);
            //this.transform.rotation = Quaternion.LookRotation(dir);



            //Ray enemyRay = new Ray(this.transform.position, dir);
            //RaycastHit hit;

            //if(Physics.Raycast(enemyRay, out hit)){
            //    Debug.Log("hit something");
            //    this.transform.Translate(0, (floatValue - hit.distance), 0);
            //}

            var terPos = terrain.transform.position;
            this.transform.position = new Vector3(this.transform.position.x, terPos.y + floatValue, this.transform.position.z);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy"){
            Physics.IgnoreCollision(this.transform.GetComponent<Collider>(), GetComponent<Collider>());
        }
    }
}
