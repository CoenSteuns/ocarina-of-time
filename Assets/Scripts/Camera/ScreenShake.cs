using UnityEngine;
using System.Collections;

public class ScreenShake : MonoBehaviour {

    private Camera _camera; // set this via inspector
    private float _shake = 2;
    private float shakeAmount = 0.05f;
    private float decreaseFactor =  1.0f;

    private ObjectFollow cam;
 
    void Start()
    {
        cam = GetComponent<ObjectFollow>();
    }

   void Update()
    {
        //cam.driffencePosition += new Vector3(0.1f, 0.1f, 0.1f); 
    }

    public void StartShake()
    {
        StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        Vector3 pos = cam.driffencePosition;
        
        while (true)
        {
            
            if (_shake > 0)
            {
                cam.driffencePosition = Random.insideUnitSphere * shakeAmount + pos;
                _shake -= Time.deltaTime * decreaseFactor;
                yield return new WaitForSeconds(0.05f);
            }
            else {
                _shake = 0.0f;
                cam.driffencePosition = pos;
                yield return null;
                continue;
            }
        }
    }
}
