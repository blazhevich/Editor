using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor
{
    class MainWindowViewModel
    {
        public User[] Users { get; } = new User[]
        {
            new User { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23),
                SagImageUrl = Path.GetFullPath("sag.jpg"), AxImageUrl = Path.GetFullPath("ax.jpg"), CorImageUrl = Path.GetFullPath("cor.jpg") },
            new User { Id = 2, Name = "Jane Doe", Birthday = new DateTime(1974, 1, 17),
                SagImageUrl = Path.GetFullPath("sag.jpg"), AxImageUrl = Path.GetFullPath("ax.jpg"), CorImageUrl = Path.GetFullPath("cor.jpg") },
            new User { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2),
                SagImageUrl = Path.GetFullPath("sag.jpg"), AxImageUrl = Path.GetFullPath("ax.jpg"), CorImageUrl = Path.GetFullPath("cor.jpg") },
        };
    }
}
