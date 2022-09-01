﻿using Project.Application.TodoLists.Queries.ExportTodos;

namespace Project.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
