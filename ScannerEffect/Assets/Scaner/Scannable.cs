using UnityEngine;
using System.Collections;

public class Scannable : MonoBehaviour
{
    public bool Pingflag = false;
    public float ShowTimer = 0.0f;
	public void Ping()
	{
        ShowTimer = 5.0f;
        gameObject.SetActive(true);
    }

    public void Update()
    {


        ShowTimer -= Time.deltaTime;

        if(ShowTimer <= 0.0f)
        {
            gameObject.SetActive(false);

        }


    }
}
