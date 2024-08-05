using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    [SerializeField]
    private Vector3 _start;
    [SerializeField]
    private Vector3 _end;
    [SerializeField]
    private float _speed = 10f;
    [SerializeField]
    private float _delay;

    private Vector3 End;
    private Vector3 realPosition;
    //g
    private IEnumerator Start()
    {
        End = _end;
        realPosition = transform.position;
        while (true)
        { 

            if (transform.position == _end + realPosition)
            {
                yield return new WaitForSeconds(_delay);
                End = _start;

            }
            if (transform.position == _start + realPosition)
            {
                yield return new WaitForSeconds(_delay);
                End = _end;

            }
            yield return null;
        }
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, End + realPosition, Time.deltaTime * _speed);
    }
}
