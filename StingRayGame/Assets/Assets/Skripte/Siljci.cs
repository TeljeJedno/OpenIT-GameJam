using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Siljci : MonoBehaviour
{
    [SerializeField] float brzina = 2f; 
    [SerializeField] float razdaljina = 2f; 
    [SerializeField] Vector2 pravac = Vector2.down; 

    Vector2 inicijalnaPozicija;
    Vector2 krajnjaPozicija;

    void Start()
    {
        this.inicijalnaPozicija = this.transform.position;
        this.krajnjaPozicija = this.inicijalnaPozicija + this.razdaljina * this.pravac;
    }

    private void Update()
    {
        this.transform.Translate(this.brzina * Time.deltaTime * this.pravac);
        if (Vector2.Distance(this.transform.position, this.krajnjaPozicija) > this.brzina * Time.deltaTime)
            return;

        (this.inicijalnaPozicija, this.krajnjaPozicija) = (this.krajnjaPozicija, this.inicijalnaPozicija);
        this.pravac = -this.pravac;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Igrac"))
            return;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Destroy(collision.gameObject);
    }
}