using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    /// <summary>
    ///     使用遥控器
    /// </summary>
    public class RemoteLoaderView : MonoBehaviour
    {
        public void Start()
        {
            var remoteControl = new RemoteControl();

            //将所有的装置创建在合适的位置
            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living Room");
            var garageDoor = new GarageDoor("");
            var stereo = new Stereo("Living Room");

            //创建所有的电灯命令对象
            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            //创建吊扇的开与关命令
            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            //创建车库门的上与下命令
            var garageDoorUp = new GarageDoorUpCommand(garageDoor);
            var garageDoorDown = new GarageDoorDownCommand(garageDoor);

            //创建音响的开与关命令
            StereoOnWithCDCommand stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            StereoOffWithCDCommand stereoOffWithCD = new StereoOffWithCDCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCD, stereoOffWithCD);

            remoteControl.ToString();

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
        }
    }
}