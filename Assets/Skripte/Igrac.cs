using UnityEngine;
using UnityEngine.UI;

public class Igrac : MonoBehaviour
{
    [SerializeField] Image barGoriva;
    [SerializeField] Text brojPutnika;
    public float Gorivo { get; set; } = 600.0f;
    public int BrojPutnika { get; set; } = 0;

    void Start() => this.PostaviKolicinuGoriva();

    void Update()
    {
        this.Gorivo -= 10.0f * Time.deltaTime;
        this.PostaviKolicinuGoriva();
    }

    void PostaviKolicinuGoriva()
    {
        Vector2 velicina = this.barGoriva.rectTransform.sizeDelta;
        this.barGoriva.rectTransform.sizeDelta = new Vector2(this.Gorivo, velicina.y);
    }

    void OnCollisionEnter2D(Collision2D collision) => Destroy(this.gameObject);
}