using Unity.VisualScripting;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    Collider2D sensor;
    public bool isDetecting;
    [SerializeField] string gat;
    public GameObject ObjFind;
    void Start()
    {
        sensor = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(ObjFind == null)
        {
            isDetecting = false;
        }
    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(gat))
        {
            isDetecting = true;
            ObjFind = other.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag(gat))
        {
            isDetecting = false;
            ObjFind = null;
        }
    }
}
