namespace wise_wallet_api.Domains
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientCPF { get; set; }
        public string ClephoneNumber { get; set; }

        public Client(int clientId, string clientName, string clientCPF, string clephoneNumber)
        {
            ClientId = clientId;
            ClientName = clientName;
            ClientCPF = clientCPF;
            ClephoneNumber = clephoneNumber;
        }
    }
}
