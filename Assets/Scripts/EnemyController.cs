using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
   [SerializeField]private GameObject player;
   private float enemySpeed= 5.0f;
    public GameObject enemyShell;
    public Transform enemyGun;
    private float enemyGunPower = 100;
    //private bool isActive = true;

    private float distance;

    private void Start()
    {
        InvokeRepeating("EnemyFire", 2.0f, 2.0f);
    }
    void Update()
    {
        //transform.LookAt(player);

        float deltaX = player.transform.position.x - transform.position.x;
        float deltaZ = player.transform.position.z - transform.position.z;
      distance = Mathf.Sqrt(deltaX * deltaX + deltaZ * deltaZ);

        if (distance > 40)
            transform.Translate((player.transform.position - transform.position).normalized * enemySpeed * Time.deltaTime);

        Debug.Log("Distance:  " + distance);

    }

    private void EnemyFire()
    {
        if (distance < 200)
        {
            GameObject shellobj = Instantiate(enemyShell, enemyGun.position, enemyGun.rotation);
            Rigidbody shellRb = shellobj.GetComponent<Rigidbody>();
            shellRb.AddForce(enemyGun.forward * enemyGunPower, ForceMode.Impulse);
        }
    }
}
