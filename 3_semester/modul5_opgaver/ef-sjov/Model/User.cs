namespace Model {
    public class User
    {
        public User(string navn) {
            this.Name = navn;
        }
        public long UserId { get; set; }
        public string Name { get; set; }
    }
}