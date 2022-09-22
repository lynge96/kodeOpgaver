namespace Model {
    public class Todo
    {
        public Todo() {

        }
        public Todo(string titel, User bruger) {
            this.Title = titel;
            this.User = bruger;
        }
        public long TodoId { get; set; }
        public string Title { get; set; }
        public User User { get; set;}
    }
}