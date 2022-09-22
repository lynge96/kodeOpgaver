namespace Model {
    public class Board
    {
        public Board() {

        }
        public Board(List<Todo> todos) {
            this.Todos = todos;
        }
        public long BoardId { get; set; }
        public List<Todo> Todos { get; set; } = new List<Todo>();
    }
}