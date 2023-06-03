using UnityEngine;

public class Kretanje : MonoBehaviour
{
    [SerializeField] float brzina = 5.0f;
    [SerializeField] DynamicJoystick dzojstik;
    
    void Update()
    {
        Vector2 cilj = this.transform.position;
        cilj.x += this.dzojstik.Horizontal * this.brzina * Time.deltaTime;
        cilj.y += this.dzojstik.Vertical * this.brzina * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, cilj, this.brzina * Time.deltaTime);
    }
}