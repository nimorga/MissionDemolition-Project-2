using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    [Header("Inscribed")]//Set in Unity Inspector Pane (dragged prefab projectile)
    public GameObject projectilePrefab;
    public float velocityMult = 10f;

    [Header("Dynamic")]//Set Dynamically when game running
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;



    void Awake(){
        Transform launchPointTrans = transform.Find("LaunchPoint");//searches for a child of Slingshot named LaunchPoint
        launchPoint = launchPointTrans.gameObject; //gets gameobject associated w/ transform and assigns it to GameObject launchPoint
        launchPoint.SetActive(false); //SetActive shows the halo and that is the range user interacts with (deactivates the gameobject)
        launchPos = launchPointTrans.position;
    }

    //Enter and Exit Function of Sphere surronding the slingshot
    void OnMouseEnter(){
        //print("Slingshot: OnMouseEnter()");
        launchPoint.SetActive(true);
    }

    void OnMouseExit(){
        //print("Slingshot: OnMouseExit()");
        launchPoint.SetActive(false);
    }

    //User clicks in the Collider Component
    void OnMouseDown(){
        aimingMode = true; //Pressed mouse button
        projectile = Instantiate(projectilePrefab) as GameObject;//Created object
        projectile.transform.position = launchPos; //Start at launchPoint
        projectile.GetComponent<Rigidbody>().isKinematic = true; //Set to isKinematic
    }

    void Update(){
        if(!aimingMode) return;

        //Mouse pos in 2D screen
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        Vector3 mouseDelta = mousePos3D -launchPos; //Find delta from launchPos to mousePos3D

        //Limits mouseDelta to radius of Collider
        float maxMagnitude = this.GetComponent<SphereCollider>().radius;
        if(mouseDelta.magnitude > maxMagnitude){
            mouseDelta.Normalize();
            mouseDelta *= maxMagnitude;
        }

        //Move projectile to new Pos
        Vector3 projPos = launchPos + mouseDelta;
        projectile.transform.position = projPos;

        //Mouse Released
        if(Input.GetMouseButtonUp(0)){
            aimingMode = false;
            Rigidbody projRB = projectile.GetComponent<Rigidbody>();
            projRB.isKinematic = false;//once again respond to gravity
            projRB.collisionDetectionMode = CollisionDetectionMode.Continuous;
            projRB.velocity = -mouseDelta * velocityMult; //velocity proportional to mouse distance
            FollowCam.POI = projectile; //Calls from FollowCam.cs to set the MainCamera to follow the projectile
            projectile = null; //does not delete just clears to create another
        }

    }



}
