using System;
using UnityEngine;

public class WaveGenerator : MonoBehaviour
{
    [SerializeField] LineRenderer line;
    [SerializeField] int acc = 100;
    [SerializeField] float lenght;
    [SerializeField] float[] amplitude;
    [SerializeField] float[] freq;
    [SerializeField] float[] speed;
    float x;
    float time;
    void Start(){

    }
    void Update(){
        generate();
        time += Time.deltaTime;
    }

    void generate(){
        x = 0;
        line.positionCount = acc;
        for (int i = 0; i < acc; i++)
        {
            line.SetPosition(i,new Vector3(x,sin(),0));
            x += lenght / acc;
        }
    }
    float sin(){
        float sum = 0;
        for (int i = 0; i < amplitude.Length; i++)
        {
            sum += (float) (amplitude[i] * Math.Sin(x * freq[i] + time * speed[i] * freq[i]));
        }
        return sum;
    }
}
