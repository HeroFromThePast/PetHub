using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class TextoEvento : MonoBehaviour
{
    [SerializeField] string[] mensajes;
    [SerializeField] Eventos positivo, negativo;
    [SerializeField] Image cuadroTexto;
    [SerializeField] TextMeshProUGUI mensaje;

   
    private void Start()
    {
        positivo.GEvent += EventoPositivo;
        negativo.GEvent += EventoNegativo;
    }

    public void Update()
    {
        if (Input.GetKeyDown((KeyCode.P)))
        {
            positivo.FireEvent();
        }
        if (Input.GetKeyDown((KeyCode.O)))
        {
            negativo.FireEvent();
        }
    }

    public void EventoPositivo()
    {
        mensaje.ClearMesh();
        mensaje.text = mensajes[0];
    }
    public void EventoNegativo()
    {
        mensaje.ClearMesh();
        mensaje.text = mensajes[1];
    }
}
