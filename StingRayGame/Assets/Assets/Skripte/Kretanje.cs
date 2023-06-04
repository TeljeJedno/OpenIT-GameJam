using UnityEngine;

public class Kretanje : MonoBehaviour
{
    [SerializeField] float brzina = 5.0f;
    
    public float Brzina { get => this.brzina; }

    void Update()
    {
        GetComponent<SpriteRenderer>().flipX = Input.GetAxis("Horizontal") < 0.0f;
        //transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(-50, 50, this.dzojstik.Vertical*Time.deltaTime*100f));
        Vector2 cilj = this.transform.position;
        cilj.x += Input.GetAxis("Horizontal") * this.brzina * Time.deltaTime;
        cilj.y += Input.GetAxis("Vertical") * this.brzina * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, cilj, this.brzina * Time.deltaTime);
    }
}