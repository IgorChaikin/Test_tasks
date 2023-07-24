using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;

namespace Igor_Chaikin_test_tasks_1_3
{
    class InstanceService<T>
    {
        public IEnumerable<T> GetInstances() {
            Type rootType = typeof(T);
            IEnumerable<Type> childTypes = rootType.Assembly.GetTypes().Where(
                assemblyType => rootType.IsAssignableFrom(assemblyType)
             );

            return childTypes
                .Select(childType => childType.GetConstructor(new Type[] {}))
                .Where(ctor => ctor is ConstructorInfo)
                .Select(ctor => {
                   T childTypeInstance = (T)ctor.Invoke(new object[] { });
                   return childTypeInstance;
                });
        }
    }
}
