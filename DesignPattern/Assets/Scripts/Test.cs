using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
   

    public void Start()
    {
        GlobalData.iTest = new Class02();
        GlobalData.iTest.Start();
    }
}


public class GlobalData
{
    public static ITest iTest;

    static GlobalData()
    {
         iTest = new Class01();
    }
}


public interface ITest
{
   void Start();
}

public class Class01 : ITest
{
    public void Start()
    {
        Debug.Log("Class01");
    }
}

public class Class02 : ITest
{
    public void Start()
    {
       Debug.Log("Class02"); 
    }
}

