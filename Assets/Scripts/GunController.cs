using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    [SerializeField] private Transform socket;
    private float verticalInput;
    [SerializeField] private GameObject shellPrefab;
    [SerializeField]private Transform gun;
    [SerializeField]private float gunPower=100;
   
    

    private void Start()
    {
       
    }
    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shellobj = Instantiate(shellPrefab, gun.position, gun.rotation);
            Rigidbody shellRb = shellobj.GetComponent<Rigidbody>();
            shellRb.AddForce(gun.forward*gunPower, ForceMode.Impulse);
        }
    }
    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
       

        if (socket.localEulerAngles.x <= 5.2f || socket.localEulerAngles.x >= 349.8f)
         {
            socket.Rotate(Vector3.left * verticalInput);
        }
         else if (socket.localEulerAngles.x > 5.0f && socket.localEulerAngles.x < 40.0f)
         {
            socket.localEulerAngles = new Vector3(5.0f, socket.localEulerAngles.y, socket.localEulerAngles.z);
         }
         else if (socket.localEulerAngles.x < 350.0f && socket.localEulerAngles.x > 340.0f)
         {
             socket.localEulerAngles = new Vector3(350.0f , socket.localEulerAngles.y, socket.localEulerAngles.z);
         }


        Debug.Log(socket.localEulerAngles.x + " ,  " + socket.localEulerAngles.y+ " ,  "+socket.localEulerAngles.z);
    }
}
