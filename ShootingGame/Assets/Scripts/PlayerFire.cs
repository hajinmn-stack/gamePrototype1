using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;

        public GameObject firePosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);

            bullet.transform.position = firePosition.transform.position;
        }
    }
}
