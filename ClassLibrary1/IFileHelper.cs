using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertorLib
{
    public interface IFileHelper
    {
        List<T> ReadFile<T>(string path, List<T> DataList) where T : DataClass;

        void WriteFile<T>(string path, List<T> DataList) where T : DataClass;
    }
}
