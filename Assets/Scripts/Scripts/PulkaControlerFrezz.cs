using System.Collections;
using UnityEngine;

public class PulkaControlerFrezz : MonoBehaviour
{
    private int speed = 5;
    private Transform _endPosition;

    private IEnumerator PulkaStartMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.01f);
            PulkaMove();
        }
    }
    private void PulkaMove()
    {
        if (_endPosition == null)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPosition.position, speed * Time.deltaTime);

        }
    }
    public void SetUp(Transform transform)
    {
        _endPosition = transform;
    }
    public void MoveStartCoroutine()
    {
        StartCoroutine(PulkaStartMove());
    }
}
