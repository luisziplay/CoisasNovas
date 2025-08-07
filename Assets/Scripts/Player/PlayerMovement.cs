using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    [Header("Forca do Pulo/Velocidade")]
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float forcaPulo = 7f;
    [SerializeField] private float raioChao = 0.3f;
    [SerializeField] private LayerMask camadaChao;
    [SerializeField] private Transform checagemChao;
    private float horizontal;
    private float vertical;
    private Rigidbody rb;
    private Vector3 direcaoMovimento;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        Andar();
        Pular();
    }

    private void Andar()
    {
        vertical = Input.GetAxis("Vertical")
        Vector3 moveDirection = transform.forward * vertical;
        Vector3 moveForward = rb.position + moveDirection * velocidade * Time.deltaTime;
        rb.MovePosition(moveForward);
    }

    private bool EstaNoChao()
    {
        return Physics.CheckSphere(checagemChao.position, raioChao, camadaChao);
    }


    private void Pular()
    {
        if (Input.GetKey(KeyCode.Space) && EstaNoChao())
        {
            rb.AddForce(Vector3.up *  forcaPulo, ForceMode.Impulse);
        }
    }



}
