using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20200309_Storage
{
    abstract class Storage
    {
        /*Базовый класс («Storage») содержит следующие закрытые поля:
■ наименование носителя;
■ модель.
Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами:
■ получение объема памяти;
■ копирование данных (файлов/папок) на устройство,
■ получение информации о свободном объеме памяти на устройстве;
■ получение общей/полной информации об устройстве.
         */

        string Name { get; set; }
        string Model { get; set; }

        public Storage(string name, string model) { this.Name = name; this.Model = model; }

        public abstract double GetMemorySize();
        public abstract void CopyFile();
        public abstract void FreeMemory();
        public abstract void AllInformationMemory();


    }
}
