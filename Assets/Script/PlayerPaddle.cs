using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : MonoBehaviour
{

    [SerializeField] private float speed = 5;
    private Vector2 directionInput;
    // int - números inteiros
    // float - números decimais
    // bool - verdadeiro ou falso
    // string - texto
    // vector2 - (x,y)
    // vector2.up = (0,1)
    // directioninput = (0,0)
    // directionInput = value.Get<Vector2>() dará o valor de (0,1) para o directionInput
    // vector2 * directioninput = (0,1)
    // delta ajudará a não dar slow down 
    // delta é da classe time, então é necessário escrever time primeiro = time.deltaTime
    // transform.translate((0,1) * (0,1) * 5 * delta)
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * directionInput * speed * Time.deltaTime);
    }

    public void OnMove(InputValue value)
    {
        directionInput = value.Get<Vector2>(); 
    }
}
