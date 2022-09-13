// TodoTask.cs
namespace Model
{
    public class TodoTask
    {
        public TodoTask(string text, bool done, string category, User navn) {
            this.Text = text;
            this.Done = done;
            this.Category = category;
            this.Name = navn;
        }
        public TodoTask(string text, bool done, string category) {
            this.Text = text;
            this.Done = done;
            this.Category = category;
        }
        public long TodoTaskId { get; set; }
        public string? Text { get; set; }
        public bool Done { get; set; }
        public string Category { get; set; }
        public User? Name { get; set; }
    }
}
