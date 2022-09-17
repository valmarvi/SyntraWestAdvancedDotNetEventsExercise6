// See https://aka.ms/new-console-template for more information

public class Phone
{
    public string Telefoonnummer { get; }

    public Phone(string telefoonnummer)
    {
        Telefoonnummer = telefoonnummer;
    }

    public event EventHandler Called;

    public delegate void MessageEventHandler(object sender, MessageEventArgs e);

    public event MessageEventHandler Messaged;

    public void ReceiveCall()
    {
        Called.Invoke(this, null);
    }

    public void ReceiveMessage(string aMessage)
    {
        Messaged.Invoke(this, new MessageEventArgs(aMessage));
    }

}
