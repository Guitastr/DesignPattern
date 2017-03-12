using UnityEngine;

public class RemoteControlTest : MonoBehaviour
{
    private void Start()
    {
        RemoteControlModel.User();
    }
}

public class RemoteControlModel
{
    public static void User()
    {
        var remote = new SimpleRemoteControl();
        var light = new Light();
        var lightOnCommand = new LightOnCommand(light);

//        remote.SetCommand(lightOnCommand);
//        remote.ButtonWasPressed();

        var garageDoorOpen = new GarageDoorOpen();
        var garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoorOpen);
        remote.ButtonWasPressed();
    }
}