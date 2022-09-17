// See https://aka.ms/new-console-template for more information

public partial class PhoneNetwork
{
    private List<Phone> phones = new List<Phone>();

    public void AddPhoneToNetwork(Phone thePhone)
    {
        phones.Add(thePhone);
    }

    public void CallPhone(int phoneNumber)
    {
        foreach (var phone in phones)
        {
            if (phone.Telefoonnummer == phoneNumber.ToString())
            {
                phone.Called += ThePhone_Called;
                phone.ReceiveCall();
                phone.Called -= ThePhone_Called;
            }
        }
    }

    public void SendMessageToPhone(int phoneNumber, string aMessage)
    {
        foreach (var phone in phones)
        {
            if (phone.Telefoonnummer == phoneNumber.ToString())
            {
                phone.Messaged += ThePhone_Messaged;
                phone.ReceiveMessage(aMessage);
                phone.Messaged -= ThePhone_Messaged;
            }
        }
    }

    private static void ThePhone_Called(object? sender, EventArgs e)
    {
        Console.WriteLine("The phone number " + sender + " received a call");
    }

    private static void ThePhone_Messaged(object? sender, MessageEventArgs e)
    {
        Console.WriteLine("The phone number " + sender + " received the following message: " + e.TheMessage);
    }
}