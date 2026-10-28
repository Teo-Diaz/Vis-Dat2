
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    [Header("Paneles del menu")]
    public GameObject panelMapa;
    public GameObject panelContexto;
    public GameObject panelNucleo;
    public GameObject panelGlosario;
    public GameObject panelCreditos;

    void Start()
    {
        MostrarMapa();
    }

    public void MostrarMapa()
    {
        OcultarTodos();
        panelMapa.SetActive(true);
    }

    public void MostrarContexto()
    {
        OcultarTodos();
        panelContexto.SetActive(true);
    }

    public void MostrarNucleo()
    {
        OcultarTodos();
        panelNucleo.SetActive(true);
    }

    public void MostrarGlosario()
    {
        OcultarTodos();
        panelGlosario.SetActive(true);
    }

    public void MostrarCreditos()
    {
        OcultarTodos();
        panelCreditos.SetActive(true);
    }

    void OcultarTodos()
    {
        panelMapa.SetActive(false);
        panelContexto.SetActive(false);
        panelNucleo.SetActive(false);
        panelGlosario.SetActive(false);
        panelCreditos.SetActive(false);
    }
}
