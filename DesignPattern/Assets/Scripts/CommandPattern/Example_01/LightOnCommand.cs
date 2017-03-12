using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class LightOnCommand : Command
{
    private Light _light;

    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }

    public void Undo()
    {
        
    }
}

/// <summary>
/// 接收者
/// </summary>
public class Light
{
    public void On()
    {
        Debug.Log("Light is On");
    }
}

public class GarageDoorOpenCommand : Command
{
    private readonly GarageDoorOpen _garageDoorOpen;


    public GarageDoorOpenCommand(GarageDoorOpen garageDoorOpen)
    {
        _garageDoorOpen = garageDoorOpen;
    }

    /// <summary>
    /// 会调用接收者的动作，以满足请求
    /// </summary>
    public void Execute()
    {
        _garageDoorOpen.Up();
    }

    public void Undo()
    {
        
    }
}

public class GarageDoorOpen
{
    public void Up()
    {
        Debug.Log("Garage Door isOpen");
    }

    public void Down()
    {
        
    }

    public void Stop()
    {
        
    }

    public void LightOn()
    {
        
    }

    public void LightOff()
    {
        
    }
}