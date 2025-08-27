using ScriptApp.Models;

namespace ScriptApp.Services
{
    public class ScriptService
    {
        private readonly List<Script> scripts = new();
        private int nextId = 1;

        public List<Script> GetAll() => scripts;
        // 📌 Добавление блочного сценария
        public Script AddScript(string title, List<Block> blocks)
            {
                var script = new Script
                {
                    Id = nextId++,
                    Title = title,
                    Blocks = blocks.Select(b => new Block
                    {
                        X = b.X,
                        Y = b.Y,
                        Width = b.Width,
                        Height = b.Height,
                        Content = b.Content
                    }).ToList()
                };
                scripts.Add(script);
                return script;
            }

        // 📌 Добавление текстового сценария
        public Script AddTextScript(string title, string textContent)
        {
            var script = new Script
            {
                Id = nextId++,
                Title = title,
                TextContent = textContent,
                Blocks = new List<Block>() // пустой список блоков
            };
            scripts.Add(script);
            return script;
        }

    public Script? GetById(int id) => scripts.FirstOrDefault(s => s.Id == id);
    }
}
