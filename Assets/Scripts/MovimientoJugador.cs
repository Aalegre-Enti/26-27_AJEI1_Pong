using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float speed = 1;
    public bool jugadorA;
    void Update()
    {
        Vector3 dir = new Vector3(0, 0);

        if (jugadorA == true)
        {
            //Jugador A
            if (Keyboard.current.wKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.sKey.isPressed)
            {
                dir.y = -1;
            }
        }
        else
        {
            //Jugador B
            if (Keyboard.current.upArrowKey.isPressed)
            {
                dir.y = 1;
            }
            if (Keyboard.current.downArrowKey.isPressed)
            {
                dir.y = -1;
            }
        }


        //La nueva posición = a la posición actual + la dirección
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
