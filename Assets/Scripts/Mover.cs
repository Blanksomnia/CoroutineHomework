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
    private float _delay = 1f;
	private IEnumerator Start()
    {
        var lenghtDistance = Vector3.Distance(_start, _end);
		var startTime = Time.time;
        var Start = _start;
        var End = _end;
        while (true)
		{
            var distance = (Time.time - startTime) * _speed;
            var moveTime = distance / lenghtDistance;
            transform.position = Vector3.Lerp(Start, End, moveTime);

            if(transform.position == _end)
            {
                yield return new WaitForSeconds(_delay);
                startTime = Time.time;
                Start = _end;
                End = _start;
                
            }
            if(transform.position == _start)
            {
                yield return new WaitForSeconds(_delay);
                startTime = Time.time;
                Start = _start;
                End = _end;
                
            }
            yield return null;
        }
	}
}
