using UnityEngine;
using TMPro;

public class GestorPuntuacion : MonoBehaviour
{
    public int puntuacionA;
    public int puntuacionB;

    public TMP_Text puntuacionAtexto;
    public TMP_Text puntuacionBtexto;

    //int: numero entero
    //float: numero decimal
    //bool: verdadero/falso
    //string: texto o cadena de caracteres
    //Vector3: 3 numeros decimales

    void Update()
    {
        puntuacionAtexto.text = puntuacionA.ToString();
        puntuacionBtexto.text = puntuacionB.ToString();

        if (puntuacionA > 10)
        {
            Debug.Log("Jugador A ha ganado");
        }
        if (puntuacionB > 10)
        {
            Debug.Log("Jugador B ha ganado");
        }
    }
}
