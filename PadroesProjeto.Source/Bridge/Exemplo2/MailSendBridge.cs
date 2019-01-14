namespace PadroesProjeto.Source.Bridge
{
    public class MailSendBridge
    {
        public void SendFrom(IMessage obj)
        {
            obj.Send();
        }
    }
}