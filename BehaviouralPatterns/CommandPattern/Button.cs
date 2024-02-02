﻿namespace CommandPattern;

public class Button
{
    private readonly ICommand _command;

    public Button(ICommand command)
    {
        _command = command;
    }

    public void Click()
    {
        _command.execute();
    }
}
