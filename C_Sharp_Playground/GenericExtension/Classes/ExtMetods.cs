using System;

namespace C_Sharp_Playground.GenericExtension.classes
{
    
    public static class ExtMetods
    {
        public static Action<object> Print = (o) => Console.WriteLine(o);
        public static void MakeSoundExt<T>(this T animal, Action<int> act) where T: IAnimal {
            switch (animal)
            { 
                case Horse h:
                    Console.WriteLine("Got a horse"); break;
                case Dog d:
                    Console.WriteLine("Got a dog"); break;
                default:
                    break;
                    
            }
            animal.makeSound();
            act?.Invoke(10);
        }
    }
}
