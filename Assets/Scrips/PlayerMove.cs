using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private Clancy clancy;

    private Rigidbody rb;

    [SerializeField] private float speed;

    private void Awake()
    {
        clancy = new Clancy();
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        clancy.Enable();
        clancy.Player.Move.ReadValue<Vector3>();
    }

    private void FixedUpdate()
    {
        Vector3 movementInput = clancy.Player.Move.ReadValue<Vector3>();

        float moveZ = movementInput.z;

        Vector3 movement = new Vector3(0, 0, moveZ);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
