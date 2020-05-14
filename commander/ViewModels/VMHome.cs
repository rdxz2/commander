using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace commander.ViewModels
{
    public class VMHome
    {
        public class Project
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class ProjectScript:INotifyPropertyChanged
        {
            //START -- PRIVATE PROPERTIES

            private int? ValuePid = null;

            //END -- PRIVATE PROPERTIES

            //START -- PUBLIC PROPERTIES

            public int Id { get; set; } = 0;

            public string Name { get; set; } = string.Empty;

            public string Script { get; set; } = string.Empty;

            public int? Pid
            {
                get
                {
                    return ValuePid;
                }
                set
                {
                    if (value != ValuePid)
                    {
                        ValuePid = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            //END -- PUBLIC PROPERTIES

            //private constructor
            private ProjectScript(int Id, string Name, string Script)
            {
                this.Id = Id;
                this.Name = Name;
                this.Script = Script;
            }

            //public factory method
            public static ProjectScript CreateNew(int Id, string Name, string Script) => new ProjectScript(Id, Name, Script);


            public event PropertyChangedEventHandler PropertyChanged;

            //property changes notifier
            public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
