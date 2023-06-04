using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Igrac : MonoBehaviour
{
    [SerializeField] Image barGoriva;
    [SerializeField] TextMeshProUGUI brojPutnika;
    private string easteregg = "hello";
    public float Gorivo { get; set; } = 600.0f;
    public int BrojPutnika { get; private set; } = 0;

    void Start() => this.PostaviKolicinuGoriva();

    void Update()
    {
        if (this.Gorivo < 0.0f)
        {
            Destroy(this.gameObject);
            return;
        }

        this.Gorivo -= 10.0f * Time.deltaTime;
        this.PostaviKolicinuGoriva();
    }

    void PostaviKolicinuGoriva()
    {
        Vector2 velicina = this.barGoriva.rectTransform.sizeDelta;
        this.barGoriva.rectTransform.sizeDelta = new Vector2(this.Gorivo, velicina.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Riba"))
            return;

        if (collision.collider.CompareTag("Zamka"))
        {
            Destroy(this.gameObject);
            return;
        }

        if (collision.collider.CompareTag("Putnik"))
        {
            this.BrojPutnika++;
            Destroy(collision.collider.gameObject);
        }
    }
}