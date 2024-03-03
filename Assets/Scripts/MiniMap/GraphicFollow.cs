using UnityEngine;

public class GraphicFollow : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    void Update()
    {
        gameObject.transform.SetParent(_gameObject.transform, false);
        gameObject.transform.position = _gameObject.transform.position;
    }
}
