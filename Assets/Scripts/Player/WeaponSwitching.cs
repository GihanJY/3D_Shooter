using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;
    [SerializeField] private GameObject[] holsters;
    [SerializeField] private GameObject[] aims;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            holster(1);
            holster(2);
            draw(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            holster(0);
            holster(2);
            draw(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            holster(0);
            holster(1);
            draw(2);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            holster(0);
            holster(1);
            holster(2);
        }
    }
    private void holster(int x)
    {
        if (weapons[x].transform.parent == aims[0].transform || weapons[x].transform.parent == aims[1].transform)
        {
            weapons[x].transform.SetParent(holsters[x].transform);
            weapons[x].transform.rotation = Quaternion.Euler(0, 0, 0);
            weapons[x].transform.position = holsters[x].transform.position;
        }
    }
    private void draw(int x)
    {
        if (weapons[x].transform.parent == holsters[x].transform) 
        {
            weapons[x].transform.SetParent(aims[0].transform);
            weapons[x].transform.rotation = Quaternion.Euler(90, 0, 0);
            weapons[x].transform.position = aims[0].transform.position;
        }
        
    }
}
