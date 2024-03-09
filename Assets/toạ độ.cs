using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toạđộ : MonoBehaviour
{
    public GameObject abc;
    public float spawntime;
    public float m_spawmtime;
    public void toado()
    {
        float a = Random.Range(0f, 18f);
        Vector2 toa_do = new Vector2(a, 10);
        if (abc)
        {
            Instantiate(abc, toa_do, Quaternion.identity);
        }
    }
    void Start()
    {
        m_spawmtime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        m_spawmtime -= (Time.deltaTime);
        if (m_spawmtime <= 0)
        {
            toado();
            m_spawmtime = spawntime;
        }

    }
}
