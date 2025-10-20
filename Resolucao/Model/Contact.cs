namespace Resolucao.Model
{
    public class Contact
    {
        private string Email { get; set; }
        private string? Phone { get; set; }

        public Contact(string email, string? phone)
        {
            this.Email = email;
            this.Phone = phone;
        }

        public void SetPhone(string phone)
        {
            this.Phone = phone;
        }

        public override string ToString()
        {
            return $"Email: {this.Email}\n" +
                $"Phone: {this.Phone}";
        }
    }
}