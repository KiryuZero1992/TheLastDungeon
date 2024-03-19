using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody rb;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletSpeed = 30f;
    Vector3 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal"); //D�finir un input pour l'axe x
        movement.z = Input.GetAxisRaw("Vertical"); //D�finir un input pour l'axe z 
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); //Mettre en mouvement le personnage
    }
}
