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
        private readonly NoCommand _noCommand;

        /// <summary>
        ///     遥控器
        /// </summary>
        public RemoteControl()
        {
            _onCommands = new ICommand[7];
            _offCommands = new ICommand[7];

            _noCommand = new NoCommand();
            for (var i = 0; i < 7; i++)
            {
                _onCommands[i] = _noCommand;
                _offCommands[i] = _noCommand;
            }
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (_offCommands[slot] != _noCommand)
                _onCommands[slot].Execute();
        }

        public void OffButtonWasPushed(int slot)
        {
            if (_offCommands[slot] != _noCommand)
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