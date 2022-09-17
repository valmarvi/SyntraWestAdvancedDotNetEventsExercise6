// See https://aka.ms/new-console-template for more information

public class MessageEventArgs : EventArgs
{
    public string TheMessage { get; set; }

    public MessageEventArgs(string theMessage)
    {
        TheMessage = theMessage;
    }
}