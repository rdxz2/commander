using System;
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

            private string  ValueName = null;
            private string  ValueScript = null;
            private int? ValuePid = null;

            private DateTime? ValueLastExecuted = null;

            //END -- PRIVATE PROPERTIES

            //START -- PUBLIC PROPERTIES

            public int Id { get; set; } = 0;

            public string Name
            {
                get
                {
                    return ValueName;
                }
                set
                {
                    if (value != ValueName)
                    {
                        ValueName = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            public string Script
            {
                get
                {
                    return ValueScript;
                }
                set
                {
                    if (value != ValueScript)
                    {
                        ValueScript = value;
                        NotifyPropertyChanged();
                    }
                }
            }

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

            public DateTime? LastExecuted
            {
                get
                {
                    return ValueLastExecuted;
                }
                set
                {
                    if (value != ValueLastExecuted)
                    {
                        ValueLastExecuted = value;
                        NotifyPropertyChanged();
                    }
                }
            }

            //END -- PUBLIC PROPERTIES

            //private constructor
            private ProjectScript(int Id, string Name, string Script, DateTime? LastExecuted)
            {
                this.Id = Id;

                ValueName = Name;
                ValueScript = Script;
                ValueLastExecuted = LastExecuted;
            }

            //public factory method
            public static ProjectScript CreateNew(int Id, string Name, string Script, DateTime? LastExecuted) => new ProjectScript(Id, Name, Script, LastExecuted);


            public event PropertyChangedEventHandler PropertyChanged;

            //property changes notifier
            public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
