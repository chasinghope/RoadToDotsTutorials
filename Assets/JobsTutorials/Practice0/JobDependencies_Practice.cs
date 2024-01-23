using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using Unity.Jobs;
using UnityEngine;

public class JobDependencies_Practice : MonoBehaviour
{



    private void Start()
    {
        Practice_00();
    }

    void Practice_00()
    {
        JobA jobA = new JobA();
        JobB jobB = new JobB();
        JobC jobC = new JobC();
        JobD jobD = new JobD();
        JobE jobE = new JobE();
        JobF jobF = new JobF();
        JobG jobG = new JobG();
        JobH jobH = new JobH();


        JobHandle h = jobH.Schedule();

        JobHandle e = jobE.Schedule();
        JobHandle f = jobF.Schedule();
        JobHandle g = jobG.Schedule(h);

        JobHandle combine1 = JobHandle.CombineDependencies(e, f, g);
        JobHandle d = jobD.Schedule(combine1);

        JobHandle b = jobB.Schedule(d);
        JobHandle c = jobC.Schedule(d);

        JobHandle a = jobA.Schedule(b);


    }
}


[BurstCompile]
public struct JobA : IJob
{
    public void Execute()
    {
        Debug.Log("A ...");
    }
}

[BurstCompile]
public struct JobB : IJob
{
    public void Execute()
    {
        Debug.Log("B ...");
    }
}

[BurstCompile]
public struct JobC : IJob
{
    public void Execute()
    {
        Debug.Log("C ...");
    }
}


[BurstCompile]
public struct JobD : IJob
{
    public void Execute()
    {
        Debug.Log("D ...");
    }
}

[BurstCompile]
public struct JobE : IJob
{
    public void Execute()
    {
        Debug.Log("E ...");
    }
}

[BurstCompile]
public struct JobF : IJob
{
    public void Execute()
    {
        Debug.Log("F ...");
    }
}

[BurstCompile]
public struct JobG : IJob
{
    public void Execute()
    {
        Debug.Log("G ...");
    }
}

[BurstCompile]
public struct JobH : IJob
{
    public void Execute()
    {
        Debug.Log("H ...");
    }
}