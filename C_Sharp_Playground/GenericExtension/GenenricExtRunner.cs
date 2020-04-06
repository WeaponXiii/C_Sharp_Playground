using System;
using System.Collections.Generic;

using C_Sharp_Playground.GenericExtension.classes;

namespace C_Sharp_Playground.GenericExtension
{
    public class GenenricExtRunner
    {
        public GenenricExtRunner(){
            var lst = new List<IAnimal>();
            //lst.AddRange(new { new Horse(), new () }); // ToDo: Use list initializers
            lst.Add(new Horse());
            lst.Add(new Dog());
            lst.Add(new Dog());
            lst.Add(new Dog());
            lst.Add(new Horse());
            lst.Add(new Dog());

            int i = 0;

            Action<object> writeLn = (o) => Console.WriteLine(o);

            lst.ForEach(x => {
                x.MakeSoundExt((v) => writeLn(i)); // This uses I form out side of execution scope
                i++;
            });

            (new Horse()).MakeSoundExt((x)=> Console.WriteLine("Dul Dul {0}",x)); // This uses x given from the execution scope
        }
    }
}
