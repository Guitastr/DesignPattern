using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制器，调用者类
/// </summary>
public class SimpleRemoteControl
{
    private Command _slot;

    /// <summary>
    /// 设置命令不与实现，请求命令
    /// </summary>
    /// <param name="command">具体的命令</param>
    public void SetCommand(Command command)
    {
        _slot = command;
    }

    /// <summary>
    /// 按钮
    /// </summary>
    public void ButtonWasPressed()
    {
        _slot.Execute();
    }
}
