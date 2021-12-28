using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPSCamera : MonoBehaviour
{
    float rotationSpeed = 0.8f;
    public Transform Target, Player;
    float mouseX, mouseY;

    //GameObject that serves as the main character or whatever the camera should follow
    public GameObject Character;
    /*An Empty GameObject, that serves as a parent to the camera, 
	  and it's rotation will rotate the camera as we want since the camera is a child of it. */
    public GameObject CameraCenter;
    /*this variable is a bonus height to the CameraCenter, because my character had 
	its origin at its feet, which is not where i want the center of camera rotation to be.*/
    public float yOffset;
    /*Sensitivity = speed of rotation of camera (bigger it is, more sensitive
    	the camera is to input)  */
    public float sensitivity;
    //The Camera (child of CameraCenter)
    public Camera cam;
    RaycastHit camHit;
    //This one is public but no need to input any values for it
    public Vector3 CamDist;
    // Start is called before the first frame update

    void Start()
    {
        CamDist = cam.transform.localPosition;
        /* = The initial local position of the camera (relative to the CameraCenter), 
		 which is the maximal and normal Camera distance relative to it.*/
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //The CameraCenter (empty gameobject) follows always the character's position:
        CameraCenter.transform.position = new Vector3(Character.transform.position.x, Character.transform.position.y + yOffset, Character.transform.position.z);

        //Rotation of CameraCenter, and thus the camera, depending on Mouse Input:
        CamControl();

        cam.transform.localPosition = CamDist;
        GameObject obj = new GameObject();
        obj.transform.SetParent(cam.transform.parent);
        obj.transform.localPosition = new Vector3(cam.transform.localPosition.x, cam.transform.localPosition.y, cam.transform.localPosition.z - 0.1f);
        /*Linecast is an alternative to Raycast, using it to cast a ray between the CameraCenter 
          and a point directly behind the camera (to smooth things, that's why there's an "obj"
           GameObject, that is directly behind cam)	 */

        if (Physics.Linecast(CameraCenter.transform.position, obj.transform.position, out camHit))
        {
            //This gets executed if there's any collider in the way
            cam.transform.position = camHit.point;
            cam.transform.localPosition = new Vector3(cam.transform.localPosition.x, cam.transform.localPosition.y, cam.transform.localPosition.z + 0.1f);
        }
        
        //Clean up
        Destroy(obj);

    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        //mouseY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        //mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Target);

        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        //}
        //else
        //{
        //Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        //Player.rotation = Quaternion.Euler(0, mouseX, 0);
        //}
    }

}
