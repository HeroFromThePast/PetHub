using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Situacion")]
public class SituacionesYCambios : ScriptableObject
{
    [SerializeField] string nombreSituacion;
    [SerializeField] float aS, aA, aH,dS,dA,dH;
    
    
    

    // Start is called before the first frame update
    

    public void AlterarStats(Estadisticas mascota)
    {
        
            mascota.aumentoA = aA;
            mascota.aumentoH = aH;
            mascota.aumentoS = aS;
            mascota.disminucionA = dA;
            mascota.disminucionH = dH;
            mascota.disminucionS = dS;
        
    }
    
}
