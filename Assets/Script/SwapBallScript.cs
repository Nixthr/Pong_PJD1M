using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UIElements;

public class SwapBallScript : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float ballSpeed;
    [SerializeField] private float rotationBallSpeed = 360f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Launch();
    }


    private void Launch()

    {
        Vector2 direction = Vector2.zero;

        if(Random.value <= 0.5f)
        {
            direction = Vector2.left;

        }
        else
        {
            direction = Vector2.right;
        }

        direction.y = Random.Range(-0.5f, 0.5f);
        rb.linearVelocity = direction * ballSpeed;
    }

    private void Update()
    {
        transform.Rotate(0f, 0f, rotationBallSpeed * Time.deltaTime);
    }



} 