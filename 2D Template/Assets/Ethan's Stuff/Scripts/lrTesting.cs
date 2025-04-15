using UnityEngine;

public class lrTesting : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private lineController line;


    private void Awake()
    {
        line.SetUpLine(points);
    }

}
