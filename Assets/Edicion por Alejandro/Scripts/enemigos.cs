using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigos : MonoBehaviour
{

    [SerializeField ]public int vidaMax = 3;
    int vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = vidaMax;
    }

    public void RecibirDa?o(int da?o)
    {
        vidaActual -= da?o;

        if (vidaActual <= 0)
        {
            Muere();
        }
    }

    void Muere()
    {
          Destroy(this.gameObject);
          puertadesbloqueable.enemigosenlazona -= 1;
    }
}
