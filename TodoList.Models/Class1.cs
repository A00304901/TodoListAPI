﻿namespace TodoList.Models
{
    public class ToDoItem
{
    public int Id { get; set; }
    public string? Title { get; set; }  // Nullable string
    public bool IsCompleted { get; set; }
    public DateTime? CompletedDate { get; set; }
}

}
