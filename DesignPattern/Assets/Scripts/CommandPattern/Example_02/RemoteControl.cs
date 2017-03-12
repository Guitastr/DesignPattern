using UnityEngine;

namespace Assets.Scripts.CommandPattern.Example_02
{
    /// <summary>
    ///     遥控器类
    /// </summary>
    public class RemoteControl
    {
        private readonly ICommand[] _offCommands;
        private readonly ICommand[] _onCommands;

        /// <summary>
        /// 遥控器
        /// </summary>
        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
        }

        public void ToString()
        {
            Debug.Log("\n------ Remote Control ------\n");
            for (var i = 0; i < _onCommands.Length; i++)
                Debug.Log("[slot " + i + "]" + _onCommands[i].GetType().Name +
                          "   " + _offCommands[i].GetType().Name + "\n");
        }
    }
}