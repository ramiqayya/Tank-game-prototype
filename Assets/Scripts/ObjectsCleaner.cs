using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsCleaner : MonoBehaviour
{
   

    IEnumerator DestroyAfterSeconds(GameObject enemyShell)
    {
        yield return new WaitForSeconds(5);
        Destroy(enemyShell);
    }

    IEnumerator DestroyPlayerProjectile(GameObject playerShell)
    {
        yield return new WaitForSeconds(7);
        Destroy(playerShell);

    }

    private GameObject OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy Shell"))
        {
            StartCoroutine(DestroyAfterSeconds(collision.collider.gameObject));
            return collision.collider.gameObject;
        }
        else if (collision.collider.CompareTag("Shell"))
        {
            StartCoroutine(DestroyPlayerProjectile(collision.collider.gameObject));
            return collision.collider.gameObject;
        }else return null;
    }

    
}
