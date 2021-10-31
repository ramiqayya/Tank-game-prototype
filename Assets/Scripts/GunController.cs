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

        if (socket.eulerAngles.z <= 35.2f || socket.eulerAngles.z >= 344.8f)
        {
            socket.Rotate(Vector3.forward * verticalInput);
        }
        else if (socket.eulerAngles.z > 35.0f && socket.eulerAngles.z < 40.0f)
        {
            socket.eulerAngles = new Vector3(socket.eulerAngles.x, socket.eulerAngles.y, 35.0f);
        }
        else if (socket.eulerAngles.z < 345.0f && socket.eulerAngles.z > 340.0f)
        {
            socket.eulerAngles = new Vector3(socket.eulerAngles.x, socket.eulerAngles.y, 345.0f);
        }


            //Debug.Log(socket.eulerAngles);
    }
}
