using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UcitajScenu : MonoBehaviour
{
    public string scena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ucitajNovuScenu()
    {
        SceneManager.LoadScene(scena);
    }

    public void quit() {
        Application.Quit();
    }
}
