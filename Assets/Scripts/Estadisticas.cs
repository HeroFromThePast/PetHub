using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas : MonoBehaviour
{
    static Estadisticas instance;
    public static Estadisticas Instance
    {
        get => instance;
    }
     public float salud, hambre, animo;
    
    [SerializeField] Eventos subirA, subirH, subirS, bajarA, bajarH, bajarS;
    public float aumentoS,aumentoH,aumentoA,disminucionS, disminucionH, disminucionA;

    private void Start()
    {
        //salud = 100;
        //hambre = 1;
        //animo = 100;
        instance = this;
        subirA.GEvent += SubirAnimo;
        subirH.GEvent += SubirHambre;
        subirS.GEvent += SubirSalud;
        bajarA.GEvent += BajarAnimo;
        bajarH.GEvent += BajarHambre;
        bajarS.GEvent += BajarSalud;
    }
    void SubirSalud()
    {
        salud += aumentoS;
        if (salud > 100)
        {
            salud = 100;
        }
    }
    void SubirHambre()
    {
        hambre += aumentoH;
        if (hambre > 100)
        {
            hambre = 100;
        }
    }
    void SubirAnimo()
    {
        animo += aumentoA;
        if (animo > 100)
        {
            animo = 100;
        }
    }
    void BajarSalud()
    {
        salud -= disminucionS;
        if (salud < 1)
        {
            salud = 1;
        }
    }
    void BajarHambre()
    {
        hambre -= disminucionH;
        if (hambre < 1)
        {
            hambre = 1;
        }
    }
    void BajarAnimo()
    {
        animo -= disminucionA;
        if (animo < 1)
        {
            animo = 1;
        }
    }
    private void OnDestroy()
    {
        subirA.GEvent -= SubirAnimo;
        subirH.GEvent -= SubirHambre;
        subirS.GEvent -= SubirSalud;
        bajarA.GEvent -= BajarAnimo;
        bajarH.GEvent -= BajarHambre;
        bajarS.GEvent -= BajarSalud;
    }
}
