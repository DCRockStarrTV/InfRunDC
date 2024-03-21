using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    private Clancy clancy;

    bool alive = true;
    private Rigidbody rb;

    [SerializeField] private float speed;
    public float Adv;

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
        if (!alive) return; 

        Vector3 AdvMove = transform.right * Adv * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + AdvMove);

        Vector3 movementInput = clancy.Player.Move.ReadValue<Vector3>();
        float moveZ = movementInput.z;
        Vector3 movement = new Vector3(0, 0, moveZ);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (transform.position.y < -5)
        {
            Die();
        }
    }
}
