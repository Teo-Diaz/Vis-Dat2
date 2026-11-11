
using UnityEngine;

public class MenuPrincipal : MonoBehaviour
{
    [Header("Paneles del menu")]
    public GameObject Toggle1;
    public GameObject Toggle2;
    public GameObject Toggle3;
    public GameObject Toggle4;
    public GameObject Toggle5;

    void Start()
    {
        MostrarToggle();
    }

    public void MostrarToggle()
    {
        OcultarTodos();
        Toggle1.SetActive(true);
    }

    public void MostrarToggle2()
    {
        OcultarTodos();
        Toggle2.SetActive(true);
    }

    public void MostrarToggle3()
    {
        OcultarTodos();
        Toggle3.SetActive(true);
    }

    public void MostrarToggle4()
    {
        OcultarTodos();
        Toggle4.SetActive(true);
    }

    public void MostrarToggle5()
    {
        OcultarTodos();
        Toggle5.SetActive(true);
    }

    void OcultarTodos()
    {
        Toggle1.SetActive(false);
        Toggle2.SetActive(false);
        Toggle3.SetActive(false);
        Toggle4.SetActive(false);
        Toggle5.SetActive(false);
    }
}
