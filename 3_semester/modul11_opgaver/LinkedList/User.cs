public class User {
    public string Name { get; set; }
    public int Id { get; set; }

    public User (string name, int id) {
        this.Name = name;
        this.Id = id;
    }
}