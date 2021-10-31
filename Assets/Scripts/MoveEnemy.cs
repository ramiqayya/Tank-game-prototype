using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    //public GameObject player;
    //private float enemySpeed = 1.0f;

    //public Rigidbody enemyRb;

    //private void Start()
    //{
    //    enemyRb = this.GetComponent<Rigidbody>();
    //}


    //void Update()
    //{
        // transform.LookAt(player);

        //// Vector3 coordinates = transform.position - player.transform.position;
        //// float distance = Mathf.Sqrt(coordinates.x * coordinates.x + coordinates.z * coordinates.z);
        //Vector3 direction = player.transform.position - transform.position;
        //float deltaX = player.transform.position.x - transform.position.x;
        //float deltaZ = player.transform.position.z - transform.position.z;
        //float distance = Mathf.Sqrt(deltaX * deltaX + deltaZ * deltaZ);
        //float  angle = Mathf.Atan2(direction.x, direction.z)*Mathf.Rad2Deg ;
        //enemyRb.rotation = angle;
        
        //if (distance > 40)
        //{
        //    enemyRb.AddForce((player.transform.position - transform.position).normalized * enemySpeed);
        //}
        //  //  transform.Translate((player.transform.position - transform.position).normalized * enemySpeed * Time.deltaTime);


        //Debug.Log("Distance:  " + distance);
  // }
}
